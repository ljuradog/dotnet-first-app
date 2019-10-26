using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taller1.Models;

namespace Taller1.API.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json", "text/xml")]
    [ApiController]
    [FormatFilter]
    public class ContactController : ControllerBase
    {
        // GET: api/Contact
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Contact/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Contact
        [HttpPost]
        public object Post([FromBody] Contact model)
        {
            if (ModelState.IsValid)
            {
                return Ok(new { Result = "Enviado" });
            }
            else
            {
                return BadRequest(new { Result = "Error" });
            }
        }

        // PUT: api/Contact/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
