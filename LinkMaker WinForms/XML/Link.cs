using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using LinkMaker.Win32;

namespace LinkMaker.XML
{
    public class Link
    {
        public const string ElementName = "link";
        public const string ContainerElementName = "links";

        #region Constructor/Factory

        public Link(XElement xml, LinkPackage linkPackage)
        {
            LinkId = xml.AttributeValueOrDefault("link-id");
            TargetId = xml.AttributeValueOrDefault("target-id");
            LinkPackage = linkPackage;
        }

        #endregion

        #region XML Attributes

        public string LinkId { get; protected set; }

        public string TargetId { get; protected set; }

        #endregion

        #region Calculated Properties
        
        public Path LinkPath
        {
            get
            {
                return LinkPackage.FindPathById(LinkId);
            }
        }

        public Path TargetPath
        {
            get
            {
                return LinkPackage.FindPathById(TargetId);
            }
        }

        private LinkType _linkType = LinkType.Undefined;
        public LinkType LinkType
        {
            get
            {
                if (_linkType == LinkType.Undefined)
                {
                    if (LinkPath is DirectoryPath)
                        _linkType = LinkType.DirectoryJunction;

                    if (LinkPath is FilePath)
                        _linkType = LinkType.SymbolicLink;

                    var target = TargetPath.ToString();
                    if (File.Exists(TargetPath.ToString()) || Directory.Exists(TargetPath.ToString()))
                    {
                        var targetAttributes = File.GetAttributes(target);
                        if ((targetAttributes & FileAttributes.Directory) == FileAttributes.Directory)
                            _linkType = LinkType.DirectoryJunction;
                        else
                            _linkType = LinkType.SymbolicLink;
                    }
                }
                return _linkType;
            }
        }

        #endregion

        #region Relational Properties

        public LinkPackage LinkPackage { get; protected set; }

        #endregion

        public void MakeLink()
        {
            LinkPath.BackUpExisting();

            LinkPath.ToFileInfo().EnsureParentExists();

            switch (LinkType)
            {
                case LinkType.DirectoryJunction:
                    JunctionPoint.Create(LinkPath.ToString(), TargetPath.ToString(), false);
                    break;

                case LinkType.SymbolicLink:
                    SymbolicLink.CreateSymbolicLink(LinkPath.ToString(), TargetPath.ToString(), SymbolicLink.DwFlags.SYMLINK_FLAG_FILE);
                    break;

                default:
                    throw new ArgumentException("Unknown link type.");
            }
        }

        public override string ToString()
        {
            return String.Format(
                "[{1}] --{2}--> {0}",
                this.LinkPath,
                this.TargetPath,
                LinkType.ToChar()
                );
        }
    }
}
