using Vista;
using DotNetEnv;

namespace GestorTiendaReparacionPC
{
    public static class Bootstrap
    {
        public static void Inicializar()
        {
            Env.Load();
            var connStr = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

            if (string.IsNullOrWhiteSpace(connStr))
                throw new InvalidOperationException("Cadena de conexión no encontrada en .env");

            Datos.TiendaReparacionContextFactory.SetConnectionString(connStr);
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Bootstrap.Inicializar();

            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
        }
    }
}