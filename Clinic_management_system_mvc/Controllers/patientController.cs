using Clinic_management_system_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinic_management_system_mvc.Controllers
{
    public class PatientController : Controller
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
        public ActionResult Register(Patient patient)
        {
            if (ModelState.IsValid)
            {
                // Save patient data to database or perform other actions
                // For demonstration, let's just redirect to a success page
                return RedirectToAction("RegistrationSuccess");
            }

            return View(patient);
        }

        // GET: Patient/RegistrationSuccess
        public ActionResult RegistrationSuccess()
        {
            return View();
        }
    }

}

