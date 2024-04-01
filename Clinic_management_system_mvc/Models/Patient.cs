using System.ComponentModel.DataAnnotations;

namespace Clinic_management_system_mvc.Models
{
    public class Patient
    {
        

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter patient's name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter patient's age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter patient's disease")]
        public string Disease { get; set; }

        [Required(ErrorMessage = "Please enter patient's city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter patient's date of birth")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }

}

