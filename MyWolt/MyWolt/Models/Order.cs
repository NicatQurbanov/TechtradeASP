
namespace MyWolt
{
    public class Order(Restaurant restaurant, Meal meal)
    {
        public Restaurant Restaurant { get; set; } = restaurant;
        public Meal Meal { get; set; } = meal;

        public OrderStatus Status { get; set; } = OrderStatus.Placed;

        public OrderType Type { get; set; } = OrderType.Delivery;
        public enum OrderStatus : byte
        {
            Placed,
            InProgress,
            Delivered,
            Cancelled
        }

        public enum OrderType : byte
        {
            Delivery,
            Takeaway
        }
    }
}
