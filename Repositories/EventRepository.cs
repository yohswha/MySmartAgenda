using System;
using MySmartAgenda.Data;
using MySmartAgenda.Interfaces;
using MySmartAgenda.Models;

namespace MySmartAgenda.Repositories
{
	public class EventRepository:IEventRepository
	{
        private readonly DataContext _context;

        public EventRepository(DataContext context)
		{
            _context = context;
        }

        public Events DeleteUser(int Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Events> GetEvents()
        {
            return _context.Events.OrderBy(e => e.id).ToList();
        }

        public Events GetSingleEvent(int Id)
        {
            return _context.Events.Where(e => e.id == Id).FirstOrDefault();
        }

        public Events Put(int Id)
        {
            throw new NotImplementedException();
        }

        public Events UpdateUser(int Id)
        {
            throw new NotImplementedException();
        }
    }
}


