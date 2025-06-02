using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Infrastructure.TrainStation.Infrastructure.EntityFramework;

namespace TrainStation
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Временная строка подключения (можно взять из appsettings.json вручную)
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=StationDB;Username=postgres;Password=1234567");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
