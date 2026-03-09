
namespace MyWolt
{
    public class User(string name, string password) : Profile(name, password)
    {
        public static int i = 0;
        public int Id { get; set; } = i++;
        public OrderController OrderCtrl { get; set; } = new OrderController();
    }
}
