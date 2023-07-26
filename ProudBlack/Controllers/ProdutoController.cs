using Microsoft.AspNetCore.Mvc;
using ProudBlack.Models;
using ProudBlack.Repositories.Interfaces;
using ProudBlack.ViewModels;

namespace ProudBlack.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutosRepository _produtosRepository;
        public ProdutoController(IProdutosRepository produtosRepository)
        {
            _produtosRepository = produtosRepository;
        }

        public IActionResult List(string categoria)
        {
            IEnumerable<Produto> produtos;
            string categoriaAtual = string.Empty;
            
            if(string.IsNullOrEmpty(categoria))
            {
                produtos = _produtosRepository.Produtos.OrderBy(p => p.ProdutoId);
                categoriaAtual = "Todos os produtos";
            }
            else
            {
                produtos = _produtosRepository.Produtos
                     .Where(p => p.Categoria.CategoriaName.Equals(categoria))
                     .OrderBy(c => c.Nome);
            }
            var ProdutoListViewModel = new ProdutoListViewModel
            {
                Produtos = produtos,
                CategoriaAtual = categoriaAtual,
            };

            return View( ProdutoListViewModel);
        }
    
        public IActionResult Details(int produtoId)
        {
            var produto  = _produtosRepository.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);
            return View(produto);
        }

        public ViewResult Search(string searchString)
        {
            IEnumerable<Produto> produtos;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(searchString))
            {
                produtos = _produtosRepository.Produtos.OrderBy(p => p.ProdutoId);
                categoriaAtual = "Todos os Produtos";
            }
            else
            {
                produtos = _produtosRepository.Produtos
                          .Where(p => p.Nome.ToLower().Contains(searchString.ToLower()));

                if (produtos.Any())
                    categoriaAtual = "Produtos";
                else
                    categoriaAtual = "Nenhum produto foi encontrado";
            }

            return View("~/Views/Produto/List.cshtml", new ProdutoListViewModel
            {
                Produtos = produtos,
                CategoriaAtual = categoriaAtual
            });
        }

    }
}
