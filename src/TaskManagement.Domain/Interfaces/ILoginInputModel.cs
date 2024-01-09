using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Domain.Interfaces
{
	public interface ILoginInputModel
	{
		string Email { get; set; }
		string Password { get; set; }
	}
}
