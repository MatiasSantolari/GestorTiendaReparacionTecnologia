using Controladores;
using Seguridad;
using System;
using System.Data;
using System.Windows.Forms;
using Utils;
using Vista;

namespace GestorTiendaReparacionPC
{
    public partial class Home : Form
    {
        private TrabajoController _controller;

        public Home()
        {
            InitializeComponent();
            this.Load += Home_Load; // Aseguramos que se suscriba

            dgvTrabajosPendientes.CellContentClick += dgvTrabajosPendientes_CellContentClick;
        }

        private void Home_Shown(object sender, EventArgs e)
        {
            Login appLogin = new Login();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                Dispose();
            }
            AplicarPermisos();
            LlenarDataSource();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
            LlenarDataSource();
        }

        private void mnuEmpleados_Click(object sender, EventArgs e)
        {
            Empleados empleadosForm = new Empleados();
            if (empleadosForm.ShowDialog() == DialogResult.OK) Home_Load(null, null); // solo recarga si se guardó algo
        }

        private void mnuTareas_Click(object sender, EventArgs e)
        {
            Tareas tareasForm;
            if (SesionActual.EsTecnico) tareasForm = new Tareas(SesionActual.Empleado.EmpleadoID);
            else tareasForm = new Tareas();
            
            if (tareasForm.ShowDialog() == DialogResult.OK) Home_Load(null, null); // solo recarga si se guardó algo
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            Clientes clientesForm = new Clientes();
            if (clientesForm.ShowDialog() == DialogResult.OK) Home_Load(null, null); // solo recarga si se guardó algo
        }

        private void dgvTrabajosPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idTrabajo = Convert.ToInt32(dgvTrabajosPendientes.Rows[e.RowIndex].Cells["TrabajoID"].Value);

            if (dgvTrabajosPendientes.Columns[e.ColumnIndex].Name == "btnVerEmpleados")
            {
                // Abre el formulario con los datos de ese registro
                Empleados empleadoForm = new Empleados(idTrabajo);
                if (empleadoForm.ShowDialog() == DialogResult.OK) Home_Load(null, null); // recarga la grilla
            }
            if (dgvTrabajosPendientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                //hacer un metodo que busque el idcliente a partir del trabajo
                var idCliente = _controller.GetIdCliente(idTrabajo);
                TrabajoForm trabajoForm = new TrabajoForm(idCliente, idTrabajo);
                if (trabajoForm.ShowDialog() == DialogResult.OK) Home_Load(null, null); // recarga la grilla
            }
            if (dgvTrabajosPendientes.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                var confirm = MessageBox.Show("¿Estás seguro de eliminar esta Tarea?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _controller.Eliminar(idTrabajo);
                    Home_Load(null, null);
                }
            }
        }

        private void mnuInformeTrabajos_Click(object sender, EventArgs e)
        {
            InformeDemandaDeTrabajos InformeDemandaTrabajoform = new InformeDemandaDeTrabajos();
            if (InformeDemandaTrabajoform.ShowDialog() == DialogResult.OK) Home_Load(null, null); // solo recarga si se guardó algo
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            LlenarDataSource();
        }

        private void mnuCerrarSesion_Click(object sender, EventArgs e)
        {
            SesionActual.CerrarSesion();
            Application.Restart(); // reinicia app y vuelve al login
        }

        private void mnuMisDatos_Click(object sender, EventArgs e)
        {
            int usuarioID = SesionActual.Empleado.EmpleadoID;
            EmpleadoForm empleadoForm = new EmpleadoForm(usuarioID);
            if (empleadoForm.ShowDialog() == DialogResult.OK) Home_Load(null, null); // recarga la grilla
        }


        private void AplicarPermisos()
        {
            if (!SesionActual.EsAdmin) // Ingresó un técnico
            {
                mnuClientes.Visible = false;
                mnuEmpleados.Visible = false;
                mnuInformeTrabajos.Visible = false;
                lblTrabajosPendientes.Text = "Mis Trabajos Pendientes";
            }
            else // Ingresó un admin
            {
                mnuClientes.Visible = true;
                mnuEmpleados.Visible = true;
                mnuInformeTrabajos.Visible = true;
                lblTrabajosPendientes.Text = "Todos Los Trabajos Pendientes";
            }
        }

        private void LlenarDataSource()
        {
            //Inicializamos el controller después de que Main() hizo SetConnectionString()
            _controller = new TrabajoController();
            dgvTrabajosPendientes.Columns.Clear();

            if (SesionActual.EsTecnico) // Ingresó un técnico
            {
                dgvTrabajosPendientes.DataSource = _controller.GetTrabajosPendientesDeEmpleado(SesionActual.Empleado.EmpleadoID);
                dgvTrabajosPendientes.AllowUserToAddRows = false;

                Utils.DataGridViewHelper.AgregarBotonVerEmpleados(dgvTrabajosPendientes);
                Utils.DataGridViewHelper.AgregarBotonEditar(dgvTrabajosPendientes);
            }
            else // Ingresó un admin
            {
                dgvTrabajosPendientes.DataSource = _controller.GetTrabajosPendientes();
                dgvTrabajosPendientes.AllowUserToAddRows = false;

                Utils.DataGridViewHelper.AgregarBotonVerEmpleados(dgvTrabajosPendientes);
                Utils.DataGridViewHelper.AgregarBotonEditarEliminar(dgvTrabajosPendientes);
            }
        }
    }
}

