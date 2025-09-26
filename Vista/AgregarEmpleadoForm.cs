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

namespace Vista
{
    public partial class AgregarEmpleadoForm : Form
    {
        private readonly int _idTrabajo;
        private readonly TrabajoController _controllerTrabajo;
        private readonly TareaController _controllerTarea;
        private readonly EmpleadoController _controllerEmpleado;
        public AgregarEmpleadoForm(int idTrabajo)
        {
            InitializeComponent();
            _idTrabajo = idTrabajo;
            _controllerTrabajo = new TrabajoController();
            _controllerTarea = new TareaController();
            _controllerEmpleado = new EmpleadoController();
        }

        private void AgregarEmpleadoForm_Load(object sender, EventArgs e)
        {
            ActualizarGroupBoxTareasTrabajo(_idTrabajo);
            ActualizarGroupBoxEmpleadosTrabajo(_idTrabajo);
            ConfigurarComboBoxEmpleados();
        }
        private void ActualizarGroupBoxTareasTrabajo(int idTrabajo)
        {
            var tareas = _controllerTarea.GetTareasDelTrabajoList(idTrabajo);

            var tareasQueSabenHacer = _controllerTarea.GetTareasDeEmpleadosDelTrabajo(idTrabajo);

            gbTareasTrabajo.Controls.Clear(); // Limpio cualquier control viejo
            int y = 20;

            foreach (var tarea in tareas)
            {
                var radio = new RadioButton();
                radio.Text = tarea.Nombre;
                radio.Tag = tarea.TareaID;
                radio.Enabled = true;
                radio.AutoCheck = false;
                radio.Location = new Point(10, y);
                radio.AutoSize = true;
                radio.Checked = tareasQueSabenHacer.Contains(tarea.TareaID); // se marca si hay coincidencia
                radio.ForeColor = tareasQueSabenHacer.Contains(tarea.TareaID) ? Color.Green : Color.Black;

                gbTareasTrabajo.Controls.Add(radio);
                y += 20;
            }
        }
        private void ActualizarGroupBoxEmpleadosTrabajo(int idTrabajo)
        {
            var empleados = _controllerEmpleado.GetEmpleadosDelTrabajoList(idTrabajo);

            gbEmpleadosTrabajo.Controls.Clear(); // Limpio cualquier control viejo
            int y = 20;

            foreach (var empleado in empleados)
            {
                var label = new Label();
                label.Text = empleado.Nombre;
                label.Location = new Point(10, y);
                label.AutoSize = true;

                var button = new Button();
                int buttonWidth = 20;
                button.Size = new Size(buttonWidth, buttonWidth);
                Image imgRedimensionada = new Bitmap(Properties.Resources.eliminar, new Size(16, 16));
                button.Image = imgRedimensionada;
                button.ImageAlign = ContentAlignment.MiddleCenter;
                button.Location = new Point(gbEmpleadosTrabajo.Width - buttonWidth - 10, y-2); //a la derecha con 10px de margen
                button.Tag = empleado.EmpleadoID;
                button.Click += ButtonEliminarEmpleado_Click;

                gbEmpleadosTrabajo.Controls.Add(label);
                gbEmpleadosTrabajo.Controls.Add(button);
                y += 20;
            }
        }
        private void ConfigurarComboBoxEmpleados()
        {
            var empleadosDisponibles = _controllerEmpleado.GetEmpleadosNoAsignadosTrabajo(_idTrabajo);
            cbEmpleados.DataSource = empleadosDisponibles;
            cbEmpleados.DisplayMember = "Nombre";
            cbEmpleados.ValueMember = "EmpleadoID";
        }

        private void btnVerTareasEmpleado_Click(object sender, EventArgs e)
        {
            var empleado = (EmpleadoModel)cbEmpleados.SelectedItem;
            if (empleado != null)
            {
                var tareasEmpleado = _controllerTarea.GetTareasDelEmpleado(empleado.EmpleadoID);
                dgvTareasDeEmpleados.DataSource = tareasEmpleado;
                dgvTareasDeEmpleados.Enabled = false;
                dgvTareasDeEmpleados.AllowUserToAddRows = false; //impide que se cree una ultima fila vacia en el dgv
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var empleadoSeleccionado = (EmpleadoModel)cbEmpleados.SelectedItem;
            if (empleadoSeleccionado != null)
            {
                _controllerTrabajo.AgregarEmpleado(_idTrabajo, empleadoSeleccionado.EmpleadoID);
                
                DialogResult result = MessageBox.Show(
                    "¿Desea agregar mas empleados?", 
                    "Empleado agregado exitosamente al trabajo", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Exclamation);

                if (result == DialogResult.No)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else ActualizarGroupBoxTareasTrabajo(_idTrabajo);
            }
        }
        private void ButtonEliminarEmpleado_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            int empleadoId = (int)button.Tag;

            var confirm = MessageBox.Show("¿Eliminar este empleado del trabajo?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _controllerTrabajo.RemoverEmpleado(_idTrabajo, empleadoId);
                ActualizarGroupBoxEmpleadosTrabajo(_idTrabajo); // Recarga
            }
        }
    }
}
