using System;
using Domain.Enums;

namespace Domain.DTOs
{
	public class ComputerDTO
	{
        public string Name { get; set; } = string.Empty;
        public ComputerType Type { get; set; }
    }
}

