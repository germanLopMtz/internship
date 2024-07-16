using System;
using Domain.DTOs;
using Domain.Enums;

namespace DATA.Entities
{
	public class Computer
	{
		public Computer(ComputerDTO dto)
		{
			Id = Guid.NewGuid().ToString();

			Name = dto.Name;
			Type = dto.Type;

			CreationDate = DateTime.Now;
			IsActive = false;
		}

		public string Id { get; set; }
		public string Name { get; set; }
		public ComputerType Type { get; set; }

		public DateTime CreationDate { get; set; }
		public bool IsActive { get; set; }
	}
}

