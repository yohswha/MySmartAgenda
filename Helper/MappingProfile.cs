using System;
using AutoMapper;
using MySmartAgenda.Dtos;
using MySmartAgenda.Models;

namespace MySmartAgenda.Helper
{
	//This is an AutoMapper Class to map Classes and Dtos for security on sensitive data
	public class MappingProfile:Profile
	{
		public MappingProfile()
		{
			CreateMap<User,UserDTO>();
            CreateMap<Events, EventDTO>();

        }
    }
}

