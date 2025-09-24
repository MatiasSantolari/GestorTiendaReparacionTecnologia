using Controladores;
using Modelos;
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
    public partial class TareaForm : Form
    {
        private TareaController _controller;
        private string _nombre;
        private string _detalle;
        private float _precio;
        private Boolean _formAgregar;
        private int _idTareaEditar;
        public TareaForm()
        {
            _controller = new TareaController();
            _formAgregar = true;
            InitializeComponent();
        }
        public TareaForm(int id)
        {
            _controller = new TareaController();
            _formAgregar = false;
            _idTareaEditar = id;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _nombre = txtNombre.Text;
            _detalle = txtDetalle.Text;
            if (!float.TryParse(txtPrecio.Text, out _precio))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
                return;
            }

            if (_formAgregar == false) //voy a guardar una actualizacion de un registro
            {
                _controller.Modificar(_idTareaEditar, _nombre, _detalle, _precio);
            }
            if (_formAgregar == true) //voy a guardar un nuevo registro
            {
                _controller.Registrar(_nombre, _detalle, _precio);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TareaForm_Load(object sender, EventArgs e)
        {
            if (_formAgregar == false) //voy a editar
            {
                var tar = _controller.GetOne(_idTareaEditar);
                txtNombre.Text = tar.Nombre;
                txtDetalle.Text = tar.Detalle;
                txtPrecio.Text = (tar.PreciosTarea.FirstOrDefault()?.Monto).ToString();
            }
        }
    }
}
