using System;
using System.Collections.Generic;
using System.Text;

namespace Receitas.Framework.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public long ID { get; set; }
    }
}
