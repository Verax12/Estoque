using Estoque.Dominio.Entities;
using Estoque.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Infra.Data.Context
{
    public class EstoqueContext : DbContext
    {

        public EstoqueContext(DbContextOptions dbContextOptions):base (dbContextOptions)
        {

        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\w.gontijo\\Documents\\Controlle_Estoque.mdf;Integrated Security=True;Connect Timeout=30", b => b.MigrationsAssembly("Estoque.Services"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserMap());
        }



        #region DBSET
        public DbSet<User> Users { get; set; }
        #endregion

    }
}
