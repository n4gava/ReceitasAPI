using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Receitas.Framework.Entities
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public long? ID { get; set; }
    }
}
