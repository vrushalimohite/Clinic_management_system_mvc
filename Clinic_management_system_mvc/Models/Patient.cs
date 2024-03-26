namespace Clinic_management_system_mvc.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
    }
}
