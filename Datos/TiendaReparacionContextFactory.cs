using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public static class TiendaReparacionContextFactory
    {
        private static string _connectionString;

        static TiendaReparacionContextFactory()
        {
            // Por defecto en caso que no se setee desde afuera
            _connectionString = "Server=localhost\\SQLEXPRESS;Database=TiendaReparacion;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;";
        }

        // Nuevo método para permitir que Vista establezca la cadena al iniciar
        public static void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static TiendaReparacionContext CrearContexto()
        {
            if (string.IsNullOrWhiteSpace(_connectionString))
            {
                throw new InvalidOperationException("La cadena de conexión no fue inicializada. Asegúrate de llamar a SetConnectionString() desde el Program.cs.");
            }

            var optionsBuilder = new DbContextOptionsBuilder<TiendaReparacionContext>();
            optionsBuilder.UseSqlServer(_connectionString);
            return new TiendaReparacionContext(optionsBuilder.Options);
        }
    }
}
