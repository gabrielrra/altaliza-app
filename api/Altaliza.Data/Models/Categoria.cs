using System;
using System.Collections.Generic;

#nullable disable

namespace Altaliza.Data.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Veiculos = new HashSet<Veiculo>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Veiculo> Veiculos { get; set; }
    }
}
