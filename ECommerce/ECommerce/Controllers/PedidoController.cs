using ECommerce.Models;
using ECommerce.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerce.Controllers
{
    public class PedidoController : Controller
    {

        private readonly IDataService _dataService;

        public PedidoController(IDataService dataService)
        {
            this._dataService = dataService; 
        }

        public IActionResult Carrossel()
        {
            List<Produto> produtos = _dataService.GetProdutos();
            return View(produtos);
        }

        public IActionResult Carrinho()
        {
            CarrinhoViewModel carrinhoViewModel = GetCarrinhoViewModel();

            return View(carrinhoViewModel);
        }

        private CarrinhoViewModel GetCarrinhoViewModel()
        {
            List<Produto> produtos = this._dataService.GetProdutos();

            var itensCarrinho = this._dataService.GetItensPedido();

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
