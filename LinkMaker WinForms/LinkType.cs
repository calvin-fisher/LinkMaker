using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkMaker
{
    public enum LinkType
    {
        Undefined = 0,
        DirectoryJunction,
        SymbolicLink,
    }

    public static class LinkTypeExtensions
    {
        public static char ToChar(this LinkType linkType)
        {
            switch (linkType)
            {
                case LinkType.DirectoryJunction:
                    return 'J';

                case LinkType.SymbolicLink:
                    return 'S';

                default:
                case LinkType.Undefined:
                    return '?';
            }
        }

        public static string ToString(this LinkType linkType)
        {
            switch (linkType)
            {
                case LinkType.DirectoryJunction:
                    return "Directory Junction";

                case LinkType.SymbolicLink:
                    return "Symbolic Link";

                default:
                case LinkType.Undefined:
                    return "????????";
            }
        }
    }
}
