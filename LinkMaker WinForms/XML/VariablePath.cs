using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinkMaker.XML
{
    public class VariablePath : Path
    {
        public const string ElementName = "variable";

        public VariablePath(XElement xml, LinkPackage root, IPathParent parent) : base(xml, root, parent) { }

        public string VariableValue
        {
            get
            {
                var variable = LinkPackage.Variables.FirstOrDefault(x => x.Name == this.Name);
                if (variable == null)
                    throw new Exceptions.VariableNotFoundException(this.Name, LinkPackage.FileName);
                return variable.GetProcessedValue();
            }
        }

        public override string ToString()
        {
            var parentPath = Parent as Path;
            return string.Format("{0}{1}{2}",
                parentPath != null ? parentPath.ToString() : string.Empty,
                parentPath != null ? System.IO.Path.DirectorySeparatorChar.ToString() : string.Empty,
                this.VariableValue)
                .TrimEnd(System.IO.Path.DirectorySeparatorChar);
        }
    }
}
