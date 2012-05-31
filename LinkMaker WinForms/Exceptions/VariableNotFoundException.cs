using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkMaker.Exceptions
{
    public class VariableNotFoundException : Exception
    {
        public string VariableName;
        public string PackageFileName;

        public VariableNotFoundException(string variableName, string packageFileName)
        {
            VariableName = variableName;
            PackageFileName = packageFileName;
        }

        public override string Message
        {
            get { return this.ToString(); }
        }

        public override string ToString()
        {
            return string.Format(
                "Could not find variable {0} in package file {1}.",
                VariableName,
                PackageFileName);
        }
    }
}
