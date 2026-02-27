using System.Collections.Generic;
using System.Text;

namespace MyWolt {
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            User user = new User("ali", "123456");
            Admin admin = new Admin("admin", "admin123");
            UserController userController = new UserController();
            userController.Users.AddRange(user);

            Restaurant bistro = new Restaurant("bistro");
            bistro.Menu.Meals.AddRange(new Meal("картошка фри"), new Meal("шаурма"), new Meal("стейк"));

            Console.WriteLine("Блюда в bistro");
            bistro.Menu.Meals.ForEach(meal => Console.WriteLine(meal.Name));


            user.Orders.Add(new Order(bistro, bistro.Menu.Meals[0]));
            Console.WriteLine("\nновый заказ:");

            Console.WriteLine($"Customer: {user.Name}\n" +
                $"Restaurant: {user.Orders[0].Restaurant.Name}\n" +
                $"Meal: {user.Orders[0].Meal.Name}.");





            AppMenu appMenu = new AppMenu(userController);
            appMenu.Start();
            
        }
    }
}