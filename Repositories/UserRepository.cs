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
        public User GetSingleUser(int Id)
        {
            return _context.Users.Where(u1 => u1.Id == Id).FirstOrDefault();
        }

        public User GetUser(string Name)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetUsers()
        {

            return _context.Users.OrderBy(u => u.Id).ToList();
        }

        public User Put(int Id)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(int Id)
        {
            throw new NotImplementedException();
        }

        public User DeleteUser(int Id)
        {
            throw new NotImplementedException();
        }


    }
}

