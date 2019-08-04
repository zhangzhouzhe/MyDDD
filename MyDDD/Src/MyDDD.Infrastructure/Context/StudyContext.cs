using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyDDD.Domain.Model;
using MyDDD.Infrastructure.Mappings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyDDD.Infrastructure.Context
{
    public class StudyContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected new void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMap());
            base.OnModelCreating(modelBuilder);
        }

        protected new void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
