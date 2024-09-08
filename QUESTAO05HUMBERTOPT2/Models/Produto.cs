using System.ComponentModel.DataAnnotations;
using QUESTAO05HUMBERTOPT2.Uteis;
using QUESTAO05HUMBERTOPT2.Validation;

namespace QUESTAO05HUMBERTOPT2.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? Descricao { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        [ValidacaoProduto(ErrorMessage = "Codigo inválido!")]
        public string? codigoProduto { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        public int? Estoque { get; set; }
    }
}
