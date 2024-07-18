using System;
using MySmartAgenda.Models;

namespace MySmartAgenda.Interfaces
{
	public interface IEventRepository
	{
        ICollection<Events> GetEvents();
        Events GetSingleEvent(int Id);
        Events Put(int Id);
        Events UpdateUser(int Id);
        Events DeleteUser(int Id);
    }
}

