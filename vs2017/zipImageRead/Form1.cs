using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zipImageRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] files;
        string zipFilePath;
        int fileIndex = 0;
        private void button_openZipFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ZIP|*.zip";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            zipFilePath = ofd.FileName;
            files = ZipFileReader.ReadFilesFromZip(zipFilePath, ".jpg");
            
            LoadFile();
        }

        private void LoadFile()
        {
            if (files.Length < 1 || fileIndex >= files.Length) return;
            string filename = files[fileIndex];
            Bitmap bitmap = ZipFileReader.ReadImageFromZip(zipFilePath,filename);

            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = bitmap;
            label_Filename.Text = Path.GetFileNameWithoutExtension(filename);

            button_Prev.Enabled = fileIndex > 0; 
            button_Next.Enabled = fileIndex < files.Length - 1;

        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (files != null && fileIndex < files.Length - 1)
            {
                fileIndex++;
                LoadFile(); 

            }
        }

        private void button_Prev_Click(object sender, EventArgs e)
        {
            if (files != null && fileIndex > 0)
            {
                fileIndex--;
                LoadFile(); 
            }
        }
    }
}
