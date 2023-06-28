using System;

namespace ProdutoMvc.Models
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Valor { get; set; }
        public DateTime Validade { get; set; } 
    }
}