using Microsoft.AspNetCore.Mvc;
using ProudBlack.Models;
using ProudBlack.Repositories.Interfaces;
using ProudBlack.ViewModels;
using System.Diagnostics;

namespace ProudBlack.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProdutosRepository _produtosRepository;

        public HomeController(IProdutosRepository produtosRepository)
        {
            _produtosRepository = produtosRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProdutosEmPromocao = _produtosRepository.EmPromocao,
            };
            return View(homeViewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}