using BurgerTimeApp.DataAccsess.Database;
using BurgerTimeApp.Domain.Entities;
using BurgerTimeApp.Domain.Repositories;
using System;


namespace BurgerTimeApp.DataAccsess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IReadOnlyList<Order> GetAllOrders()
        {
            return BurgerDatabase.ORDERS;
        }
        public Order GetOrderById(int id)
        {
            return BurgerDatabase.ORDERS.FirstOrDefault(x => x.Id == id);
        }
        public void Remove(Order order)
        {
            BurgerDatabase.ORDERS.Remove(order);
        }

        public void Update(Order order)
        {
            int index = BurgerDatabase.ORDERS.FindIndex(x => x.Id == order.Id);
            BurgerDatabase.ORDERS[index] = order;
        }
        public void Add(Order order)
        {
            BurgerDatabase.ORDERS.Add(order);
        }
    }
}
