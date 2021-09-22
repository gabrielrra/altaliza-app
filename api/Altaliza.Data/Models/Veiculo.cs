using System;
using System.Collections.Generic;

#nullable disable

namespace Altaliza.Data.Models
{
    public partial class Veiculo
    {
        public Veiculo()
        {
            PersonagemVeiculos = new HashSet<PersonagemVeiculo>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int CategoriaId { get; set; }
        public int Estoque { get; set; }
        public string Imagem { get; set; }
        public decimal Preco1Dia { get; set; }
        public decimal Preco7Dia { get; set; }
        public decimal Preco15Dia { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<PersonagemVeiculo> PersonagemVeiculos { get; set; }
    }
}
