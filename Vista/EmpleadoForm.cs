using Controladores;
using Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class EmpleadoForm : Form
    {
        private EmpleadoController _controller;
        private string _nombre;
        private string _tel;
        private string _email;
        private string _pass;
        private string _repPass;
        private string _rol;
        private Boolean _formAgregar;
        private int _idEmpleadoEditar;
        public EmpleadoForm()
        {
            _controller = new EmpleadoController();
            _formAgregar = true;
            InitializeComponent();
        }
        public EmpleadoForm(int id)
        {
            _controller = new EmpleadoController();
            _formAgregar = false;
            _idEmpleadoEditar = id;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _nombre = txtNombre.Text;
            _tel = txtTel.Text;
            _email = txtEmail.Text;
            _pass = txtPass.Text;
            _repPass = txtRepPass.Text;
            _rol = cbRol.SelectedItem.ToString();

            // Validaciones básicas
            if (!ValidacionesVista.EsTextoValido(_nombre))
            {
                MessageBox.Show("Nombre inválido.");
                return;
            }
            if (!ValidacionesVista.EsTelefonoValido(_tel))
            {
                MessageBox.Show("Teléfono inválido.");
                return;
            }
            if (!ValidacionesVista.EsEmailValido(_email))
            {
                MessageBox.Show("Email inválido.");
                return;
            }
            if (!ValidacionesVista.ComboBoxSeleccionado(cbRol))
            {
                MessageBox.Show("Debe seleccionar un rol.");
                return;
            }

            // Si se ingresó contraseña, validar fuerza
            if (!string.IsNullOrWhiteSpace(_pass) && !ValidacionesVista.EsPasswordFuerte(_pass))
            {
                MessageBox.Show("Contraseña muy débil.");
                return;
            }

            try
            {
                bool resultado;

                if (_formAgregar)
                    resultado = _controller.Registrar(_nombre, _tel, _email, _rol, _pass, _repPass);
                else
                    resultado = _controller.Modificar(_idEmpleadoEditar, _nombre, _tel, _email, _rol, _pass, _repPass);

                if (!resultado)
                {
                    MessageBox.Show("Las contraseñas no coinciden o no es una contraseña valida.");
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmpleadoForm_Load(object sender, EventArgs e)
        {
            cbRol.SelectedIndex = 0; // selecciona "Técnico"
            lblAclaracion.Visible = false;

            if (_formAgregar == false) //voy a editar
            {
                var emp = _controller.GetOne(_idEmpleadoEditar);
                txtNombre.Text = emp.Nombre;
                txtTel.Text = emp.Telefono;
                txtEmail.Text = emp.Email;
                cbRol.SelectedItem = emp.Rol;

                lblAclaracion.Visible = true;

                if (SesionActual.Empleado.EmpleadoID == _idEmpleadoEditar
                    && SesionActual.EsTecnico) cbRol.Enabled = false;
            }
        }
    }
}
