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
        public static string[] GetFileListFromZip(string zipFilePath)
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

        public static string[] GetFileListFromZip(string zipFilePath, string extension)
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
                                       .OrderBy(entry => entry)
                                       .ToList();
            }

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
            throw new FileNotFoundException($"File not found in zip ... '{imageFileName}' ");
        }

    }

    public class ZipCacheReader:IDisposable
    {
        private ZipArchive archive;
        public string[] Files;

        public ZipCacheReader(string zipFilePath)
        {
            MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(zipFilePath));
            archive = new ZipArchive(memoryStream, ZipArchiveMode.Read);
            Files = archive.Entries
                .Where(entry => Path.HasExtension(entry.FullName))
                .Select(entry => entry.FullName).OrderBy(entry => entry)
                .ToArray();
        }

        public Bitmap ReadImage(string imageFileName)
        {
            if (!IsValidImageFile(imageFileName))
            {
                return null; 
            }

            ZipArchiveEntry entry = archive.GetEntry(imageFileName);
            if (entry != null)
            {
                
                using (Stream imageStream = entry.Open())
                {
                    return new Bitmap(imageStream);
                }
            }
            throw new FileNotFoundException($"File not found in zip ... '{imageFileName}' ");
        }

        private readonly string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

        private bool IsValidImageFile(string fileName)
        {
            string extension = Path.GetExtension(fileName)?.ToLower();
            return Array.Exists(validExtensions, ext => ext == extension);
        }

        public void Dispose()
        {
           if(archive!=null) archive.Dispose();
        }
    }
}
