

using BurgerTimeApp.Domain.Entities;
using BurgerTimeApp.ViewModels.ViewModel.OrderViewModel;

namespace BurgerTimeApp.ViewModels.Services
{
    public interface IOrderService
    {
        IReadOnlyList<OrderViewModel> GetAllOrders();
        Order GetOrderById(int id);
        void EditOrder(OrderViewModel order);
        void DeleteOrder(int id);
        void AddOrder(OrderViewModel order);
    }
}
