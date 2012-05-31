using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace LinkMaker.Win32
{
    public static class SymbolicLink
    {
        public enum DwFlags
        {
            SYMLINK_FLAG_FILE = 0,
            SYMLINK_FLAG_DIRECTORY = 1
        }

        public static bool CreateSymbolicLink(string linkFileName, string targetFileName, DwFlags dwFlags)
        {
            return CreateSymbolicLink(linkFileName, targetFileName, (int) dwFlags);
        }

        [DllImport("kernel32.dll")]
        static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, int dwFlags);
    }
}
