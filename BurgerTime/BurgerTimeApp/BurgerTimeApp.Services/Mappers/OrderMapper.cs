

using BurgerTimeApp.Domain.Entities;
using BurgerTimeApp.ViewModels.ViewModel.OrderViewModel;

namespace BurgerTimeApp.Services.Mappers
{
    public static class OrderMapper
    {
        public static OrderViewModel ToOrderViewModel(this Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                FullName = order.FullName,
                Address = order.Address,
                IsDelievered = order.IsDelievered,
                Burgers = order.Burgers,
                Location = order.Location
            };
        }
        public static OrderListViewModel ToOrderListViewModel(this List<Order> orders)
        {
            return new OrderListViewModel
            {
                Orders = orders.Select(x => x.ToOrderViewModel()).ToList()
            };
        }
    }
}
