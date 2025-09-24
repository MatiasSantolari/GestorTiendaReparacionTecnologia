using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class TareaController
    {
        private readonly TareaRepository _repoTarea;
        private readonly EmpleadoRepository _repoEmpleado;
        private readonly TrabajoRepository _repoTrabajo;

        public TareaController()
        {
            _repoTarea = new TareaRepository();
            _repoEmpleado = new EmpleadoRepository();
            _repoTrabajo = new TrabajoRepository();
        }
        public DataTable GetAll()
        {
            DataTable dtTareas = new DataTable();
            dtTareas.Columns.Add("TareaID", typeof(int));
            dtTareas.Columns.Add("Nombre", typeof(string));
            dtTareas.Columns.Add("Detalle", typeof(string));
            dtTareas.Columns.Add("Precio", typeof(string));

            List<TareaModel> tareas = _repoTarea.GetAll();
            foreach (TareaModel t in tareas)
            {
                var precio = t.PreciosTarea.FirstOrDefault()?.Monto.ToString("C"); // "C" es para formato moneda
                dtTareas.Rows.Add(t.TareaID, t.Nombre, t.Detalle, precio ?? "Sin precio");
            }
            return dtTareas;
        }
        public TareaModel GetOne(int id)
        {
            return _repoTarea.GetOne(id);
        }
        public List<TareaModel> GetTareasNoAsignadasEmpleado(int empleadoId)
        {
            return _repoTarea.GetTareasNoAsignadasAEmpleado(empleadoId);
        }
        public List<TareaModel> GetTareasNoAsignadasTrabajo(int empleadoId)
        {
            return _repoTarea.GetTareasNoAsignadasATrabajo(empleadoId);
        }
        public void Registrar(string nombre, string detalle, float montoInicial)
        {
            TareaModel tarea = new TareaModel();
            tarea.Nombre = nombre;
            tarea.Detalle = detalle;
            tarea.PreciosTarea = new List<PrecioTareaModel>
            {
                new PrecioTareaModel
                {
                    Monto = montoInicial,
                    FechaVigencia = DateTime.Today,
                }
            };

            _repoTarea.Insert(tarea);
        }
        public void Modificar(int id, string nombre, string detalle, float monto)
        {
            var p = new PrecioTareaModel
            {
                Monto = monto,
                FechaVigencia = DateTime.Today,
            };
            _repoTarea.Update(id, nombre, detalle, p);
        }
        public void Eliminar(int id)
        {
            _repoTarea.Delete(id);
        }
        public DataTable GetTareasDelEmpleado(int idEmpleado)
        {
            EmpleadoModel empleado = _repoEmpleado.GetOne(idEmpleado);
            DataTable dtTareas = new DataTable();
            dtTareas.Columns.Add("TareaID", typeof(int));
            dtTareas.Columns.Add("Nombre", typeof(string));
            dtTareas.Columns.Add("Detalle", typeof(string));
            dtTareas.Columns.Add("Precio", typeof(string));

            List<TareaModel> tareas = _repoTarea.GetTareasDelEmpleado(empleado);
            foreach (TareaModel t in tareas)
            {
                var precio = t.PreciosTarea.FirstOrDefault()?.Monto.ToString("C"); // "C" es para formato moneda
                dtTareas.Rows.Add(t.TareaID, t.Nombre, t.Detalle, precio ?? "Sin precio");
            }
            return dtTareas;
        }
        public List<TareaModel> GetTareasDelEmpleadoList(int idEmpleado)
        {
            EmpleadoModel empleado = _repoEmpleado.GetOne(idEmpleado);
            return _repoTarea.GetTareasDelEmpleado(empleado);

        }
        public DataTable GetTareasDelTrabajo(int idTrabajo)
        {
            TrabajoModel trabajo = _repoTrabajo.GetOne(idTrabajo);
            DataTable dtTareas = new DataTable();
            dtTareas.Columns.Add("TareaID", typeof(int));
            dtTareas.Columns.Add("Nombre", typeof(string));
            dtTareas.Columns.Add("Detalle", typeof(string));
            dtTareas.Columns.Add("Precio", typeof(string));

            List<TareaModel> tareas = _repoTarea.GetTareasDelTrabajo(trabajo);
            foreach (TareaModel t in tareas)
            {
                var precio = t.PreciosTarea.FirstOrDefault()?.Monto.ToString("C"); // "C" es para formato moneda
                dtTareas.Rows.Add(t.TareaID, t.Nombre, t.Detalle, precio ?? "Sin precio");
            }
            return dtTareas;
        }

        public List<TareaModel> GetTareasDelTrabajoList(int idTrabajo)
        {
            TrabajoModel trabajo = _repoTrabajo.GetOne(idTrabajo);
            List<TareaModel> tareas = _repoTarea.GetTareasDelTrabajo(trabajo);
            return tareas;
        }

        public HashSet<int> GetTareasDeEmpleadosDelTrabajo(int idTrabajo)
        {
            var trabajo = _repoTrabajo.GetOne(idTrabajo);
            var empleados = _repoEmpleado.GetEmpleadosDelTrabajo(trabajo);

            var tareasQueSabenHacer = new HashSet<int>(); // HashSet para evitar duplicados

            foreach (var empleado in empleados)
            {
                var tareasEmpleado = _repoTarea.GetTareasDelEmpleado(empleado);
                foreach (var tarea in tareasEmpleado)
                {
                    tareasQueSabenHacer.Add(tarea.TareaID);
                }
            }
            return tareasQueSabenHacer;
        }

        public DataTable GetTareasPorNombreParaXEmpleado(int idEmpleado, string nombreTarea)
        {
            EmpleadoModel empleado = _repoEmpleado.GetOne(idEmpleado);

            DataTable dtTareas = new DataTable();
            dtTareas.Columns.Add("TareaID", typeof(int));
            dtTareas.Columns.Add("Nombre", typeof(string));
            dtTareas.Columns.Add("Detalle", typeof(string));
            dtTareas.Columns.Add("Precio", typeof(string));

            List<TareaModel> tareas = _repoTarea.GetTareasPorNombreParaXEmpleado(empleado, nombreTarea);
            foreach (TareaModel t in tareas)
            {
                var precio = t.PreciosTarea.FirstOrDefault()?.Monto.ToString("C"); // "C" es para formato moneda
                dtTareas.Rows.Add(t.TareaID, t.Nombre, t.Detalle, precio ?? "Sin precio");
            }
            return dtTareas;
        }
    }
}
