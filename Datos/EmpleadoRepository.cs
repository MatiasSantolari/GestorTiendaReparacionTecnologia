using Microsoft.EntityFrameworkCore;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Seguridad;

namespace Datos
{
    public class EmpleadoRepository
    {
        public readonly TiendaReparacionContext _context;
        public EmpleadoRepository()
        {
            _context = TiendaReparacionContextFactory.CrearContexto(); //toma la cadena desde Vista
        }
        public List<EmpleadoModel> GetAll()
        {
            var empleados = _context.Empleados
                                   .Include(e => e.Tareas)
                                   .AsNoTracking() //evita que la funcion devuelva datos viejos por algun caché o tracking de ef core
                                   .ToList();
            return empleados;
        }
        public EmpleadoModel GetOne(int id)
        {
            return _context.Empleados
                           .Include(e => e.Tareas)
                           .FirstOrDefault(e => e.EmpleadoID == id);
        }
        public EmpleadoModel GetEmpleadoByNombreAndPassword(string nombre, string password)
        {
            string hashedPassword = PasswordHelper.HashPassword(password);
            return _context.Empleados
                           .FirstOrDefault(e => e.Nombre == nombre && e.Password == hashedPassword);
        }
        public List<EmpleadoModel> GetEmpleadosDelTrabajo(TrabajoModel tr)
        {
            return _context.Empleados
                           .Where(t => t.Trabajos.Contains(tr))
                           .ToList();
        }
        public List<EmpleadoModel> GetEmpleadosPorNombre(string nombre)
        {
            return _context.Empleados
                           .Where(e => e.Nombre.ToLower().Contains(nombre.ToLower()))
                           .ToList();
        }
        public void Insert(EmpleadoModel empleado)
        {
            _context.Empleados.Add(empleado);
            _context.SaveChanges();
        }
        public void Update(int id, string nombre, string tel, string email, string password, string rol)
        {
            var empleado = _context.Empleados.FirstOrDefault(e => e.EmpleadoID == id);
            if (empleado != null)
            {
                empleado.Nombre = nombre;
                empleado.Telefono = tel;
                empleado.Email = email;
                empleado.Rol = rol;

                if (!string.IsNullOrEmpty(password))
                {
                    empleado.Password = password; // ya viene hasheada desde el controller
                }

                _context.SaveChanges();
            }
            else throw new Exception("Error al actualizar el empleado");
        }
        public void Delete(int id)
        {
            var empleado = _context.Empleados.FirstOrDefault(e => e.EmpleadoID == id);
            if (empleado != null)
            {
                _context.Empleados.Remove(empleado);
                _context.SaveChanges();
            }
            else throw new Exception("Error al eliminar el empleado");
            
        }
        public void InsertTarea(int empleadoID, int tareaIDSeleccionada)
        {
            var emp = GetOne(empleadoID);
            emp.Tareas.Add(_context.Tareas.FirstOrDefault(t => t.TareaID == tareaIDSeleccionada));
            _context.SaveChanges();
        }
        public void DeleteTarea(int empleadoID, int tareaIDSeleccionada)
        {
            var emp = GetOne(empleadoID);
            emp.Tareas.Remove(_context.Tareas.FirstOrDefault(t => t.TareaID == tareaIDSeleccionada));
            _context.SaveChanges();
        }
        public List<EmpleadoModel> GetEmpleadosNoAsignadosTrabajo(int trabajoId)
        {
            // Obtenemos los IDs de empleados ya asignados al trabajo
            var empleadosAsignadosIds = _context.Trabajos
                .Include(t => t.Empleados)
                .FirstOrDefault(t => t.TrabajoID == trabajoId)?
                .Empleados
                .Select(e => e.EmpleadoID)
                .ToList() ?? new List<int>();

            // Devolvemos los empleados cuyo ID NO está en esa lista
            return _context.Empleados
                .Where(e => !empleadosAsignadosIds.Contains(e.EmpleadoID))
                .ToList();
        }
    }
}
