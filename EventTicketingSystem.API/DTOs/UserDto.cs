﻿using System.ComponentModel.DataAnnotations;

namespace EventTicketingSystem.API.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string UserName { get;set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get;set; }
    }
}
