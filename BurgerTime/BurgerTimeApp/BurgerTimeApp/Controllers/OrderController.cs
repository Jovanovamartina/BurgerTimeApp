using BurgerTimeApp.Services.Mappers;
using BurgerTimeApp.ViewModels.Services;
using BurgerTimeApp.ViewModels.ViewModel.OrderViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BurgerTimeApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IBurgerService _burgerService;
        public OrderController(IOrderService orderService, IBurgerService burgerService)
        {
            _orderService = orderService;
            _burgerService = burgerService;
        }

        [Route("Orders")]
        public IActionResult Index()
        {
            IEnumerable<OrderViewModel> orders = _orderService.GetAllOrders();
            return View(orders);
        }

        [Route("Orders/Index/{id?}")]
        public IActionResult Details(int id)
        {
            OrderViewModel order = _orderService.GetOrderById(id).ToOrderViewModel();
            return View(order);
        }

        [HttpGet] 
        public IActionResult Edit(int id)
        {
            OrderViewModel order = _orderService.GetOrderById(id).ToOrderViewModel();

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(OrderViewModel order)
        {

            _orderService.EditOrder(order);

            return RedirectToAction("Index", "Order");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            OrderViewModel order = _orderService.GetOrderById(id).ToOrderViewModel();
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, OrderViewModel order)
        {
            _orderService.DeleteOrder(id);

            return RedirectToAction("Index", "Order");
        }

        [HttpGet]
        public IActionResult CreateOrder()
        {
            ViewBag.Burgers = _burgerService.GetAllBurgers();
            OrderViewModel orderViewModel = new OrderViewModel();
            return View(orderViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrder(OrderViewModel order)
        {
            _orderService.AddOrder(order);
            return RedirectToAction("Index", "Order");
        }
    }
}
