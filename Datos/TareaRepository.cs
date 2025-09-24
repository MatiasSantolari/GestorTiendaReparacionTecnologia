using Microsoft.EntityFrameworkCore;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Datos
{
    public class TareaRepository
    {
        public readonly TiendaReparacionContext _context;
        public TareaRepository()
        {
            _context = TiendaReparacionContextFactory.CrearContexto(); //toma la cadena desde Vista
        }
        public List<TareaModel> GetAll()
        {
            var hoy = DateTime.Today;
            var tareas = _context.Tareas
                                 .Include(t => t.PreciosTarea)
                                 .ToList();
            foreach (var tarea in tareas)
            {
                tarea.PreciosTarea = tarea.PreciosTarea
                    .Where(p => p.FechaVigencia <= hoy)
                    .OrderByDescending(p => p.FechaVigencia)
                    .Take(1)
                    .ToList();
            }
            return tareas;
        }
        public TareaModel GetOne(int id)
        {
            var hoy = DateTime.Today;
            var tarea = _context.Tareas.Include(t => t.PreciosTarea).FirstOrDefault(e => e.TareaID == id);
            tarea.PreciosTarea = tarea.PreciosTarea
                                      .Where(p => p.FechaVigencia <= hoy)
                                      .OrderByDescending(p => p.FechaVigencia)
                                      .Take(1)
                                      .ToList();
            return tarea;
        }
        public List<TareaModel> GetTareasNoAsignadasAEmpleado(int empleadoId)
        {
            var tareasAsignadasIds = _context.Empleados
                .Include(e => e.Tareas)
                .FirstOrDefault(e => e.EmpleadoID == empleadoId)?
                .Tareas
                .Select(t => t.TareaID)
                .ToList() ?? new List<int>();

            return _context.Tareas
                .Where(t => !tareasAsignadasIds.Contains(t.TareaID))
                .ToList();
        }
        public List<TareaModel> GetTareasNoAsignadasATrabajo(int trabajoId)
        {
            var tareasAsignadasIds = _context.Trabajos
                .Include(t => t.Tareas)
                .FirstOrDefault(t => t.TrabajoID == trabajoId)?
                .Tareas
                .Select(t => t.TareaID)
                .ToList() ?? new List<int>();

            return _context.Tareas
                .Where(t => !tareasAsignadasIds.Contains(t.TareaID))
                .ToList();
        }
        public void Insert(TareaModel t)
        {
            _context.Tareas.Add(t);
            _context.SaveChanges();
        }
        public void Update(int id, string nombre, string detalle, PrecioTareaModel precio)
        {
            var t = _context.Tareas.FirstOrDefault(t => t.TareaID == id);
            if (t != null)
            {
                t.Nombre = nombre;
                t.Detalle = detalle;
                t.PreciosTarea.Add(precio);

                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Error al actualizar la tarea");
            }
        }
        public void Delete(int id)
        {
            var t = _context.Tareas.FirstOrDefault(t => t.TareaID == id);
            if (t != null)
            {
                _context.Tareas.Remove(t);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Error al eliminar la tarea");
            }
        }
        public List<TareaModel> GetTareasDelTrabajo(TrabajoModel tr)
        {
            var hoy = DateTime.Today;
            var tareas = _context.Tareas
                                 .Where(t => t.Trabajos.Contains(tr))
                                 .Include(t => t.PreciosTarea)
                                 .Include(t => t.Trabajos)
                                 .ToList();
            foreach (var tarea in tareas)
            {
                tarea.PreciosTarea = tarea.PreciosTarea
                    .Where(p => p.FechaVigencia <= hoy)
                    .OrderByDescending(p => p.FechaVigencia)
                    .Take(1)
                    .ToList();
            }
            return tareas;
        }
        public List<TareaModel> GetTareasDelEmpleado(EmpleadoModel emp)
        {
            var hoy = DateTime.Today;
            var tareas = _context.Tareas
                                 .Where(t => t.Empleados.Contains(emp))
                                 .Include(t => t.PreciosTarea)
                                 .Include(t => t.Empleados)
                                 .ToList();
            foreach (var tarea in tareas)
            {
                tarea.PreciosTarea = tarea.PreciosTarea
                    .Where(p => p.FechaVigencia <= hoy)
                    .OrderByDescending(p => p.FechaVigencia)
                    .Take(1)
                    .ToList();
            }
            return tareas;
        }

        public List<TareaModel> GetTareasPorNombreParaXEmpleado(EmpleadoModel emp, string  nombreTarea)
        {
            var hoy = DateTime.Today;
            var tareas = _context.Tareas
                                 .Where(t => t.Empleados.Contains(emp) && t.Nombre.ToLower().Contains(nombreTarea.ToLower()))
                                 .Include(t => t.PreciosTarea)
                                 .Include(t => t.Empleados)
                                 .ToList();
            foreach (var tarea in tareas)
            {
                tarea.PreciosTarea = tarea.PreciosTarea
                    .Where(p => p.FechaVigencia <= hoy)
                    .OrderByDescending(p => p.FechaVigencia)
                    .Take(1)
                    .ToList();
            }
            return tareas;
        }
    }
}
