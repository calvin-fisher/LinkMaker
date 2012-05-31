using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using LinkMaker.Win32;

namespace LinkMaker
{
    public static class Files
    {
        public static void EnsureParentExists(this FileInfo file)
        {
            EnsureParentExists(file.Directory);
        }

        public static void EnsureParentExists(this DirectoryInfo directory)
        {
            if (directory.Parent != null)
                EnsureParentExists(directory.Parent);

            if (!directory.Exists)
                directory.Create();
        }

        public static void MakeBackup(string path)
        {
            if (string.IsNullOrEmpty(path))
                return;

            if (File.Exists(path) || Directory.Exists(path))
            {
                var linkAttributes = File.GetAttributes(path);
                if ((linkAttributes & FileAttributes.Directory) == FileAttributes.Directory)
                    Directory.Move(path, path + "_" + DateTime.Now.Ticks);
                else
                    File.Move(path, path + "_" + DateTime.Now.Ticks);
            }
        }

        public static void MakeLink(string linkPath, string targetPath)
        {
            // back up anything already at destination
            MakeBackup(linkPath);

            // create junction for directory, symlink for file
            var targetAttributes = File.GetAttributes(targetPath);
            if ((targetAttributes & FileAttributes.Directory) == FileAttributes.Directory)
                JunctionPoint.Create(linkPath, targetPath, false);
            else
                SymbolicLink.CreateSymbolicLink(linkPath, targetPath, SymbolicLink.DwFlags.SYMLINK_FLAG_FILE);
        }
    }
}
