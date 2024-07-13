﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MySmartAgenda.Dtos
{
	public class UserDTO
	{
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}

