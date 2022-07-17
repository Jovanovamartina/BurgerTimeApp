using BurgerTimeApp.DataAccsess.Database;
using BurgerTimeApp.Domain.Entities;
using BurgerTimeApp.ViewModels.Services;
using BurgerTimeApp.ViewModels.ViewModel.BurgerViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BurgerTimeApp.Controllers
{
    public class BurgerController : Controller
    {
        private readonly IBurgerService _burgerService;
        public BurgerController(IBurgerService burgerService)
        {
            _burgerService = burgerService;
        }
        [Route("Burgers")]
        public IActionResult Index()
        {
            IEnumerable<BurgerViewModel> burgers = _burgerService.GetAllBurgers();
            return View(burgers);
        }
        [Route("Burgers/Details/{id?}")]
        public IActionResult Details(int id)
        {
            Burger burger = BurgerDatabase.BURGERS.FirstOrDefault(b => b.Id == id);
            return View(burger);
        }
    }
}
