using Receitas.Framework.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Receitas.WebAPI.Entities
{
    public class Receita : BaseEntity
    {
        [MaxLength(255)]
        public string Nome { get; set; }

        [MaxLength(3)]
        public int TempoPreparo { get; set; }

        [MaxLength(4)]
        public int Porcoes { get; set; }

        public List<Ingrediente> Ingredientes { get; set; }

        public List<PassoPreparo> ModoPreparo { get; set; }
        
    }
}
