using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Application.Services;
using TaskManagement.Domain.Interfaces;
using TaskManagement.Infra.Data.Repositories;

namespace TaskManagement.Infra.IoC
{
	public static class ContainerDependencias
	{
		public static IServiceCollection RegisterServices(this IServiceCollection services)
		{
			// Repositórios
			services.AddScoped<IUserRepository,UserRepository>();

			// Application
			services.AddScoped<UserService>();

			return services;
		}

	}
}