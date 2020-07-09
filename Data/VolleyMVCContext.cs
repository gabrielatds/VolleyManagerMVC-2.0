using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolleyMVC.Models;

namespace VolleyMVC.Data
{
    public class VolleyMVCContext : DbContext
    {
        public VolleyMVCContext (DbContextOptions<VolleyMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Time> Time { get; set; }
        public DbSet<Categoria> Categoria { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasOne(x => x.Time).WithMany(x => x.Categorias).HasForeignKey(x => x.TimeId);
            modelBuilder.Entity<Time>().HasMany(x => x.Categorias).WithOne(x => x.Time);
            modelBuilder.Entity<Jogador>().HasOne(x => x.Categoria).WithMany(x => x.Jogadores).HasForeignKey(x => x.CategoriaId);
            modelBuilder.Entity<Partida>().HasOne(x => x.Time).WithMany(x => x.Partidas).HasForeignKey(x => x.TimeId).HasForeignKey(x => x.CompeticaoId);
            modelBuilder.Entity<Competicao>().HasMany(x => x.Partidas).WithOne(x => x.Competicao);
        }
    }
}
