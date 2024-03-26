using Clinic_management_system_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Clinic_management_system_mvc.Controllers
{
    public class DoctorController : Controller
    {
           [HttpGet]
            public ActionResult Registration()
            {
                return View(new Doctor());
            }

            [HttpPost]
            public ActionResult Register(Doctor doctor)
            {
                if (ModelState.IsValid)
                {
                    // Save doctor to database or perform other actions
                    // Redirect to success page or another action
                    return RedirectToAction("RegistrationSuccess");
                }
                // If validation fails, return to the registration form with errors
                return View("Registration", doctor);
            }

            public ActionResult RegistrationSuccess()
            {
                return View();
            }
       
            public ActionResult Index()
            {
                var model = new MyDropDownModel
                {
                    Items = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Option 1" },
                new SelectListItem { Value = "2", Text = "Option 2" },
                new SelectListItem { Value = "3", Text = "Option 3" }
            }
                };

                ViewBag.MyDropDownModel = model;

                return View();
            }
        }

    }



