using Microsoft.EntityFrameworkCore;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PrecioTareaRepository
    {
        public readonly TiendaReparacionContext _context;
        public PrecioTareaRepository()
        {
            _context = TiendaReparacionContextFactory.CrearContexto(); //toma la cadena desde Vista
        }
        public List<PrecioTareaModel> GetAll()
        {
            var preciosTarea = _context.PreciosTarea
                                       .Include(pt => pt.Tarea)
                                       .ToList();
            return preciosTarea;
        }
        public void Insert(PrecioTareaModel pt)
        {
            _context.PreciosTarea.Add(pt);
            _context.SaveChanges();
        }
        public void Update(int id, DateTime fechaNueva, float monto, TareaModel tarea)
        {
            var pt = _context.PreciosTarea.FirstOrDefault(p => p.PrecioTareaID == id);
            if (pt != null)
            {
                pt.FechaVigencia = fechaNueva;
                pt.Monto = monto;
                pt.Tarea = tarea;

                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Error al actualizar el precio de la tarea");
            }
        }
        public void Delete(int id)
        {
            var pt = _context.PreciosTarea.FirstOrDefault(p => p.PrecioTareaID == id);
            if (pt != null)
            {
                _context.PreciosTarea.Remove(pt);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Error al eliminar el precio de la tarea");
            }
        }
    }
}
