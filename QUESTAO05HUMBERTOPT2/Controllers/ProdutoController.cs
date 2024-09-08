using Microsoft.AspNetCore.Mvc;
using QUESTAO05HUMBERTOPT2.Models;

namespace QUESTAO05HUMBERTOPT2.Controllers
{
    [ApiController]
    [Route("API/PRODUTO")]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> listaProduto = new List<Produto>();

        [HttpPost]
        [Route("Cadastrar_Produto")]
        public IActionResult CadastrarProduto(Produto produto)
        {
            listaProduto.Add(produto);
            return Ok();
        }


        [HttpGet]
        [Route("Listar_Produtos_Cadastrados")]
        public IActionResult ListarProdutos()
        {
            return Ok(listaProduto);
        }

        [HttpPut]
        [Route("Atualizar_Cadastro_Produto/{codigoProduto}")]
        public IActionResult AtualizarProduto(string codigo, Produto produtoDadosNovos)
        {
            Produto? produtoAtulizar = listaProduto.Where(p => p.codigoProduto == codigo).FirstOrDefault();

            if(produtoAtulizar is null)
            {
                return BadRequest("Produto não encontrado.");
            }

            produtoAtulizar.Estoque = produtoDadosNovos.Estoque;
            produtoAtulizar.Descricao = produtoDadosNovos.Descricao;

            return Ok("Dados dos produtos atualizados.");
        }
    }
}
