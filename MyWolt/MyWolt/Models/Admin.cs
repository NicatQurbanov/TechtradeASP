

namespace MyWolt
{
    public class Admin(string name, string password) : Profile(name, password)
    {
        public UserController UserCtrl { get; set; } = new UserController();
    }
}
