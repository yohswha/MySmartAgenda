using System;
namespace MySmartAgenda.Models
{
	public class Events
	{
		
		public int id { get; set; }
		//public int UserId { get; set; }
		public string? Comment { get; set; }
		public DateTime EventDate { get; set; }
        public DateTime CurrentDate { get; set; }
        public ICollection<UserEvent>? UserEvents{ get; set; }

       
    }
}

