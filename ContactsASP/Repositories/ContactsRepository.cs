

namespace ContactsASP.Repositories
{
    public class ContactsRepository
    {
        public static List<Contact> Contacts { get; set; } = new List<Contact>()
        {
            new Contact() {Name = "Jane", Surname = "Austin", ImageURL = "lib/Images/jane-austen.avif", Email = "default@gmail.com", Phone = "+994504801601" },
            new Contact() {Name = "Kazimir", Surname = "Malevich", ImageURL = "lib/Images/Malevich.jpeg", Email = "default@gmail.com", Phone = "+994504801601" },
            new Contact() {Name = "Henry", Surname = "Ford", ImageURL = "lib/Images/Henry-Ford.webp"},
            new Contact() {Name = "Steve", Surname = "Wozniak", ImageURL = "lib/Images/Steve.jfif"},
            new Contact() {Name = "Jonathan", Surname = "Ive", ImageURL = "lib/Images/Ive.avif", Email = "default@gmail.com"},
            new Contact() {Name = "Bill", Surname = "Gates", ImageURL = "lib/Images/bill.jfif",  Phone = "+994504801601"},
            new Contact() {Name = "Jack", Surname = "London", ImageURL = "lib/Images/jack.avif"},
            new Contact() {Name = "Coco", Surname = "Chanel", ImageURL = "lib/Images/coco.jfif", Email = "default@gmail.com"},
            new Contact() {Name = "Pablo", Surname = "Picasso", ImageURL = "lib/Images/picasso.jfif"},
        };

        public void AddContact(Contact contact) => Contacts.Add(contact);

        public Contact? GetContact(int id) => Contacts.FirstOrDefault(c => c.ID == id);
    }
}
