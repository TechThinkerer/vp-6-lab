using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace lab_6_task_8
{
    public partial class Form1 : Form
    {
        private List<string> imageFiles;
        private int currentIndex;
        public Form1()
        {
            InitializeComponent();
            imageFiles = new List<string>();
            currentIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    LoadImages(selectedPath);
                    if (imageFiles.Count > 0)
                    {
                        currentIndex = 0;
                        DisplayImage(currentIndex);
                    }
                }
            }
        }
        private void LoadImages(string folderPath)
        {
            imageFiles.Clear();
            string[] supportedExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
            foreach (string file in Directory.GetFiles(folderPath))
            {
                if (Array.Exists(supportedExtensions, ext => file.EndsWith(ext, StringComparison.OrdinalIgnoreCase)))
                {
                    imageFiles.Add(file);
                }
            }
        }

        private void DisplayImage(int index)
        {
            if (index >= 0 && index < imageFiles.Count)
            {
                pictureBox1.Image = Image.FromFile(imageFiles[index]);
                label1.Text = Path.GetFileName(imageFiles[index]);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imageFiles.Count > 0)
            {
                currentIndex = (currentIndex + 1) % imageFiles.Count;
                DisplayImage(currentIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (imageFiles.Count > 0)
            {
                currentIndex = (currentIndex - 1 + imageFiles.Count) % imageFiles.Count; // Loop back to end
                DisplayImage(currentIndex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
