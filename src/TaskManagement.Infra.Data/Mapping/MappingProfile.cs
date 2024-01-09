using AutoMapper;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.MVC.AutoMapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<User,IRegisterInputModel>().ReverseMap();
			CreateMap<User, ILoginInputModel>().ReverseMap();

		}
	}
}
