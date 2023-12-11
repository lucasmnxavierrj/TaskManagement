using AutoMapper;
using TaskManagement.Application.InputModels;
using TaskManagement.Domain.Entities;

namespace TaskManagement.MVC.AutoMapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<User,RegisterInputModel>().ReverseMap();
		}
	}
}
