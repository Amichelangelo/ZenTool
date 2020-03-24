using System;
using System.Collections.Generic;
using System.Text;

namespace ZenTool.Domain.Entity
{
    public interface IEntity<TKey>
    {
        TKey Id { get; }
    }
}
