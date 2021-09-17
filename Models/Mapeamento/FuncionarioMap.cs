using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Mapeamento
{
    public class FuncionarioMap: IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(p => p.IdFuncionario);
            builder.Property(p => p.IdFuncionario).ValueGeneratedOnAdd();
            builder.Property(p => p.NomeFuncionario).HasMaxLength(45).IsRequired();
            builder.Property(p => p.Numero).HasMaxLength(11).IsRequired();
            builder.Property(p => p.Endereco).HasMaxLength(25).IsRequired();
            builder.Property(p => p.Idade).IsRequired();
        }
    }
}
