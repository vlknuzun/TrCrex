using System;
using System.Collections.Generic;
using System.Text;

namespace TrCrexDeneme.Core.Entity
{
    public interface IEntity<T>
    {
       T Id { get; set; }
    }
}
