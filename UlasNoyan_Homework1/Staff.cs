using System.ComponentModel.DataAnnotations;

namespace UlasNoyan_Homework2
{
    public class Staff  
    {
        //list of properties of the "Staff" class
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(120, MinimumLength = 20, ErrorMessage = "First name must be between 20 and 140 characters in length")]
        public string Name { get; set; }

        [StringLength(120, MinimumLength = 20, ErrorMessage = "Last name must be between 20 and 140 characters in length")]
        [Required(ErrorMessage = "Last name is required")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.DateTime)]
        [Range(typeof(DateTime), "11/11/1945", "10/10/2002",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Range(+900000000000, +910000000000)]
        public Int64 PhoneNumber { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(2000,9000)]
        public double Salary { get; set; }
    }
}
