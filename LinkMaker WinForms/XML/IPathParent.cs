using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkMaker.XML
{
    public interface IPathParent
    {
        IEnumerable<Path> Paths { get; }
    }
}
