using Receitas.Framework.Entities;
using System.ComponentModel.DataAnnotations;

namespace Receitas.WebAPI.Entities
{
    public class PassoPreparo : BaseEntity
    {
        [MaxLength(255)]
        public string Descricao { get; set; }
    }
}