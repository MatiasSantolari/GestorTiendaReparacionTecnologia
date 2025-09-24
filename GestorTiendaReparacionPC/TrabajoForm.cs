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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Vista
{
    public partial class TrabajoForm : Form
    {
        private TrabajoController _controllerTrabajo;
        private ClienteController _controllerCliente;
        private Boolean _formAgregar;
        private int _idTrabajoEditar;
        private string _dispositivo;
        private string _problema;
        private string _estado;
        private string _cliente;
        private int _idCliente;

        public TrabajoForm(int idCliente) //agrega una nueva tarea a un cliente
        {
            _controllerTrabajo = new TrabajoController();
            _controllerCliente = new ClienteController();
            _formAgregar = true;
            _idCliente = idCliente;
            InitializeComponent();
        }
        public TrabajoForm(int idCliente, int idTrabajo) //edita la tarea de un cliente
        {
            _controllerTrabajo = new TrabajoController();
            _controllerCliente = new ClienteController();
            _formAgregar = false;
            _idCliente = idCliente;
            _idTrabajoEditar = idTrabajo;
            InitializeComponent();
        }

        private void TrabajoForm_Load(object sender, EventArgs e)
        {
            cbEstado.SelectedIndex = 0; // selecciona "Técnico"
            if (_formAgregar == false) //voy a editar
            {
                var tra = _controllerTrabajo.GetOne(_idTrabajoEditar);
                txtDispositivo.Text = tra.NombreDispositivo;
                txtProblema.Text = tra.DescripcionProblema;
                cbEstado.Enabled = true;
                cbEstado.SelectedItem = tra.Estado;
                txtCliente.Text = tra.Cliente.Nombre;
            }
            else
            {
                var cli = _controllerCliente.GetOne(_idCliente);
                txtCliente.Text = cli.Nombre; //acá
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _dispositivo = txtDispositivo.Text;
            _problema = txtProblema.Text;
            _estado = cbEstado.SelectedItem.ToString();

            if (_formAgregar == false) //voy a guardar una actualizacion de un registro
            {
                _controllerTrabajo.Modificar(_idTrabajoEditar, _dispositivo, _problema, _estado);
            }
            if (_formAgregar == true) //voy a guardar un nuevo registro
            {
                _controllerTrabajo.Registrar(_dispositivo, _problema, _estado, _idCliente);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
