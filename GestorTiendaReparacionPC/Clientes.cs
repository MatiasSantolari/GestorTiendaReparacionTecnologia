using Controladores;
using Utils;
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
    public partial class Clientes : Form
    {
        private ClienteController _controller;
        public Clientes()
        {
            _controller = new ClienteController();
            InitializeComponent();
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dgvClientes.Columns.Clear();
            dgvClientes.DataSource = _controller.GetAll();
            dgvClientes.AllowUserToAddRows = false; //impide que se cree una ultima fila vacia en el dgv

            Utils.DataGridViewHelper.AgregarBotonVerTrabajos(dgvClientes);
            Utils.DataGridViewHelper.AgregarBotonEditarEliminar(dgvClientes);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm();
            if (clienteForm.ShowDialog() == DialogResult.OK) Clientes_Load(null, null); // solo recarga si se guardó algo
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora los clics en encabezados
            if (e.RowIndex < 0) return;

            // Obtené el ID del registro desde la fila clickeada
            int idCliente = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["ClienteID"].Value);

            if (dgvClientes.Columns[e.ColumnIndex].Name == "btnVerTrabajos")
            {
                // Abre el formulario con los datos de ese registro
                Trabajos trabajoForm = new Trabajos(idCliente);
                if (trabajoForm.ShowDialog() == DialogResult.OK) Clientes_Load(null, null); // recarga la grilla
            }
            if (dgvClientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                // Abre el formulario con los datos de ese registro
                ClienteForm clienteForm = new ClienteForm(idCliente);
                if (clienteForm.ShowDialog() == DialogResult.OK) Clientes_Load(null, null); // solo recarga si se guardó algo
                
            }
            else if (dgvClientes.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                var confirm = MessageBox.Show("¿Estás seguro de eliminar este Cliente?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _controller.Eliminar(idCliente);
                    Clientes_Load(null, null); // recarga la grilla
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = _controller.GetClientesPorNombre(txtBusqueda.Text);
        }
    }
}