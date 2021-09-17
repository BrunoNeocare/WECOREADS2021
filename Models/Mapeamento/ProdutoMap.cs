using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Mapeamento
{

    public class ProdutoMap: IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder)
        {
            builder.HasKey(p => p.idProduto);
            builder.Property(p => p.idProduto).ValueGeneratedOnAdd();
            builder.Property(p => p.nomeProduto).HasMaxLength(45).IsRequired();
            builder.Property(p => p.valorProduto).IsRequired();

            builder.HasMany(p => p.vendas).WithOne(p => p.produtos).HasForeignKey(p => p.produtoSelecionado).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
