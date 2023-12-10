using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.InputModels;

namespace TaskManagement.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Auth(LoginInputModel user)
		{
			if (!ModelState.IsValid)
				return View("Index", user);

			return null;
		}
	}
}
