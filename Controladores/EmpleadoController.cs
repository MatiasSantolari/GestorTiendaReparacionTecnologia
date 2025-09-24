using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seguridad;

namespace Controladores
{
    public class EmpleadoController
    {
        private readonly EmpleadoRepository _repoEmpleado;
        private readonly TrabajoRepository _repoTrabajo;

        public EmpleadoController()
        {
            _repoEmpleado = new EmpleadoRepository();
            _repoTrabajo = new TrabajoRepository();
        }
        public DataTable GetAll()
        {
            DataTable dtEmpleados = new DataTable();
            dtEmpleados.Columns.Add("EmpleadoID", typeof(int));
            dtEmpleados.Columns.Add("Nombre", typeof(string));
            dtEmpleados.Columns.Add("Telefono", typeof(string));
            dtEmpleados.Columns.Add("Email", typeof(string));
            dtEmpleados.Columns.Add("Rol", typeof(string));

            List<EmpleadoModel> empleados = _repoEmpleado.GetAll();
            foreach (EmpleadoModel e in empleados)
            {
                dtEmpleados.Rows.Add(e.EmpleadoID, e.Nombre, e.Telefono, e.Email, e.Rol);
            }
            return dtEmpleados;
        }
        public EmpleadoModel GetOne(int id)
        {
            return _repoEmpleado.GetOne(id);
        }

        public DataTable GetEmpleadosPorNombre(string nombre)
        {
            DataTable dtEmpleados = new DataTable();
            if (nombre != null)
            {
                dtEmpleados.Columns.Add("EmpleadoID", typeof(int));
                dtEmpleados.Columns.Add("Nombre", typeof(string));
                dtEmpleados.Columns.Add("Telefono", typeof(string));
                dtEmpleados.Columns.Add("Email", typeof(string));
                dtEmpleados.Columns.Add("Rol", typeof(string));

                List<EmpleadoModel> empleados = _repoEmpleado.GetEmpleadosPorNombre(nombre);
                foreach (EmpleadoModel e in empleados)
                {
                    dtEmpleados.Rows.Add(e.EmpleadoID, e.Nombre, e.Telefono, e.Email, e.Rol);
                }
                return dtEmpleados;
            }
            else return this.GetAll();
        }
        public DataTable GetEmpleadosDelTrabajo(int trabajoID)
        {
            DataTable dtEmpleados = new DataTable();
            dtEmpleados.Columns.Add("EmpleadoID", typeof(int));
            dtEmpleados.Columns.Add("Nombre", typeof(string));
            dtEmpleados.Columns.Add("Telefono", typeof(string));
            dtEmpleados.Columns.Add("Email", typeof(string));
            dtEmpleados.Columns.Add("Rol", typeof(string));

            var trabajo = _repoTrabajo.GetOne(trabajoID);
            List<EmpleadoModel> empleados = _repoEmpleado.GetEmpleadosDelTrabajo(trabajo);
            foreach (EmpleadoModel e in empleados)
            {
                dtEmpleados.Rows.Add(e.EmpleadoID, e.Nombre, e.Telefono, e.Email, e.Rol);
            }
            return dtEmpleados;
        }
        public bool Registrar(string nombre, string tel, string email, string rol, string password, string repPassword)
        {
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(repPassword))
                return false;
            // Validar que coincidan
            if (!ValidacionesNegocio.ValidarCoincidenciaPasswords(password, repPassword))
                return false;

            // Guardar con hash
            EmpleadoModel empleado = new EmpleadoModel
            {
                Nombre = nombre,
                Telefono = tel,
                Email = email,
                Password = PasswordHelper.HashPassword(password),
                Rol = rol
            };

            _repoEmpleado.Insert(empleado);
            return true;
        }

        public bool Modificar(int id, string nombre, string tel, string email, string rol, string password, string repPassword)
        {
            // Si se ingresó contraseña nueva, validar coincidencia
            string passwordHash = null;
            if (!string.IsNullOrWhiteSpace(password))
            {
                if (!ValidacionesNegocio.ValidarCoincidenciaPasswords(password, repPassword))
                    return false;

                passwordHash = PasswordHelper.HashPassword(password);
            }

            _repoEmpleado.Update(id, nombre, tel, email, passwordHash, rol);
            return true;
        }
        public void Eliminar(int id)
        {
            _repoEmpleado.Delete(id);
        }
        public EmpleadoModel GetEmpleadoByNombreAndPassword(string nombre, string password)
        {
            return _repoEmpleado.GetEmpleadoByNombreAndPassword(nombre, password);
        }

        public void AgregarTarea(int empleadoID, int tareaIDSeleccionada)
        {
            _repoEmpleado.InsertTarea(empleadoID, tareaIDSeleccionada);
        }
        public void RemoverTarea(int empleadoID, int tareaIDSeleccionada)
        {
            _repoEmpleado.DeleteTarea(empleadoID, tareaIDSeleccionada);
        }
        public List<EmpleadoModel> GetEmpleadosNoAsignadosTrabajo(int idTrabajo)
        {
            return _repoEmpleado.GetEmpleadosNoAsignadosTrabajo(idTrabajo);
        }

        public List<EmpleadoModel> GetEmpleadosDelTrabajoList(int idTrabajo)
        {
            TrabajoModel trabajo = _repoTrabajo.GetOne(idTrabajo);
            List<EmpleadoModel> empleado = _repoEmpleado.GetEmpleadosDelTrabajo(trabajo);
            return empleado;
        }
    }
}
