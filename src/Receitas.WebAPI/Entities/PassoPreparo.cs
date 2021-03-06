﻿using Receitas.Framework.Entities;
using System.ComponentModel.DataAnnotations;

namespace Receitas.WebAPI.Entities
{
    public class PassoPreparo : BaseEntity
    {
        public Receita Receita { get; set; }

        [MaxLength(255)]
        [Required]
        public string Descricao { get; set; }
    }
}