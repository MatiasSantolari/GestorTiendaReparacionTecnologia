using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TiendaReparacionTimeDesignTimeFactory : IDesignTimeDbContextFactory<TiendaReparacionContext>
    {
        public TiendaReparacionContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TiendaReparacionContext>();
            optionsBuilder.UseSqlServer(
                "Server=localhost\\SQLEXPRESS;" +
                "Database=TiendaReparacion;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;" +
                "MultipleActiveResultSets=True;");
            return new TiendaReparacionContext(optionsBuilder.Options);
        }
    }
}
