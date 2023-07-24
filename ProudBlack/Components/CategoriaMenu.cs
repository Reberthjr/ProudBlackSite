using Microsoft.AspNetCore.Mvc;
using ProudBlack.Repositories.Interfaces;

namespace ProudBlack.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaMenu(ICategoriaRepository categoriaRepository)
        {
           _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categoria = _categoriaRepository.Categorias.OrderBy(c => c.CategoriaName);
            return View(categoria);
        }
    }
}
