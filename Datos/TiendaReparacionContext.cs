using Microsoft.EntityFrameworkCore;
using Modelos;
namespace Datos
{
    public class TiendaReparacionContext : DbContext
    {
        public TiendaReparacionContext(DbContextOptions<TiendaReparacionContext> options)
            : base(options) { }

        public DbSet<PrecioTareaModel> PreciosTarea {  get; set; }
        public DbSet<TareaModel> Tareas { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<EmpleadoModel> Empleados { get; set; }
        public DbSet<TrabajoModel> Trabajos { get; set; }
    }
}
