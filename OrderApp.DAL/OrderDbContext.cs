using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderApp.Entities.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.DAL
{
    public class OrderDbContext :  DbContext
    {
        public OrderDbContext (DbContextOptions<OrderDbContext> options) : base(options)
        {

        }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("cnn");
                optionsBuilder.UseLazyLoadingProxies()
                    .UseSqlServer(connectionString);

            }
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
