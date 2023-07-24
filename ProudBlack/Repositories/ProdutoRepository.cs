using Microsoft.EntityFrameworkCore;
using ProudBlack.Context;
using ProudBlack.Models;
using ProudBlack.Repositories.Interfaces;

namespace ProudBlack.Repositories
{
    public class ProdutoRepository : IProdutosRepository
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext contexto)
        {
            _context = contexto;
            
        }
        IEnumerable<Produto> IProdutosRepository.Produtos => _context.Produtos.Include(c => c.Categoria);

        IEnumerable<Produto> IProdutosRepository.EmPromocao => _context.Produtos.Where(l => l.EmPromocao).Include(c => c.Categoria);

        Produto IProdutosRepository.GetProdutoById(int Produtoid)
        {
            return _context.Produtos.FirstOrDefault(p => p.ProdutoId == Produtoid);
        }
    }
}
