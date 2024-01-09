using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.InputModels;
using TaskManagement.Application.Services;
using TaskManagement.Domain.Entities;
using TaskManagement.Infra.Data.Migrations;

namespace TaskManagement.Controllers
{
	public class LoginController : Controller
	{
		private SignInManager<User> _signInManager;
		private readonly UserManager<User> _userManager;
		private readonly IMapper _mapper;


		public LoginController(IMapper mapper, SignInManager<User> signInManager, UserManager<User> userManager)
		{
			_mapper = mapper;
			_signInManager = signInManager;
			_userManager = userManager;
		}

		public IActionResult Index()
		{
			return View();
		}

		public async Task<IActionResult> Auth(LoginInputModel dadosLogin)
		{
			if (!ModelState.IsValid)
				return View("Index", dadosLogin);

			var usuario = await _userManager.FindByEmailAsync(dadosLogin.Email);

			if (usuario is null)
				return RedirectToAction("Index", "Login", dadosLogin);

			var result = await _signInManager.CheckPasswordSignInAsync(usuario, dadosLogin.Password, false);

			if (result.Succeeded)
				return RedirectToAction("Index", "Home");
			
			return RedirectToAction("Index", "Login", dadosLogin);
		}
	}
}
