using System;
using System.Collections.Generic;

#nullable disable

namespace Altaliza.Data.Models
{
    public partial class Personagem
    {
        public Personagem()
        {
            PersonagemVeiculos = new HashSet<PersonagemVeiculo>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Carteira { get; set; }

        public virtual ICollection<PersonagemVeiculo> PersonagemVeiculos { get; set; }
    }
}
