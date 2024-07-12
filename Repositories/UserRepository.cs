using System;
using MySmartAgenda.Data;
using MySmartAgenda.Interfaces;
using MySmartAgenda.Models;

namespace MySmartAgenda.Repositories
{
	public class UserRepository:IUserRepository
	{
        private readonly DataContext _context;

        public UserRepository(DataContext context)
		{
            _context = context;
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.OrderBy(u =>u.Id).ToList();
        }
    }
}

