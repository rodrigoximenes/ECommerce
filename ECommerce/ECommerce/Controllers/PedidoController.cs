using ECommerce.Models;
using ECommerce.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerce.Controllers
{
    public class PedidoController : Controller
    {
        List<Produto> produtos = new List<Produto>
           {
                new Produto(1, "Alemanha", 159.90m),
                new Produto( 2,"Croácia", 139.90m),
                new Produto( 3,"Espanha", 149.90m ),
                new Produto( 4,"Peru",    139.90m ),
                new Produto( 5,"México", 149.90m),
                new Produto( 6,"Suécia", 149.90m )
            };

        public IActionResult Carrossel()
        {
            return View(produtos);
        }

        public IActionResult Carrinho()
        {
            CarrinhoViewModel carrinhoViewModel = GetCarrinhoViewModel();

            return View(carrinhoViewModel);
        }

        private CarrinhoViewModel GetCarrinhoViewModel()
        {
            var itensCarrinho = new List<ItemPedido>
            {
                new ItemPedido(1, produtos[0], 1),
                new ItemPedido(2, produtos[1], 2)
        };

            var carrinhoViewModel = new CarrinhoViewModel(itensCarrinho);
            return carrinhoViewModel;
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            CarrinhoViewModel carrinhoViewModel = GetCarrinhoViewModel();

            return View(carrinhoViewModel);
        }
    }
}
