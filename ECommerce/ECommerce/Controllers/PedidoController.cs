using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerce.Controllers
{
    public class PedidoController : Controller
    {

        public IActionResult Carrossel()
        {
            var produtos = new List<Produto>
           {
                new Produto(1, "Alemanha", 159.90m),
                new Produto( 2,"Croácia", 139.90m),
                new Produto( 3,"Espanha", 149.90m ),
                new Produto( 4,"Peru",    139.90m ),
                new Produto( 5,"México", 149.90m),
                new Produto( 6,"Suécia", 149.90m )
            };
            return View(produtos);
        }

        public IActionResult Carrinho()
        {



            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View();
        }
    }
}
