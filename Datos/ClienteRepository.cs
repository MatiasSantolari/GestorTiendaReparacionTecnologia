using Microsoft.EntityFrameworkCore;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteRepository
    {
        public readonly TiendaReparacionContext _context;
        public ClienteRepository()
        {
            _context = TiendaReparacionContextFactory.CrearContexto(); //toma la cadena desde Vista
        }
        public List<ClienteModel> GetAll()
        {
            var clientes = _context.Clientes
                                   .Include(c => c.Trabajos)
                                   .AsNoTracking() //evita que la funcion devuelva datos viejos por algun caché o tracking de ef core
                                   .ToList();
            return clientes;
        }
        public ClienteModel GetOne(int id)
        {
            return _context.Clientes
                           .AsNoTracking()
                           .FirstOrDefault(c => c.ClienteID == id);
        }
        public List<ClienteModel> GetClientesPorNombre(string nombre)
        {
            return _context.Clientes
                           .Where(e => e.Nombre.ToLower().Contains(nombre.ToLower()))
                           .ToList();
        }
        public void Insert(ClienteModel cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
        public void Update(int id, string nombre, string tel, string email)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.ClienteID == id);
            if (cliente != null)
            {
                cliente.Nombre = nombre;
                cliente.Telefono = tel;
                cliente.Email = email;

                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Error al actualizar el cliente");
            }
        }
        public void Delete(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.ClienteID == id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Error al eliminar el cliente");
            }
        }
    }
}
