using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Vendas> Vendas { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; } 
    }
}
