using DAL.Configurations;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Context:DbContext
    {
        public DbSet<Personel>Personeller { get; set; }
        public DbSet<IletisimBilgisi> IletisimBilgileri { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=.;Initial catalog=kd16katmanlimimariPersonel;user ID = sa;Password=123;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonelCFG())
                        .ApplyConfiguration(new IletisimBilgisiCFG());
        }
    }
}
