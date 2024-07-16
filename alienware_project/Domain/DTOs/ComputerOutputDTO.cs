using System;
using Domain.Enums;

namespace Domain.DTOs
{
	public class ComputerOutputDTO
	{
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public ComputerType Type { get; set; }

        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }


        public string MessageResponse { get; set; } = string.Empty;
    }
}

