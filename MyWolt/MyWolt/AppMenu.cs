

namespace MyWolt
{
    public class AppMenu(Admin admin, RestaurantController restaurantController)
    {
        public UserController UserCtrl { get; } = admin.UserCtrl;

        public RestaurantController RestaurantCtrl { get; } = restaurantController;

        public List<User> Users { get; set; } = admin.UserCtrl.Users;

        public User? currUser;
        public void Start()
        {
            Console.WriteLine("Welcome to Wolt App!");
                Console.WriteLine("1. Login\n2. Register.\n3. Exit");
    
                ConsoleKeyInfo key = Console.ReadKey(); Console.WriteLine();

            switch (key.KeyChar)
                {
                    case '1':
                        Login();
                        break;
                    case '2':
                        Console.WriteLine("Register selected");
                        break;
                    case '3':
                        Console.WriteLine("Exit selected");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
            }

        }
        public void Login()
        {
            Console.Clear();
            Console.Write("Nickname: "); string? nickname = Console.ReadLine();
            Console.Write("Password: "); string? password = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Name == nickname && Users[i].Password == password)
                {
                    found = true; 
                    if (nickname == "admin")
                        Admin();
                    currUser = Users[i];
                    User();
                }
            }
            if (!found) Console.WriteLine("User not found");
        }

        public void Admin()
        {

        }

        public void User()
        {
            Console.Clear();
            Console.WriteLine("1.Рестораны\n2.Заказы\n3.Выйти\n");

            ConsoleKeyInfo key = Console.ReadKey(); Console.WriteLine();

            switch (key.KeyChar)
            {
                case '1':
                    Console.Clear(); Console.WriteLine("Restaurants: ");
                    RestaurantCtrl.Show();
                    TakeOrderRestaurant();
                    break;
                case '2':
                    currUser.OrderCtrl.Show();
                    break;
                case '3':
                    Start();
                    break;
            }
        }

        public void TakeOrderRestaurant()
        {
            Console.WriteLine("Choose the index of restaurant you want to take order from: ");
            int.TryParse(Console.ReadLine(), out int choice);

            if (choice != null && choice <= RestaurantCtrl.Restaurants.Count)
            {
                Restaurant restaurantOrder = RestaurantCtrl.Restaurants[choice - 1];
                TakeOrderMeal(choice, restaurantOrder);
            }
            else
            {
                Console.WriteLine("Invalid input"); Console.ReadLine();
                User();
            }
        }

        public void TakeOrderMeal(int choice, Restaurant restaurant)
        {
            RestaurantCtrl.Restaurants[choice - 1].MenuCtrl.Show();
            Console.WriteLine("Choose the index of meal you want order to: ");
            int.TryParse(Console.ReadLine(), out int index);

            if (index != null && index <= restaurant.MenuCtrl.Menu.Meals.Count)
            {
                Meal mealOrder = restaurant.MenuCtrl.Menu.Meals[index - 1];
                PlaceOrder(restaurant, mealOrder);
                Start();
            }
            else
            {
                Console.WriteLine("Invalid input");
                TakeOrderRestaurant();
            }
        }

        public void PlaceOrder(Restaurant restaurant, Meal mealOrder)
        {
            currUser.OrderCtrl.AddOrder(new Order(restaurant, mealOrder));
            Console.WriteLine($"Your {mealOrder.Name} from {restaurant.Name} placed successfully!");
        }
    }
}
