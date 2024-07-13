using System;
using AutoMapper;
using MySmartAgenda.Dtos;
using MySmartAgenda.Models;

namespace MySmartAgenda.Helper
{
	public class MappingProfile:Profile
	{
		public MappingProfile()
		{
			CreateMap<User,UserDTO>();
		}
	}
}

