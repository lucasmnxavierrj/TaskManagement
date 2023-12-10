using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Application.InputModels
{
	public class LoginInputModel
	{
		[Required(ErrorMessage = "O campo é obrigatório.")]
		[EmailAddress(ErrorMessage = "Digite um e-mail válido.")]
		[Display(Name = "E-mail")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Digite sua senha de acesso.")]
		[PasswordPropertyText]
		[StringLength(30,MinimumLength = 8, ErrorMessage = "A senha deve possuir de {2} a {1} caracteres")]
		[Display(Name = "Senha")]
		public string Password { get; set; }
	}
}
