using Microsoft.AspNetCore.Mvc.Rendering;

namespace Clinic_management_system_mvc.Models
{
	public class Doctor
	{
		
			public string Name { get; set; }
			public string Email { get; set; }
			public string Specialty { get; set; }
			// Add more properties as needed
		

	}
    public class MyDropDownModel
    {
        public int SelectedItemId { get; set; }
        public List<SelectListItem> Items { get; set; }
    }

}
