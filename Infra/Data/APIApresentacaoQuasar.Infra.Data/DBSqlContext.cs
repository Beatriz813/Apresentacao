using APIApresentacaoQuasar.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIApresentacaoQuasar.Infra.Data
{
    public class DBSqlContext : DbContext
    {
        public DBSqlContext(DbContextOptions<DBSqlContext> options)
            : base(options)
        {

        }
        public DbSet<Pessoa> Pessoa { get; set; }
        protected internal virtual void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pessoa>(p =>
            {
                p.ToTable("Pessoa");
            });
        }
    }
}
