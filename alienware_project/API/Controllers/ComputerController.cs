using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DATA.Entities;
using DATA.Services;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ComputerController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] ComputerDTO dto)
        {
            ComputerService service = new ComputerService();
            var response = service.Post(dto);
            return StatusCode(200, response);
        }
    }
}

