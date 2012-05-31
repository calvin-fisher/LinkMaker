using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinkMaker.XML
{
    public abstract class Path : IPathParent
    {
        public const string ContainerElementName = "paths";

        #region Constructor/Factory

        protected Path(XElement xml, LinkPackage root, IPathParent parent)
        {
            LinkPackage = root;
            Parent = parent;

            Name = xml.AttributeValueOrDefault("name");
            Id = xml.AttributeValueOrDefault("id");

            Paths = xml.Elements().Select(x => Path.Construct(x, root, this)).ToArray();
        }

        public static Path Construct(XElement xml, LinkPackage root, IPathParent parent)
        {
            var name = xml.Name.ToString();
            switch (name)
            {
                case VariablePath.ElementName:
                    return new VariablePath(xml, root, parent);
                
                case DirectoryPath.ElementName:
                    return new DirectoryPath(xml, root, parent);

                case FilePath.ElementName:
                    return new FilePath(xml, root, parent);

                default:
                    throw new ArgumentException("Unknown Path element: " + xml);
            }
        }

        #endregion

        #region XML Attributes

        public string Name { get; protected set; }

        public string Id { get; protected set; }

        #endregion

        #region Relational Properties

        public LinkPackage LinkPackage { get; protected set; }
        
        public IPathParent Parent { get; protected set; }

        public IEnumerable<Path> Paths { get; protected set; }

        #endregion

        public virtual bool Exists
        {
             get { return (File.Exists(this) || Directory.Exists(this)); }
        }

        public void BackUpExisting()
        {
            Files.MakeBackup(this.ToString());
        }

        #region Conversion Methods

        public override string ToString()
        {
            var parentPath = Parent as Path;
            return string.Format("{0}{1}{2}",
                parentPath != null ? parentPath.ToString() : string.Empty,
                parentPath != null ? System.IO.Path.DirectorySeparatorChar.ToString() : string.Empty,
                this.Name)
                .TrimEnd(System.IO.Path.DirectorySeparatorChar);
        }

        public FileInfo ToFileInfo()
        {
            return new FileInfo(this.ToString());
        }

        public DirectoryInfo ToDirectoryInfo()
        {
            return new DirectoryInfo(this.ToString());
        }

        #endregion

        public static implicit operator string (Path path)
        {
            return path.ToString();
        }
    }
}
