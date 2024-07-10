using System;
namespace MySmartAgenda.Models
{
	public class UserEvent
	{
		public int UserId { get; set; }
        public int EventID { get; set; }
        public User User { get; set; }
		public Events Events { get; set; }
	}
}

