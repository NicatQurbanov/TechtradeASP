using System.ComponentModel.DataAnnotations;

namespace ContactsASP
{
    public class Contact
    {
        static int Id = 0;
        public int ID { get; set; } = Id++;

        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Name must contain only letters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required.")]
        public string Surname { get; set; }
        public string ImageURL { get; set; } = "";

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^(?:\+994|0)(10|50|51|55|60|70|77|99)\d{7}$", ErrorMessage = "The number should begin with +994")]
        public string Phone { get; set; }
        
        public Contact()
        {
            this.ID = Id++;
        }
    }
}
