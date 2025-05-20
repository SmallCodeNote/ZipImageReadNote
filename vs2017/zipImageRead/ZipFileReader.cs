using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace zipImageRead
{
    class ZipFileReader
    {
        public static string[] ReadFilesFromZip(string zipFilePath)
        {
            List<string> fileList = new List<string>();

            using (FileStream zipStream = new FileStream(zipFilePath, FileMode.Open, FileAccess.Read))
            using (ZipArchive archive = new ZipArchive(zipStream, ZipArchiveMode.Read))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    fileList.Add(entry.FullName);
                }
            }

            return fileList.ToArray();
        }

        public static string[] ReadFilesFromZip(string zipFilePath, string extension)
        {
            if (!extension.StartsWith("."))
            {
                extension = "." + extension;
            }

            List<string> filteredFiles = new List<string>();

            using (FileStream zipStream = new FileStream(zipFilePath, FileMode.Open, FileAccess.Read))
            using (ZipArchive archive = new ZipArchive(zipStream, ZipArchiveMode.Read))
            {
                filteredFiles = archive.Entries
                                       .Where(entry => entry.FullName.EndsWith(extension, StringComparison.OrdinalIgnoreCase))
                                       .Select(entry => entry.FullName)
                                       .ToList();
            }

            filteredFiles.Sort();
            return filteredFiles.ToArray();

        }

        public static Bitmap ReadImageFromZip(string zipFilePath, string imageFileName)
        {
            using (FileStream zipStream = new FileStream(zipFilePath, FileMode.Open))
            using (ZipArchive archive = new ZipArchive(zipStream, ZipArchiveMode.Read))
            {
                ZipArchiveEntry entry = archive.GetEntry(imageFileName);
                if (entry != null)
                {
                    using (Stream imageStream = entry.Open())
                    {
                        return new Bitmap(imageStream);
                    }
                }
            }
            throw new FileNotFoundException($"file not found in zip ... '{imageFileName}' ");
        }

    }
}
