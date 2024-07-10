using System;
using System.ComponentModel.DataAnnotations;

namespace MySmartAgenda.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateOnly DayOfBirth { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public int EventId { get; set; }
        public ICollection<UserEvent> UserEvents { get; set; }
    }
}

