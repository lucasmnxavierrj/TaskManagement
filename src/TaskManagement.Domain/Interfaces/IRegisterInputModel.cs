using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Domain.Interfaces
{
	public interface IRegisterInputModel
	{
		string FirstName { get; set; }
		string LastName { get; set; }
		string Email { get; set; }
		string ConfirmationEmail { get; set; }
		string Password { get; set; }
		string UserName { get; set; }
	}
}
