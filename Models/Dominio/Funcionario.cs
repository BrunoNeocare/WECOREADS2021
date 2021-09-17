using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Key]
        [DisplayName("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFuncionario { get; set; }

        [DisplayName("Funcionario")]
        [StringLength(45, ErrorMessage = "Tamanho inválido.", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string NomeFuncionario { get; set; }

        [DisplayName("Numero")]
        [StringLength(11, ErrorMessage = "Insira apenas o DDD e o número.")]
        public string Numero { get; set; }

        [DisplayName("Endereco")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Endereco { get; set; }

        [DisplayName("Idade")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Idade { get; set; }

        public Vendas vendas { get; set; }
    }
}
