using ColitaWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ColitaWeb
{
    public class colitaContext : DbContext
    {
        public IConfiguration _config { get; set; }
        public colitaContext(DbContextOptions<colitaContext> options)
        : base(options)
        {
            ConfigurateBuilder();
        }
        private void ConfigurateBuilder()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json");
            _config = builder.Build();
        }
        public DbSet<ColitaEF> ColitasEF { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (_config != null) ConfigurateBuilder();
                var conn = _config.GetConnectionString("ColitaConn");
                optionsBuilder.UseMySql(conn, mySqlOptions => mySqlOptions
                    .ServerVersion(new Version(8, 0, 18), ServerType.MySql)
                    .CommandTimeout(30)
                    );
            }
            

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.
                Entity<ColitaEF>()
                .Property(e => e.EstadoDeColita)
                .HasConversion<int>();
        }
    }
}
