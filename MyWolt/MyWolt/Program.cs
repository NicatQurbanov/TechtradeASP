using System.Collections.Generic;
using System.Text;

namespace MyWolt {
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Restaurant bistroN1 = new Restaurant("bistro");
            Restaurant ilPatio = new Restaurant("il patio");
            Restaurant mcdonalds = new Restaurant("mcdonalds");
            bistroN1.MenuCtrl.Menu.Meals.AddRange(new Meal("картошка фри"), new Meal("шаурма"), new Meal("стейк"));
            mcdonalds.MenuCtrl.Menu.Meals.AddRange(new Meal("картошка фри"), new Meal("шаурма"), new Meal("стейк"));

            User user = new User("ali", "123456");
            User nicat = new User("nicat", "654321");
            Admin admin = new Admin("admin", "admin123");
            nicat.OrderCtrl.Orders.Add(new Order(mcdonalds, mcdonalds.MenuCtrl.Menu.Meals[1]));
            admin.UserCtrl.Users.AddRange(user, nicat);

            RestaurantController restaurantController = new RestaurantController();
            restaurantController.Restaurants.AddRange(bistroN1, ilPatio, mcdonalds);
            Console.WriteLine("Блюда в bistro");
            bistroN1.MenuCtrl.Menu.Meals.ForEach(meal => Console.WriteLine(meal.Name));

            
            user.OrderCtrl.Orders.Add(new Order(bistroN1, bistroN1.MenuCtrl.Menu.Meals[0]));
            Console.WriteLine("\nновый заказ:");


            Console.WriteLine($"Customer: {user.Name}\n" +
                $"Restaurant: {user.OrderCtrl.Orders[0].Restaurant.Name}\n" +
                $"Meal: {user.OrderCtrl.Orders[0].Meal.Name}.");





            AppMenu appMenu = new AppMenu(admin, restaurantController);
            appMenu.Start();
            
        }
    }
}