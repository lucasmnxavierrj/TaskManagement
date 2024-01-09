using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Domain.Interfaces
{
	public interface IUserRepository : IBaseRepository<User>
	{
		Task<bool> IsUserCadastradoByEmail(string email);

		Task<User?> GetUserByEmailAsync(string email);
	}
}
