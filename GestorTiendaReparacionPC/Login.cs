using Controladores;
using Seguridad;
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
    public partial class Login : Form
    {
        private EmpleadoController _controller = new EmpleadoController();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var empleado = _controller.GetEmpleadoByNombreAndPassword(txtUsuario.Text, txtPassword.Text);
            if (empleado != null)
            {
                SesionActual.IniciarSesion(empleado);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            EmpleadoForm empleadoForm = new EmpleadoForm();
            empleadoForm.ShowDialog();
        }
    }
}
