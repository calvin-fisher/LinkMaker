using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinkMaker
{
    public static class ExtensionMethods
    {
        public static string AttributeValueOrDefault(this XElement xml, XName name)
        {
            var attribute = xml.Attribute(name);
            if (attribute == null)
                return null;

            return attribute.Value;
        }

        public static IEnumerable<XML.Path> GetAllPaths(this XML.Path startingPoint)
        {
            yield return startingPoint;
            foreach (var path in startingPoint.Paths)
                foreach (var subPath in GetAllPaths(path))
                    yield return subPath;
        }
    }
}
