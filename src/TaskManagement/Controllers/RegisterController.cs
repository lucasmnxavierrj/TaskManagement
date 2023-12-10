using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.InputModels;
using TaskManagement.Application.Services;

namespace TaskManagement.MVC.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserService _userService;

		public RegisterController(UserService userService)
		{
			_userService = userService;
		}
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(RegisterInputModel dadosRegistro)
		{
			if (!ModelState.IsValid)
				return View("Index", dadosRegistro);

			_userService.Add(new Domain.Entities.User
			{
				FirstName = dadosRegistro.FirstName,
				LastName = dadosRegistro.LastName,
				Email = dadosRegistro.Email,
				Password = dadosRegistro.Password,
				UserName = dadosRegistro.UserName,
				LastUpdatedOn = DateTime.Now,
				CreatedOn = DateTime.Now,
			});

			_userService.Commit();

			return RedirectToAction("Index","Login");
		}
	}
}
