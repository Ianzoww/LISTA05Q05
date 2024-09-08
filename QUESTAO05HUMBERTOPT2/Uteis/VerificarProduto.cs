using System.Text.RegularExpressions;

namespace QUESTAO05HUMBERTOPT2.Uteis
{
    public class VerificarProduto 
    {
        public static bool Verificar_Produto(string codigo)
        {
            if(codigo.Length != 8 || codigo is null)
            {
                return false;
            }

            string padraoCodigoEstoque = @"^[A-Z]{3}-\d{4}$";

            return Regex.IsMatch(codigo, padraoCodigoEstoque);
        }
    }
}
