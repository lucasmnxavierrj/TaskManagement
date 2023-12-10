using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
	public class UserService : BaseService<User>
	{
		private readonly IUserRepository _userRepository;
		public UserService(IUserRepository userRepository) : base(userRepository)
		{
			_userRepository = userRepository;
		}
	}
}
