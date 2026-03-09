namespace MyWolt
{
    public class RestaurantController
    {
        public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();

        public void Show() => Restaurants.ForEach(r => Console.WriteLine($"{Restaurants.IndexOf(r) + 1}. {r.Name}"));


    }
}
