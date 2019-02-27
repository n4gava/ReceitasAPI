using Microsoft.AspNet.OData.Builder;
using Receitas.Framework.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Receitas.WebAPI.Entities
{
    public class Receita : BaseEntity
    {
        [MaxLength(255)]
        [Required]
        public string Nome { get; set; }

        [Range(1,9999)]
        [Required]
        public int TempoPreparo { get; set; }

        [Range(1, 9999)]
        [Required]
        public int Porcoes { get; set; }

        [AutoExpand]
        public List<Ingrediente> Ingredientes { get; set; }

        [AutoExpand]
        public List<PassoPreparo> ModoPreparo { get; set; }
        
    }
}
