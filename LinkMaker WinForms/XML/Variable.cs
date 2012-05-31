using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinkMaker.XML
{
    public class Variable
    {
        public const string ElementName = "variable";
        public const string ContainerElementName = "variables";

        #region Constructor/Factory

        public Variable(XElement xml, LinkPackage parent)
        {
            Parent = parent;

            Name = xml.AttributeValueOrDefault("name");
            DefaultValue = xml.AttributeValueOrDefault("default-value");
        }

        #endregion

        #region XML Attributes

        public string Name { get; protected set; }
        
        public string DefaultValue { get; protected set; }

        #endregion

        #region Calculated Properties

        private string _value;
        public string Value
        {
            get { return _value ?? DefaultValue; }
            set { _value = value; }
        }

        #endregion

        #region Relational Properties
        
        public LinkPackage Parent;
        
        public LinkPackage LinkPackage { get { return Parent; } }

        #endregion

        public string GetProcessedValue()
        {
            return Strings.ReplaceEnvironmentVariables(Value);
        }
    }
}
