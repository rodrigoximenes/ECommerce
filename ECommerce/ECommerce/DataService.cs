using ECommerce.Infrastructure;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public class DataService
    {
        private readonly Contexto _contexto;

        public DataService(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public void InicializaDB()
        {
            this._contexto.Database.EnsureCreated();
            if (this._contexto.ProdutosContext.Count() == 0)
            {
                List<Produto> produtos = new List<Produto>
               {
                    new Produto( 1, "Alemanha", 159.90m),
                    new Produto( 2,"Croácia", 139.90m),
                    new Produto( 3,"Espanha", 149.90m ),
                    new Produto( 4,"Peru",    139.90m ),
                    new Produto( 5,"México", 149.90m),
                    new Produto( 6,"Suécia", 149.90m )
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
