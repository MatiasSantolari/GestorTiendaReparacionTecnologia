using Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class ClienteForm : Form
    {
        private ClienteController _controller;
        private string _nombre;
        private string _tel;
        private string _email;
        private Boolean _formAgregar;
        private int _idClienteEditar;
        public ClienteForm()
        {
            _controller = new ClienteController();
            _formAgregar = true;
            InitializeComponent();
        }
        public ClienteForm(int id)
        {
            _controller = new ClienteController();
            _formAgregar = false;
            _idClienteEditar = id;
            InitializeComponent();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            if (_formAgregar == false) //voy a editar
            {
                var emp = _controller.GetOne(_idClienteEditar);
                txtNombre.Text = emp.Nombre;
                txtTel.Text = emp.Telefono;
                txtEmail.Text = emp.Email;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _nombre = txtNombre.Text;
            _tel = txtTel.Text;
            _email = txtEmail.Text;

            if (_formAgregar == false) //voy a guardar una actualizacion de un registro
            {
                _controller.Modificar(_idClienteEditar, _nombre, _tel, _email);
            }
            if (_formAgregar == true) //voy a guardar un nuevo registro
            {
                _controller.Registrar(_nombre, _tel, _email);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
