using ProudBlack.Models;

namespace ProudBlack.Repositories.Interfaces
{
    public interface IProdutosRepository
    {
        IEnumerable<Produto> Produtos { get; }
        IEnumerable<Produto> EmPromocao { get; }
        Produto GetProdutoById(int Produtoid);
    }
}
