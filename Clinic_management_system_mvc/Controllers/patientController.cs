using Microsoft.AspNetCore.Mvc;

namespace Clinic_management_system_mvc.Controllers
{
	public class patientController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

	 // GET: Patient/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Patient/Register
        [HttpPost]
        public ActionResult Register(patientController patient)
        {
            // Save patient data to the database or perform other actions
            // For demonstration, let's assume we save the patient to a database
            // patientRepository.Save(patient);

            // Redirect to a success page or show a success message
            return RedirectToAction("RegistrationSuccess");
        }

        // GET: Patient/RegistrationSuccess
        public ActionResult RegistrationSuccess()
        {
            return View();
        }
    }

}

