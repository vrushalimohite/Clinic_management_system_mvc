﻿using Microsoft.AspNetCore.Mvc;

namespace Clinic_management_system_mvc.Controllers
{
	public class DoctorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}