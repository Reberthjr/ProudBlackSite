using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProudBlack.Models;

namespace ProudBlack.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
        
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet <PedidoDetalhe> PedidosDetalhes{ get; set; }
        

    }
}
