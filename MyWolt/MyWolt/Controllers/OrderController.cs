

namespace MyWolt
{
    public class OrderController
    {
        public List<Order> Orders { get; set; } = new List<Order>();
        
        public void Show() => Orders.ForEach(o => Console.WriteLine($"{Orders.IndexOf(o) + 1}. {o.Meal.Name}\n Заведение: {o.Restaurant.Name}"));    

        public void AddOrder(Order order ) => Orders.Add(order);
    }
}
