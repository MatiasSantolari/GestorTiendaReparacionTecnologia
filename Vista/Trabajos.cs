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
    public partial class Trabajos : Form
    {
        private TrabajoController _controller;
        private int _idCliente;
        public Trabajos(int idCliente)
        {
            _controller = new TrabajoController();
            InitializeComponent();
            dgvTrabajos.CellContentClick += dgvTrabajos_CellContentClick;
            _idCliente = idCliente;
        }

        private void Trabajos_Load(object sender, EventArgs e)
        {
            dgvTrabajos.Columns.Clear();
            dgvTrabajos.DataSource = _controller.GetTrabajosCliente(_idCliente);
            dgvTrabajos.AllowUserToAddRows = false; //impide que se cree una ultima fila vacia en el dgv

            Utils.DataGridViewHelper.AgregarBotonVerTareas(dgvTrabajos);
            Utils.DataGridViewHelper.AgregarBotonVerEmpleados(dgvTrabajos);
            Utils.DataGridViewHelper.AgregarBotonGenerarTicket(dgvTrabajos);
            Utils.DataGridViewHelper.AgregarBotonEditarEliminar(dgvTrabajos);
        }

        private void dgvTrabajos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora los clics en encabezados
            if (e.RowIndex < 0) return;

            // Obtené el ID del registro desde la fila clickeada
            int idTrabajo = Convert.ToInt32(dgvTrabajos.Rows[e.RowIndex].Cells["TrabajoID"].Value);

            if (dgvTrabajos.Columns[e.ColumnIndex].Name == "btnVerTareas")
            {
                // Abre el formulario con los datos de ese registro
                Tareas tareaForm = new Tareas(idTrabajo, "parametro inservible");
                if (tareaForm.ShowDialog() == DialogResult.OK) Trabajos_Load(null, null); // recarga la grilla
            }
            if (dgvTrabajos.Columns[e.ColumnIndex].Name == "btnVerEmpleados")
            {
                // Abre el formulario con los datos de ese registro
                AgregarEmpleadoForm agregarEmpleadoForm = new AgregarEmpleadoForm(idTrabajo);
                if (agregarEmpleadoForm.ShowDialog() == DialogResult.OK) Trabajos_Load(null, null); // recarga la grilla
            }
            if (dgvTrabajos.Columns[e.ColumnIndex].Name == "btnGenerarTicket")
            {
                var trabajo = _controller.GetOne(idTrabajo);
                if (trabajo.Estado != "Terminado")
                {
                    MessageBox.Show("El trabajo debe estar terminado antes de generar el ticket", "Trabajo no terminado", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Abre el formulario con los datos de ese registro
                    GenerarTicket generarTicketForm = new GenerarTicket(idTrabajo);
                    if (generarTicketForm.ShowDialog() == DialogResult.OK) Trabajos_Load(null, null); // recarga la grilla
                }
            }
            if (dgvTrabajos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                // Abre el formulario con los datos de ese registro
                TrabajoForm trabajoForm = new TrabajoForm(_idCliente, idTrabajo);
                if (trabajoForm.ShowDialog() == DialogResult.OK) Trabajos_Load(null, null); // recarga la grilla
            }
            if (dgvTrabajos.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                var confirm = MessageBox.Show("¿Estás seguro de eliminar este Trabajo?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _controller.Eliminar(idTrabajo);
                    Trabajos_Load(sender, e); // recarga la grilla
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TrabajoForm trabajoForm = new TrabajoForm(_idCliente);
            if (trabajoForm.ShowDialog() == DialogResult.OK) Trabajos_Load(null, null); // recarga la grilla
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
