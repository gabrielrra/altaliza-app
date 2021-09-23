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
        /// Busca um usuário cadastrado. Se nenhum usuário for informado a api buscará todos os usuários
        /// </summary>
        /// <param name="username">Nome do usuário para a busca</param>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        [ProducesResponseType(typeof(List<Personagem>), 200)]
        [HttpGet("")]
        public async Task<List<Personagem>> Get(string username)
        {
            if(username != "")
            {
                return await myDbContext.Personagems.Where(user => user.Nome == username).ToListAsync();
            } else
            {
                return await myDbContext.Personagems.ToListAsync();
            }
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
        /// Adiciona um novo usuário
        /// </summary>
        /// <param name="user">Novo usuário a ser adicionado</param>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        [ProducesResponseType(typeof(Personagem), 200)]
        [HttpPost("")]
        public async Task<Personagem> CreateUser(Personagem user)
        {

            try
            {
                myDbContext.Personagems.Add(user);
                myDbContext.SaveChanges();
                return await myDbContext.Personagems.Where(u => u.Nome == user.Nome).FirstOrDefaultAsync();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

    }
}
