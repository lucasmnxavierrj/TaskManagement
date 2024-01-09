using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.InputModels
{
	public class RegisterInputModel : IRegisterInputModel
	{
		[Required(ErrorMessage ="O campo é obrigatório.")]
		[StringLength(30, ErrorMessage ="O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 3)]
		[Display(Name = "Nome")]
		public string FirstName { get; set; }
		
		[Required(ErrorMessage = "O campo é obrigatório.")]
		[StringLength(80, ErrorMessage = "O campo precisa ter entre {2} e {1} caracteres.", MinimumLength = 3)]
		[Display(Name = "Sobrenome")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "O campo é obrigatório.")]
		[EmailAddress(ErrorMessage = "Digite um e-mail válido.")]
		[Display(Name = "E-mail")]
		public string Email { get; set; }

		[Required(ErrorMessage = "O campo é obrigatório.")]
		[EmailAddress(ErrorMessage = "A confirmação do e-mail é obrigatória.")]
		[Compare("Email", ErrorMessage = "Os e-mails não coincidem.")]
		[Display(Name = "Confirmação E-mail")]
		public string ConfirmationEmail { get; set; }

		[Required(ErrorMessage = "Digite sua senha de acesso.")]
		[PasswordPropertyText]
		[StringLength(30,MinimumLength = 8, ErrorMessage = "A senha deve possuir de {2} a {1} caracteres")]
		[Display(Name = "Senha")]
		public string Password { get; set; }

		[Required(ErrorMessage = "O campo é obrigatório.")]
		[StringLength(15,MinimumLength = 3, ErrorMessage = "O usuário precisa possuir um mínimo de {0} caracteres")]
		public string UserName { get; set; }
	}
}
