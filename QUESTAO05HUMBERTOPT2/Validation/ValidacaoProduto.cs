using QUESTAO05HUMBERTOPT2.Uteis;
using System.ComponentModel.DataAnnotations;

namespace QUESTAO05HUMBERTOPT2.Validation
{
    public class ValidacaoProduto : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return VerificarProduto.Verificar_Produto(value.ToString());
        }
    }
}
