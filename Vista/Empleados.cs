using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Seguridad;
using Utils;

namespace Vista
{
    public partial class Empleados : Form
    {
        private EmpleadoController _controller;
        private int _idTrabajo = 0;
        public Empleados()
        {
            _controller = new EmpleadoController();
            InitializeComponent();
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
        }
        public Empleados(int idTrabajo)
        {
            _controller = new EmpleadoController();
            _idTrabajo = idTrabajo;
            InitializeComponent();
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.Columns.Clear();
            if (_idTrabajo != 0) dgvEmpleados.DataSource = _controller.GetEmpleadosDelTrabajo(_idTrabajo);
            else dgvEmpleados.DataSource = _controller.GetAll();

            dgvEmpleados.AllowUserToAddRows = false; //impide que se cree una ultima fila vacia en el dgv
            
            if (SesionActual.EsAdmin) //solo si es admin puede editar eliminar empleados
            {
                Utils.DataGridViewHelper.AgregarBotonEditarEliminar(dgvEmpleados);
                Utils.DataGridViewHelper.AgregarBotonVerTareas(dgvEmpleados);
            }
            else
            {
                btnAgregar.Visible = false;
                txtBusqueda.Visible = false;
                btnBuscar.Visible = false;
            }

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EmpleadoForm empleadoForm = new EmpleadoForm();
            if (empleadoForm.ShowDialog() == DialogResult.OK) Empleados_Load(null, null); // solo recarga si se guardó algo
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora los clics en encabezados
            if (e.RowIndex < 0) return;

            // Obtené el ID del registro desde la fila clickeada
            int idEmpleado = Convert.ToInt32(dgvEmpleados.Rows[e.RowIndex].Cells["EmpleadoID"].Value);

            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "btnVerTareas")
            {
                // Abre el formulario con los datos de ese registro
                Tareas tareaForm = new Tareas(idEmpleado);
                if (tareaForm.ShowDialog() == DialogResult.OK) Empleados_Load(null, null); // recarga la grilla
            }
            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                // Abre el formulario con los datos de ese registro
                EmpleadoForm empleadoForm = new EmpleadoForm(idEmpleado);
                if (empleadoForm.ShowDialog() == DialogResult.OK) Empleados_Load(null, null); // recarga la grilla
            }
            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                var confirm = MessageBox.Show("¿Estás seguro de eliminar este Empleado?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _controller.Eliminar(idEmpleado);
                    Empleados_Load(null, null); // recarga la grilla
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = _controller.GetEmpleadosPorNombre(txtBusqueda.Text);
        }

        private void Empleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
