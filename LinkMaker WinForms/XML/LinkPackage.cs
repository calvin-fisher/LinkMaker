using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinkMaker.XML
{
    public class LinkPackage : IPathParent
    {
        public const string ElementName = "link-package";

        #region Constructor/Factory

        private LinkPackage(XElement xml, string fileName)
        {
            var variablesElement = xml.Element(Variable.ContainerElementName);
            if (variablesElement != null)
            {
                var variables = variablesElement.Elements(Variable.ElementName);
                Variables = variables.Select(x => new Variable(x, this)).ToArray();
            }
            else
            {
                Variables = new Variable[0];
            }

            var pathsElement = xml.Element(Path.ContainerElementName);
            if (pathsElement != null)
            {
                Paths = pathsElement.Elements().Select(x => Path.Construct(x, this, this)).ToArray();
            }
            else
            {
                throw new ArgumentException(Path.ContainerElementName + " element is not optional");
            }

            var linksElement = xml.Element(Link.ContainerElementName);
            if (linksElement != null)
            {
                var links = linksElement.Elements(Link.ElementName);
                Links = links.Select(x => new Link(x, this)).ToArray();
            }
            else
            {
                throw new ArgumentException(Link.ContainerElementName + " element is not optional");
            }

            FileName = fileName;
        }

        public static LinkPackage LoadFromFile(string fileName, Action<string> showErrorMessage = null)
        {
            try
            {
                var startTime = DateTime.Now.Ticks;
                Debug.WriteLine("Started loading LinkPackage at " + startTime);
                
                var doc = XDocument.Load(fileName);
                var root = doc.Root;
                if (root == null || root.Name != ElementName)
                    return null;
                var linkPackage = new LinkPackage(root, fileName);

                var endTime = DateTime.Now.Ticks;
                Debug.WriteLine(string.Format("Finished loading LinkPackage at {0} -- took {1}", endTime, endTime - startTime));
                return linkPackage;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception in LinkPackage.LoadFromFile");
                Debug.WriteLine(ex.ToString());

                if (showErrorMessage != null)
                    showErrorMessage(ex.Message);

                return null;
            }
        }

        #endregion

        #region Relational Properties

        public IEnumerable<Variable> Variables { get; protected set; }

        public IEnumerable<Path> Paths { get; protected set; }

        public IEnumerable<Link> Links { get; protected set; }

        #endregion

        public string FileName { get; protected set; }

        public void Implement()
        {
            foreach (var link in Links)
                link.MakeLink();
        }        

        public IEnumerable<Path> GetAllPaths()
        {
            return Paths.SelectMany(x => x.GetAllPaths());
        }

        public Path FindPathById(string id)
        {
            var path = GetAllPaths().FirstOrDefault(x => x.Id == id);
            if (path == null)
                throw new ArgumentException("Path ID not found: " + id);
            return path;
        }
    }
}
