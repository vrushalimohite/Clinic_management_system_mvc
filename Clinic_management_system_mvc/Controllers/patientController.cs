using Clinic_management_system_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinic_management_system_mvc.Controllers
{
    public class PatientController : Controller
    {
       
            // GET: Patient
            public ActionResult Registration()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Register(Patient patient)
            {
                // Here you might want to save the patient data to a database
                // For now, let's assume registration is successful
                return RedirectToAction("RegistrationSuccessful");
            }

            public ActionResult RegistrationSuccessful()
            {
                return View();
            }
        }
    }


