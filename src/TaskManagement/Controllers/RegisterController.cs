using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.InputModels;
using TaskManagement.Application.Services;
using TaskManagement.Domain.Entities;

namespace TaskManagement.MVC.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserService _userService;
		private readonly IMapper _mapper;

		public RegisterController(UserService userService, IMapper mapper)
		{
			_userService = userService;
			_mapper = mapper;
		}
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(RegisterInputModel dadosRegistro)
		{
			if (!ModelState.IsValid)
				return View("Index", dadosRegistro);

			var usuario = _mapper.Map<User>(dadosRegistro);

			var retorno = await _userService.TryAddNewUser(usuario);

			if (retorno.Success is false)
			{
				TempData["ErrorRegistering"] = retorno.Message;

				return View("Index", dadosRegistro);
			}

			TempData["SuccessRegisted"] = retorno.Message;

			return RedirectToAction("Index", "Login");

		}
	}
}
