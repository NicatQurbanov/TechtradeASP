
namespace MyWolt
{
    public class UserController
    {
        public List<User> Users { get; set; } = new List<User>();

        public void AddUser(User user) => Users.Add(user);

        public void DeleteUser(int i)
        {
            User? user = Users.FirstOrDefault(u => u.Id == i);

            if (user != null)
                Users.Remove(user);
            else
                Console.WriteLine("User not found");
        }

        public void UpdateUserName(int i, string name)
        {
            User? user = Users.FirstOrDefault(u => u.Id == i);

            if (user != null)
                user.Name = name;
            else
                Console.WriteLine("User not found");
        }
    }
}
