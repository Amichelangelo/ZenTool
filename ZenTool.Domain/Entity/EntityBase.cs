using System;
using System.Collections.Generic;
using System.Text;

namespace ZenTool.Domain.Entity
{
    public class EntityBase : IEntity<long>
    {
        public long Id { get; }
    }
}
