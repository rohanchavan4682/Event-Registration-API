﻿using System.ComponentModel.DataAnnotations;

namespace EventTicketingSystem.API.DTOs
{
    public class BookTicketDto
    {
        [Required]
        [EmailAddress]
        public string AttendeeEmail { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string EventTitle { get; set; }
    }
}
