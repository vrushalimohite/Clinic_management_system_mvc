using System.ComponentModel.DataAnnotations;

namespace Clinic_management_system_mvc.Models
{
    public class Login
    {
        public int UserID { get; set; }
        // -- Validating User ,UserID  
         [Required(ErrorMessage = "Userid is required")]
         [MaxLength(12)]
        public string Password { get; set; }
        // -- Validating Password  
         [Required(ErrorMessage = "Password is required")]

        public string select { get; set; }
    }
}
