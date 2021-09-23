using Altaliza.Data;
using Altaliza.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace Altaliza.API.Controllers
{
    [Route("api/veiculo")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private DefaultContext myDbContext;

        public VeiculoController(DefaultContext context)
        {
            myDbContext = context;
        }
        /// <summary>
        /// Busca todos os veículos cadastrados
        /// </summary>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        [ProducesResponseType(typeof(List<Veiculo>), 200)]
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Veiculo>>> Get()
        {
            var veiculoList = await myDbContext.Veiculos.Select(o => new Veiculo
            {
                Id = o.Id,
                Nome = o.Nome,
                CategoriaId = o.CategoriaId,
                Estoque = o.Estoque,
                Imagem = o.Imagem,
                Preco1Dia = o.Preco1Dia,
                Preco7Dia = o.Preco7Dia,
                Preco15Dia = o.Preco15Dia,
                Categoria = o.Categoria,
            }).ToListAsync();

            return veiculoList;
        }
        /// <summary>
        /// Busca um veículo dado o id
        /// </summary>
        /// <param name="id">Id do veículo a buscar</param>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        [ProducesResponseType(typeof(Personagem), 200)]
        [HttpGet("{id}")]
        public Veiculo GetSingle(int id)
        {
            return myDbContext.Veiculos
                .Include(veiculo => veiculo.Categoria)
                .Where(v => v.Id == id)
                .FirstOrDefault();
        }
    }
}
