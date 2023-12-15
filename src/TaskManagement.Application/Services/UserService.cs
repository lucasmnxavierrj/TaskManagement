using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Application.InputModels;
using TaskManagement.Application.Models;
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

		public async Task<ProcessResponse> TryAddNewUser(User usuario)
		{
			bool isUserCadastrado = await IsUserCadastrado(usuario.Email);

			if (isUserCadastrado)
				return new ProcessResponse { Success = false, Message = "Já existe usuário cadastrado com este e-mail e/ou usuário." };

			try
			{
				await AddAsync(usuario);

				Commit();
			}
			catch (Exception ex)
			{
				return new ProcessResponse { Success = false, Message = "Houveram problemas no momento do cadastro do usuário. Tente novamente mais tarde." };
			}

			return new ProcessResponse { Success = true, Message = "Usuário cadastrado com sucesso! 🥳" };

		}

		public async Task<bool> IsUserCadastrado(string email)
			=> await _userRepository.IsUserCadastradoByEmail(email);
	}
}
