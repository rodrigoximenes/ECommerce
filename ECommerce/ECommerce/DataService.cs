using ECommerce.Infrastructure;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public class DataService : IDataService
    {
        private readonly Contexto _contexto;

        public DataService(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public List<ItemPedido> GetItensPedido()
        {
            return this._contexto.ItemPedidoContext.ToList();
        }

        public List<Produto> GetProdutos()
        {
            return this._contexto.ProdutosContext.ToList();

        }

        public void InicializaDB()
        {
            this._contexto.Database.EnsureCreated();
            if (this._contexto.ProdutosContext.Count() == 0)
            {
                List<Produto> produtos = new List<Produto>
               {
                    new Produto( "Alemanha", 159.90m),
                    new Produto( "Croácia",  139.90m),
                    new Produto( "Espanha",  149.90m ),
                    new Produto( "Peru",     139.90m ),
                    new Produto( "México",   149.90m),
                    new Produto( "Suécia",   149.90m )
                };

                foreach (var produto in produtos)
                {
                    this._contexto.ProdutosContext.Add(produto);
                    this._contexto.ItemPedidoContext.Add(new ItemPedido(produto, 1));
                }
            }
            this._contexto.SaveChanges();
        }
    }
}
