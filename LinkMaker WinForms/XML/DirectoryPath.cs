using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinkMaker.XML
{
    public class DirectoryPath : Path
    {
        public const string ElementName =  "directory";

        public DirectoryPath(XElement xml, LinkPackage root, IPathParent parent) : base(xml, root, parent) { }
    }
}
