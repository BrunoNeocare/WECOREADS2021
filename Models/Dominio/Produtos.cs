using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Produtos
    {
        [Key]
        [DisplayName("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProduto { get; set; }

        [DisplayName("Tipo do Produto")]
        [StringLength(45, ErrorMessage = "Tamanho inválido.", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string tipoProduto { get; set; }

        [DisplayName("Produto")]
        [StringLength(45, ErrorMessage = "Tamanho inválido.", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string nomeProduto { get; set; }

        [DisplayName("Preco")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string valorProduto { get; set; }

        public ICollection<Vendas> vendas { get; set; }
    }
}
