

namespace MyWolt
{
    public class MenuController
    {
        public Menu Menu { get; set; } = new Menu();
        
        public void Show() => Menu.Meals.ForEach(m => Console.WriteLine($"{Menu.Meals.IndexOf(m) + 1}. {m.Name}\n"));
    }
}
