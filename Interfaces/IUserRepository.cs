using System;
using MySmartAgenda.Models;

namespace MySmartAgenda.Interfaces
{
	public interface IUserRepository
	{
		ICollection<User> GetUsers();
		User GetSingleUser(int Id);
		User Put( int Id)
		User UpdateUser( int Id);
		User DeleteUser(int Id);	
	}
}

