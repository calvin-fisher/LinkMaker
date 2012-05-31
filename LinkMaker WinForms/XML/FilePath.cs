using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinkMaker.XML
{
    public class FilePath : Path
    {
        public const string ElementName = "file";

        public FilePath(XElement xml, LinkPackage root, IPathParent parent) : base(xml, root, parent) { }
    }
}
