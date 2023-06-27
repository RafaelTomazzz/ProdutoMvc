using Microsoft.AspNetCore.Mvc;

namespace ProdutoMvc.Controllers
{
    public class ProdutosController : Controller
    {
        public string uriBase = "http://rafaelaquino.somee.com/ProdutoApi/Produtos/";

        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            try
            {
                return Ok();
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(ex);
            }
        }
    }
}