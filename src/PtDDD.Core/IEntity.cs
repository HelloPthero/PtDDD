using System;
using System.Collections.Generic;
using System.Text;

namespace PtDDD.Domain
{

    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
