using Altaliza.Data;
using Altaliza.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Altaliza.API.Controllers
{
    [Route("api/personagem")]
    [ApiController]
    public class PersonagemController : ControllerBase
    {
        private DefaultContext myDbContext;

        public PersonagemController(DefaultContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public string Get()
        {
            return ("Hello World");
        }
    }
}
