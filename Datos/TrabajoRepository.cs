using Microsoft.EntityFrameworkCore;
using Modelos;
using Modelos.ModelosEspeciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Datos
{
    public class TrabajoRepository
    {
        public readonly TiendaReparacionContext _context;
        public TrabajoRepository()
        {
            _context = TiendaReparacionContextFactory.CrearContexto(); //toma la cadena desde Vista
        }
        public List<TrabajoModel> GetAll()
        {
            var trabajos = _context.Trabajos
                                   .Include(t => t.Cliente)
                                   .Include(t => t.Tareas)
                                   .Include(t => t.Empleados)
                                   .AsNoTracking() //evita que la funcion devuelva datos viejos por algun caché o tracking de ef core
                                   .ToList();
            return trabajos;
        }
        public TrabajoModel GetOne(int idTrabajo)
        {
            return _context.Trabajos
                           .Include(t => t.Cliente)
                           .Include(t => t.Tareas)
                           .Include(t => t.Empleados)
                           .FirstOrDefault(t => t.TrabajoID == idTrabajo);
        }
        public void Insert(TrabajoModel t)
        {
            _context.Trabajos.Add(t);
            _context.SaveChanges();
        }
        public void Update(int id, string dispositivo , string descripcion, string estado)
        {
            var t = _context.Trabajos.FirstOrDefault(t => t.TrabajoID == id);
            if (t != null)
            {
                t.NombreDispositivo = dispositivo;
                t.DescripcionProblema = descripcion;
                t.Estado = estado;

                _context.SaveChanges();
            }
            else throw new Exception("Error al actualizar el trabajo");
            
        }
        public void Delete(int id)
        {
            var t = _context.Trabajos.FirstOrDefault(t => t.TrabajoID == id);
            if (t != null)
            {
                _context.Trabajos.Remove(t);
                _context.SaveChanges();
            }
            else throw new Exception("Error al actualizar el trabajo");
        }
        public void AgregarEmpleadoAlTrabajo(EmpleadoModel emp, TrabajoModel tr)
        {
            List<EmpleadoModel> empleados = _context.Empleados
                                   .Where(e => e.Trabajos.Contains(tr))
                                   .ToList();
            
            if (!empleados.Contains(emp)) //los empleados de ese trabajo no contienen a ese empleado
            {
                TrabajoModel t = _context.Trabajos.FirstOrDefault(t => t.TrabajoID == tr.TrabajoID);
                if (t != null)
                {
                    t.Empleados.Add(emp);
                    _context.SaveChanges();
                }
                else throw new Exception("Error al buscar el trabajo");
                
            }
            else throw new Exception("Este empleado ya pertenece al trabajo");
            
        }
        public List<TrabajoModel> GetTrabajosPendientes()
        {
            return _context.Trabajos
                           .Where(t => t.Estado == "Pendiente")
                           .Include(t => t.Cliente)
                           .AsNoTracking() //evita que la funcion devuelva datos viejos por algun caché o tracking de ef core
                           .ToList();
        }
        public List<TrabajoModel> GetTrabajosPendientesDeEmpleado(int empleadoID)
        {
            var empleado = _context.Empleados.FirstOrDefault(e => e.EmpleadoID == empleadoID);
            return _context.Trabajos
                           .Where(t => t.Estado == "Pendiente" && t.Empleados.Contains(empleado))
                           .Include(t => t.Cliente)
                           .Include(t => t.Empleados)
                           .AsNoTracking() //evita que la funcion devuelva datos viejos por algun caché o tracking de ef core
                           .ToList();
        }
        public List<TrabajoModel> GetTrabajosCliente(int idCliente)
        {
            return _context.Trabajos
                           .Where(t => t.ClienteID == idCliente)
                           .Include(t => t.Cliente)
                           .Include(t => t.Empleados)
                           .Include(t => t.Tareas)
                           .AsNoTracking() //evita que la funcion devuelva datos viejos por algun caché o tracking de ef core
                           .ToList();
        }
        public int GetIdCliente(int idTrabajo)
        {
            return _context.Trabajos
                           .Where(t => t.TrabajoID == idTrabajo)
                           .Select(t => t.ClienteID)
                           .FirstOrDefault();
        }

        public void InsertTarea(int trabajoID, int tareaIDSeleccionada)
        {
            var tra = GetOne(trabajoID);
            tra.Tareas.Add(_context.Tareas.FirstOrDefault(t => t.TareaID == tareaIDSeleccionada));
            _context.SaveChanges();
        }
        public void DeleteTarea(int trabajoID, int tareaIDSeleccionada)
        {
            var tra = GetOne(trabajoID);
            tra.Tareas.Remove(_context.Tareas.FirstOrDefault(t => t.TareaID == tareaIDSeleccionada));
            _context.SaveChanges();
        }
        public void InsertEmpleado(int trabajoID, int empleadoIDSeleccionado)
        {
            var tra = GetOne(trabajoID);
            tra.Empleados.Add(_context.Empleados.FirstOrDefault(e => e.EmpleadoID == empleadoIDSeleccionado));
            _context.SaveChanges();
        }
        public void DeleteEmpleado(int trabajoID, int empleadoIDSeleccionado)
        {
            var tra = GetOne(trabajoID);
            tra.Empleados.Remove(_context.Empleados.FirstOrDefault(e => e.EmpleadoID == empleadoIDSeleccionado));
            _context.SaveChanges();
        }
        public List<TrabajoPorMesModel> GetTrabajosPorAno(int ano)
        {
            return _context.Trabajos
                           .Where(t => t.FechaSolicitud.Year == ano)
                           .Include(t => t.Tareas)
                               .ThenInclude(t => t.PreciosTarea)
                           .AsEnumerable() // lo paso a memoria para usar LINQ mas potente y complejo
                           .GroupBy(t => t.FechaSolicitud.Month)
                           .Select(g => new TrabajoPorMesModel
                           {
                               Mes = g.Key,
                               Cantidad = g.Count(),
                               Recaudacion = g.Sum(trabajo =>
                                   trabajo.Tareas.Sum(tarea =>
                                   {
                                       var precioVigente = tarea.PreciosTarea
                                           .Where(p => p.FechaVigencia <= trabajo.FechaSolicitud)
                                           .OrderByDescending(p => p.FechaVigencia)
                                           .FirstOrDefault();

                                       return precioVigente?.Monto ?? 0;
                                   }))
                           })
                           .ToList();

            //Cuando hago un GroupBy, cada grupo es un objeto de tipo IGrouping<TKey, TElement>:
            //TKey → es el tipo de la clave de agrupación(en este caso int, porque se usa Month como clave).
            //TElement → son los elementos que quedaron dentro de ese grupo(en este caso Trabajo).
        }
    }
}
