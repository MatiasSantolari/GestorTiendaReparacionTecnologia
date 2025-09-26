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
using Seguridad;
using Microsoft.IdentityModel.Tokens;

namespace Vista
{
    public partial class Tareas : Form
    {
        private Boolean _tareasDeEmpleado;
        private Boolean _tareasDeTrabajo;
        private int _idEmpleado;
        private int _idTrabajo;
        private readonly EmpleadoController _controllerEmpleado;
        private readonly TrabajoController _controllerTrabajo;
        private readonly TareaController _controllerTarea;
        public Tareas()
        {
            _idEmpleado = 0;
            _tareasDeEmpleado = false;
            _controllerTarea = new TareaController();
            InitializeComponent();
            dgvTareas.CellContentClick += dgvTareas_CellContentClick;
        }
        public Tareas(int idEmpleado)
        {
            _idEmpleado = idEmpleado;
            _tareasDeEmpleado = true;
            _controllerTarea = new TareaController();
            _controllerEmpleado = new EmpleadoController();
            InitializeComponent();
            dgvTareas.CellContentClick += dgvTareas_CellContentClick;
        }

        public Tareas(int idTrabajo, string parametroInservible)
        {
            _idTrabajo = idTrabajo;
            _tareasDeTrabajo = true;
            _controllerTarea = new TareaController();
            _controllerTrabajo = new TrabajoController();
            InitializeComponent();
            dgvTareas.CellContentClick += dgvTareas_CellContentClick;
        }

        private void Tareas_Load(object sender, EventArgs e)
        {
            dgvTareas.Columns.Clear();
            if (_tareasDeEmpleado || SesionActual.EsTecnico) //se trata de las tareas de un empleado en particular
            {
                lblTareas.Text = "Tareas que realiza el Empleado " + _controllerEmpleado.GetOne(_idEmpleado).Nombre;
                dgvTareas.DataSource = _controllerTarea.GetTareasDelEmpleado(_idEmpleado);
                Utils.DataGridViewHelper.AgregarBotonEliminar(dgvTareas);
            }
            if (_tareasDeTrabajo) //se trata de las tareas de un trabajo en particular
            {
                lblTareas.Text = "Tareas pertenecientes al trabajo" + _controllerTrabajo.GetOne(_idTrabajo).NombreDispositivo;
                dgvTareas.DataSource = _controllerTarea.GetTareasDelTrabajo(_idTrabajo);
                Utils.DataGridViewHelper.AgregarBotonEliminar(dgvTareas);
            }
            if (_tareasDeEmpleado != true && _tareasDeTrabajo != true)
            {
                lblTareas.Text = "Listado de Tareas";
                dgvTareas.DataSource = _controllerTarea.GetAll();
                Utils.DataGridViewHelper.AgregarBotonEditarEliminar(dgvTareas);
            }
            dgvTareas.AllowUserToAddRows = false; //impide que se cree una ultima fila vacia en el dgv


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_tareasDeEmpleado) //se trata de agregar tareas para un empleado particular
            {
                AgregarTareaForm agregarTareaform = new AgregarTareaForm(_idEmpleado);
                if (agregarTareaform.ShowDialog() == DialogResult.OK) Tareas_Load(null, null); // solo recarga si se guardó algo
            }
            else if (_tareasDeTrabajo)
            {
                AgregarTareaForm agregarTareaform = new AgregarTareaForm(_idTrabajo, "parametroSinUso");
                if (agregarTareaform.ShowDialog() == DialogResult.OK) Tareas_Load(null, null); // solo recarga si se guardó algo
            }
            else //acá agrega una tarea a la base de datos
            {
                TareaForm tareaForm = new TareaForm();
                if (tareaForm.ShowDialog() == DialogResult.OK) Tareas_Load(null, null); // solo recarga si se guardó algo
            }
        }
        private void dgvTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora los clics en encabezados
            if (e.RowIndex < 0) return;

            // Obtené el ID del registro desde la fila clickeada
            int idTarea = Convert.ToInt32(dgvTareas.Rows[e.RowIndex].Cells["TareaID"].Value);

            if (dgvTareas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                // Abre el formulario con los datos de ese registro
                TareaForm tareaForm = new TareaForm(idTarea);
                if (tareaForm.ShowDialog() == DialogResult.OK) Tareas_Load(null, null); // solo recarga si se guardó algo

            }
            else if (dgvTareas.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                var confirm = MessageBox.Show("¿Estás seguro de eliminar esta Tarea?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes && _tareasDeEmpleado)
                {
                    _controllerEmpleado.RemoverTarea(_idEmpleado, idTarea);
                    Tareas_Load(null, null); // recarga la grilla
                }
                else if (confirm == DialogResult.Yes && _tareasDeTrabajo)
                {
                    _controllerTrabajo.RemoverTarea(_idTrabajo, idTarea);
                    Tareas_Load(null, null); // recarga la grilla
                }
                else if (confirm == DialogResult.Yes)
                {
                    _controllerTarea.Eliminar(idTarea);
                    Tareas_Load(null, null); // recarga la grilla
                }
            }
        }

        private void Tareas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (_tareasDeEmpleado)
            {
                dgvTareas.Columns.Clear();
                if (!string.IsNullOrWhiteSpace(txtBusqueda.Text))
                {
                    dgvTareas.DataSource = _controllerTarea.GetTareasPorNombreParaXEmpleado(_idEmpleado, txtBusqueda.Text);
                    Utils.DataGridViewHelper.AgregarBotonEliminar(dgvTareas);
                }
                else
                {
                    Tareas_Load(null, null);
                }
            }
            
        }
    }
}
