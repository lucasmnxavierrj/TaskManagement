using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;
using TaskManagement.Infra.Data.Context;

namespace TaskManagement.Infra.Data.Repositories
{
	public class UserRepository : BaseRepository<User>, IUserRepository
	{
		public UserRepository(AppDbContext context) : base(context) { }

		public async Task<bool> IsUserCadastradoByEmail(string email)
			=> await _context.Users.AsNoTracking().AnyAsync(x => x.Email == email);
	}
}
