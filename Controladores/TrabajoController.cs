using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Modelos.ModelosEspeciales;

namespace Controladores
{
    public class TrabajoController
    {
        private readonly TrabajoRepository _repoTrabajo;
        private readonly EmpleadoRepository _repoEmpleado;

        public TrabajoController()
        {
            _repoTrabajo = new TrabajoRepository();
            _repoEmpleado = new EmpleadoRepository();
        }
        public DataTable GetAll()
        {
            DataTable dtTrabajos = new DataTable();
            dtTrabajos.Columns.Add("Dispositivo", typeof(string));
            dtTrabajos.Columns.Add("Problema", typeof(string));
            dtTrabajos.Columns.Add("Cliente", typeof(string));

            List<TrabajoModel> trabajos = _repoTrabajo.GetAll();
            foreach (TrabajoModel t in trabajos)
            {
                var cliente = t.Cliente.Nombre;
                dtTrabajos.Rows.Add(t.NombreDispositivo, t.DescripcionProblema, cliente);
            }
            return dtTrabajos;
        }
        public TrabajoModel GetOne(int idTrabajo)
        {
            return _repoTrabajo.GetOne(idTrabajo);
        }
        public DataTable GetTrabajosCliente(int idCliente)
        {
            DataTable dtTrabajos = new DataTable();
            dtTrabajos.Columns.Add("TrabajoID", typeof(int));
            dtTrabajos.Columns.Add("Dispositivo", typeof(string));
            dtTrabajos.Columns.Add("Problema", typeof(string));
            dtTrabajos.Columns.Add("Cliente", typeof(string));

            List<TrabajoModel> trabajos = _repoTrabajo.GetTrabajosCliente(idCliente);
            foreach (TrabajoModel t in trabajos)
            {
                var cliente = t.Cliente.Nombre;
                dtTrabajos.Rows.Add(t.TrabajoID, t.NombreDispositivo, t.DescripcionProblema, cliente);
            }
            return dtTrabajos;
        }
        public DataTable GetTrabajosPendientes()
        {
            DataTable dtTrabajos = new DataTable();
            dtTrabajos.Columns.Add("TrabajoID", typeof(int));
            dtTrabajos.Columns.Add("Dispositivo", typeof(string));
            dtTrabajos.Columns.Add("Problema", typeof(string));
            dtTrabajos.Columns.Add("Cliente", typeof(string));

            List<TrabajoModel> trabajos = _repoTrabajo.GetTrabajosPendientes();
            foreach (TrabajoModel t in trabajos)
            {
                var cliente = t.Cliente.Nombre;
                dtTrabajos.Rows.Add(t.TrabajoID, t.NombreDispositivo, t.DescripcionProblema, cliente);
            }
            return dtTrabajos;
        }
        public DataTable GetTrabajosPendientesDeEmpleado(int empleadoID)
        {
            DataTable dtTrabajos = new DataTable();
            dtTrabajos.Columns.Add("TrabajoID", typeof(int));
            dtTrabajos.Columns.Add("Dispositivo", typeof(string));
            dtTrabajos.Columns.Add("Problema", typeof(string));
            dtTrabajos.Columns.Add("Cliente", typeof(string));

            List<TrabajoModel> trabajos = _repoTrabajo.GetTrabajosPendientesDeEmpleado(empleadoID);
            foreach (TrabajoModel t in trabajos)
            {
                var cliente = t.Cliente.Nombre;
                dtTrabajos.Rows.Add(t.TrabajoID, t.NombreDispositivo, t.DescripcionProblema, cliente);
            }
            return dtTrabajos;
        }
        public int GetIdCliente(int idTrabajo)
        {
            return _repoTrabajo.GetIdCliente(idTrabajo);
        }

        public void AgregarEmpleadoAlTrabajo(int idEmpleado, int idTrabajo)
        {
            var empleado = _repoEmpleado.GetOne(idEmpleado);
            var trabajo = _repoTrabajo.GetOne(idTrabajo);

            if (empleado != null && trabajo != null)
            {
                _repoTrabajo.AgregarEmpleadoAlTrabajo(empleado, trabajo);
            }
            else throw new Exception("El empleado o el trabajo no fueron encontrados");
        }

        public void Registrar(string dispositivo, string problema, string estado, int idCliente)
        {
            TrabajoModel trabajo = new TrabajoModel
            {
                NombreDispositivo = dispositivo,
                DescripcionProblema = problema,
                Estado = estado,
                ClienteID = idCliente,
                FechaSolicitud = DateTime.Now,
            };
            _repoTrabajo.Insert(trabajo);
        }
        public void Modificar(int id, string dispositivo, string problema, string estado)
        {
            _repoTrabajo.Update(id, dispositivo, problema, estado);
        }
        public void Eliminar(int id)
        {
            _repoTrabajo.Delete(id);
        }
        public void AgregarTarea(int trabajoID, int tareaIDSeleccionada)
        {
            _repoTrabajo.InsertTarea(trabajoID, tareaIDSeleccionada);
        }
        public void RemoverTarea(int trabajoID, int tareaIDSeleccionada)
        {
            _repoTrabajo.DeleteTarea(trabajoID, tareaIDSeleccionada);
        }
        public void AgregarEmpleado(int trabajoID, int empleadoIDSeleccionado)
        {
            _repoTrabajo.InsertEmpleado(trabajoID, empleadoIDSeleccionado);
        }
        public void RemoverEmpleado(int trabajoID, int empleadoIDSeleccionado)
        {
            _repoTrabajo.DeleteEmpleado(trabajoID, empleadoIDSeleccionado);
        }

        public List<TrabajoPorMesModel> GetTrabajosPorAno(int ano)
        {
            return _repoTrabajo.GetTrabajosPorAno(ano);
        }

    }
}
