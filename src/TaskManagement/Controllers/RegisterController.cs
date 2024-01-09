using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.InputModels;
using TaskManagement.Application.Services;
using TaskManagement.Domain.Entities;

namespace TaskManagement.MVC.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<User> _userManager;
		private readonly IMapper _mapper;

		public RegisterController(UserManager<User> userManager, IMapper mapper)
		{
			_userManager = userManager;
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

			var resultado = await _userManager.CreateAsync(usuario, dadosRegistro.Password);

			if (resultado.Succeeded)
			{
				TempData["SuccessRegisted"] = "Usuário cadastrado com sucesso! 🥳";

				return RedirectToAction("Index", "Login");
			}

			TempData["ErrorRegistering"] = resultado.Errors.Select(x => x.Description).ToList();
			
			return View("Index", dadosRegistro);

		}
	}
}
