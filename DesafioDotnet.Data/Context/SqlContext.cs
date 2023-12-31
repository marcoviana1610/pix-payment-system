﻿using DesafioDotnet.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioDotnet.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions options): base(options) 
        {
        }

        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<ChaveModel> Chaves { get; set; }
        public DbSet<Pagador> Pagadores { get; set; }
        public DbSet<Recebedor> Recebedores { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
