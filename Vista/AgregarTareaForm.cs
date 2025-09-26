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
    public partial class AgregarTareaForm : Form
    {
        private TareaController _controllerTarea;
        private EmpleadoController _controllerEmpleado;
        private TrabajoController _controllerTrabajo;
        private int _empleadoID = 0;
        private int _trabajoID = 0;
        public AgregarTareaForm(int empleadoID)
        {
            _controllerTarea = new TareaController();
            _controllerEmpleado = new EmpleadoController();
            _empleadoID = empleadoID;
            InitializeComponent();
        }
        public AgregarTareaForm(int trabajoID, string parametroSinUso)
        {
            _controllerTarea = new TareaController();
            _controllerTrabajo = new TrabajoController();
            _trabajoID = trabajoID;
            InitializeComponent();
        }

        private void AgregarTareaForm_Load(object sender, EventArgs e)
        {
            if (_empleadoID != 0)
            {
                var tareasDisponibles = _controllerTarea.GetTareasNoAsignadasEmpleado(_empleadoID);
                cbTareas.DataSource = tareasDisponibles;
            }
            if (_trabajoID != 0)
            {
                var tareasDisponibles = _controllerTarea.GetTareasNoAsignadasTrabajo(_trabajoID);
                cbTareas.DataSource = tareasDisponibles;
            }
            cbTareas.DisplayMember = "Nombre";
            cbTareas.ValueMember = "TareaID";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbTareas.SelectedValue == null) return;
            if (_empleadoID != 0)
            {
                _controllerEmpleado.AgregarTarea(_empleadoID, Convert.ToInt32(cbTareas.SelectedValue));
            }
            if (_trabajoID != 0)
            {
                _controllerTrabajo.AgregarTarea(_trabajoID, Convert.ToInt32(cbTareas.SelectedValue));
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
