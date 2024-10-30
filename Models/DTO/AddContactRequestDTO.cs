﻿namespace Contactly.Models.DTO
{
    public class AddContactRequestDTO
    {
        public required string Name { get; set; }

        public string? Email { get; set; }

        public string Phone { get; set; }

        public bool Favorite { get; set; }
    }
}
