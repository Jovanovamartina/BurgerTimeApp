

using BurgerTimeApp.Domain.Entities;
using BurgerTimeApp.Domain.Repositories;
using BurgerTimeApp.Services.Mappers;
using BurgerTimeApp.ViewModels.Services;
using BurgerTimeApp.ViewModels.ViewModel.OrderViewModel;

namespace BurgerTimeApp.Services.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IBurgerRepository _burgerRepository;
        public OrderService(IOrderRepository orderRepository, IBurgerRepository burgerRepository)
        {
            _orderRepository = orderRepository;
            _burgerRepository = burgerRepository;
        }
        public IReadOnlyList<OrderViewModel> GetAllOrders()
        {
            IReadOnlyList<Order> orders = _orderRepository.GetAllOrders();
            return orders.Select(x => x.ToOrderViewModel()).ToArray();
        }

        public Order GetOrderById(int id)
        {
            IReadOnlyList<Order> orders = _orderRepository.GetAllOrders();
            return orders.FirstOrDefault(x => x.Id == id);
        }

        public void EditOrder(OrderViewModel order)
        {
            Order orderToUpdate = _orderRepository.GetOrderById(order.Id);

            orderToUpdate.FullName = order.FullName;
            orderToUpdate.Address = order.Address;
            orderToUpdate.Location = order.Location;
            orderToUpdate.IsDelievered = order.IsDelievered;

            _orderRepository.Update(orderToUpdate);
        }

        public void DeleteOrder(int id)
        {
            Order order = _orderRepository.GetOrderById(id);
            _orderRepository.Remove(order);
        }

        public void AddOrder(OrderViewModel order)
        {
            int index = _orderRepository.GetAllOrders().Count() + 1;
        
            Order newOrder = new Order(index, order.FullName, order.Address, order.IsDelievered, order.Burgers, order.Location);

            _orderRepository.Add(newOrder);
        }
    }
}
