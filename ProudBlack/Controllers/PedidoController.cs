using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProudBlack.Models;
using ProudBlack.Repositories.Interfaces;

namespace ProudBlack.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _petoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoController(IPedidoRepository petoRepository, CarrinhoCompra carrinhoCompra)
        {
            _petoRepository = petoRepository;
            _carrinhoCompra = carrinhoCompra;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Checkout(Pedido pedido) 
        {
           int totalItensPedido = 0;
           decimal precoTotalPedido = 0.0m;

            //obtem os itens do carrinho de compra do cliente

            List<CarrinhoCompraItem> items = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItems = items;
            
            //verifica se ja tem intens no pedido

            if(_carrinhoCompra.CarrinhoCompraItems.Count == 0)
            {
                ModelState.AddModelError("", "Seu carrinho está vazio.");
            }

            //Calcular o total de itens e valor

            foreach(var item in items)
            {
                totalItensPedido += item.Quantidade;
                precoTotalPedido += (item.Produto.Preco * item.Quantidade);
            }
            //atribuir os valores ao pedido
            pedido.TotalItensPedido = totalItensPedido;
            pedido.PedidoTotal = precoTotalPedido;

            //validar dados pedido

            if (ModelState.IsValid)
            {
                //criar o pedido e seus detalhes
                _petoRepository.CriarPedido(pedido);

                //define mensassem ao cliente

                ViewBag.CheckoutCompletoMensagem = "Obrigado por comprar na ProudBlack :)";
                ViewBag.TotalPedido = _carrinhoCompra.GetCarrinhoCompraTotal();

                //Limpar o carrinho
                _carrinhoCompra.LimparCarrinho();

                //exibir os dados do cliente e pedido

                return View("~/Views/Pedido/CheckoutCompleto.cshtml", pedido);

            }
            return View(pedido);

        }
    }
}
 