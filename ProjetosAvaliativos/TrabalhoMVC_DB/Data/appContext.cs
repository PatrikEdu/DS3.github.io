using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TrabalhoMVC_DB.Models;

namespace TrabalhoMVC_DB.Data
{
    public partial class appContext : DbContext
    {
        public appContext()
        {
        }

        public appContext(DbContextOptions<appContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=app.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<TrabalhoMVC_DB.Models.Cliente> Cliente { get; set; }

        public DbSet<TrabalhoMVC_DB.Models.Produto> Produto { get; set; }

        public DbSet<TrabalhoMVC_DB.Models.Conta> Conta { get; set; }
    }
}
