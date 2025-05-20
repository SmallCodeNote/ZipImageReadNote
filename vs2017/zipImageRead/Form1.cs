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

        private ZipCacheReader zipContents;
        private int fileIndex = 0;
        private void button_openZipFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ZIP|*.zip";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            zipContents = new ZipCacheReader(ofd.FileName);
            LoadFile();
        }

        private void LoadFile()
        {
            if (zipContents.Files.Length < 1 || fileIndex >= zipContents.Files.Length) return;
            string filename = zipContents.Files[fileIndex];
            Bitmap bitmap = zipContents.ReadImage(filename);

            if (bitmap == null) return;

            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = bitmap;
            label_Filename.Text = filename;

            button_Prev.Enabled = fileIndex > 0; 
            button_Next.Enabled = fileIndex < zipContents.Files.Length - 1;

        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (zipContents.Files != null && fileIndex < zipContents.Files.Length - 1)
            {
                fileIndex++;
                LoadFile(); 

            }
        }

        private void button_Prev_Click(object sender, EventArgs e)
        {
            if (zipContents.Files != null && fileIndex > 0)
            {
                fileIndex--;
                LoadFile(); 
            }
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            zipContents.Dispose();
        }
    }
}
