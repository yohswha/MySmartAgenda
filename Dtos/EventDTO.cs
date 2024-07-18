using System;
namespace MySmartAgenda.Dtos
{
	public class EventDTO
	{
        public int id { get; set; }
        public string? Comment { get; set; }
        public DateTime EventDate { get; set; }
    }
}

