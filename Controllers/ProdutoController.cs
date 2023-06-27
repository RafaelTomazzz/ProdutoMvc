using Microsoft.AspNetCore.Mvc;
using ProdutoMvc.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;

namespace ProdutoMvc.Controllers
{
    public class ProdutosController : Controller
    {
        public string uriBase = "http://rafaelaquino.somee.com/ProdutoApi/Produtos/";

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            
        }

        /*[HttpPost]
        public async Taks<ActionResult> RegistrarAsync(ProdutoViewModel u)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToActioc("Index");
            }
        }*/
    }
}