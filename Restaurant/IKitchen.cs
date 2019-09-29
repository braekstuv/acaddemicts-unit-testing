using System.Collections.Generic;

namespace RestaurantApp
{
    public interface IKitchen
    {
        ICollection<Order> GetAllOrders();
    }
}