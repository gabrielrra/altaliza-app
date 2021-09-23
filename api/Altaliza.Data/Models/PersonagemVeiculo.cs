using System;
using System.Collections.Generic;

#nullable disable

namespace Altaliza.Data.Models
{
    public partial class PersonagemVeiculo
    {
        public int Id { get; set; }
        public int PersonagemId { get; set; }
        public int VeiculoId { get; set; }
        public DateTime? DataExpiracao { get; set; }

        public virtual Personagem Personagem { get; set; }
        public virtual Veiculo Veiculo { get; set; }
    }
}
