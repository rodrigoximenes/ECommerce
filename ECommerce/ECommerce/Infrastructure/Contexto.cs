using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure
{
    public class Contexto : DbContext
    {
        public DbSet<Produto> ProdutosContext{ get; set; }
        public DbSet<ItemPedido> ItemPedidoContext { get; set; }
    }
}
