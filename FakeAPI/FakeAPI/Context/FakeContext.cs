using FakeAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeAPI.Context
{
    public class FakeContext : DbContext
    {
        public DbSet<Fake> Fake { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration config = new ConfigurationBuilder()
                  .AddJsonFile("config.json", true)
                  .Build();

            optionsBuilder.UseSqlServer(config["ConnectionStrings:DefaultConnection"]);

        }
    }

    
}
