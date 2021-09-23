using Altaliza.Data;
using Altaliza.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
        /// <summary>
        /// Busca todos os usuários cadastrados
        /// </summary>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        [ProducesResponseType(typeof(List<Personagem>), 200)]
        [HttpGet("")]
        public async Task<List<Personagem>> Get()
        {
            return await myDbContext.Personagems.ToListAsync();
        }
        /// <summary>
        /// Busca um usuário dado o id
        /// </summary>
        /// <param name="id">Id do usuário a buscar</param>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        [ProducesResponseType(typeof(Personagem), 200)]
        [HttpGet("{id}")]
        public async Task<Personagem> GetUserById(int id)
        {
            return await myDbContext.Personagems.FindAsync(id);
        }


        /// <summary>
        /// Busca um usuário pelo nome
        /// </summary>
        /// <param name="username">Nome do usuário para a busca</param>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        [ProducesResponseType(typeof(Personagem), 200)]
        [HttpGet("")]
        public async Task<Personagem> GetUserByName(string username)
        {
            return await myDbContext.Personagems.Where(user => user.Nome == username).FirstOrDefaultAsync();
        }
    }
}
