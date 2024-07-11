using System;
using MySmartAgenda.Data;
using MySmartAgenda.Models;

namespace MySmartAgenda
{

        public class Seed
        {
            private readonly DataContext dataContext;
            public Seed(DataContext context)
            {
                this.dataContext = context;
            }
            public void SeedDataContext()
            {
                if (!dataContext.UserEvents.Any())
            {
                var userEvent = new List<UserEvent>()
                {
                    new UserEvent()
                    {
                        User = new User()
                        {
                            Name = "Javier",
                            BirthDate = new DateTime(1903,1,1),
                            UserEvents = new List<UserEvent>()
                            {
                                new UserEvent {  Events= new Events()
                                {
                                    id = 1,
                                    Comment="d",
                                    EventDate= new DateTime(2023,1,1),
                                    CurrentDate=DateTime.Now
                                }
                            } 
                        },
                       
                    },
                   
                       
                    },
                    
                };

                    dataContext.UserEvents.AddRange(userEvent);
                    dataContext.SaveChanges();
        }
          
        }
    }
}

