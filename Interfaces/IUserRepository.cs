using System;
using MySmartAgenda.Models;

namespace MySmartAgenda.Interfaces
{
	public interface IUserRepository
	{
		ICollection<User> GetUsers();
		
	}
}

