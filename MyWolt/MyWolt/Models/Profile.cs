
namespace MyWolt
{
    public abstract class Profile(string name, string password)
    {
        public string Name { get; set; } = name;
        public string Password { get; set; } = password;
    }
}
