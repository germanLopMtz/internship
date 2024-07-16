using System;
using DATA.Entities;
using Domain.DTOs;

namespace DATA.Services
{
	public class ComputerService
	{
		public ComputerService()
		{
		}


		public ComputerOutputDTO Post(ComputerDTO dto)
		{
            Computer entity = new Computer(dto);
			//guardar a la base de datos

			return new ComputerOutputDTO
			{
				 Id = entity.Id,
				  Name = entity.Name,
				   Type = entity.Type,
				    CreationDate = entity.CreationDate,
					  IsActive = entity.IsActive,
					   MessageResponse ="Computer created!"
			};
        }
    }
}

