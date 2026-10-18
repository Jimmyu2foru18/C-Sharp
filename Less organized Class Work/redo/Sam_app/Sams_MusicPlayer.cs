using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SamsMusicPlayer
{
    public partial class Sams_MusicPlayer : Form
    {
        private string selectedFolder;
        private List<string> musicFiles;
        private List<string> imageFiles;

        public Sams_MusicPlayer()
        {
            InitializeComponent();
        }

        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    selectedFolder = folderDialog.SelectedPath;
                    LoadMusicAndImages(selectedFolder);
                }
            }
        }

        private void LoadMusicAndImages(string folderPath)
        {
            musicFiles = new List<string>();
            imageFiles = new List<string>();

            try
            {
                // Load music and image files from the selected folder
                foreach (string file in Directory.GetFiles(folderPath))
                {
                    if (IsAudioFile(file))
                    {
                        musicFiles.Add(file);
                    }
                    else if (IsImageFile(file))
                    {
                        imageFiles.Add(file);
                    }
                }

                // Display music file names in the list box
                lstMusicFiles.Items.Clear();
                foreach (string musicFile in musicFiles)
                {
                    _ = lstMusicFiles.Items.Add(Path.GetFileName(musicFile));
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error loading files: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsAudioFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            return extension == ".mp3" || extension == ".wav" || extension == ".ogg";
        }

        private bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif";
        }

        private void LstMusicFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMusicFiles.SelectedIndex >= 0 && lstMusicFiles.SelectedIndex < imageFiles.Count)
            {
                pictureBox1.ImageLocation = imageFiles[lstMusicFiles.SelectedIndex];
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (lstMusicFiles.SelectedIndex >= 0 && lstMusicFiles.SelectedIndex < musicFiles.Count)
            {
                string musicFile = musicFiles[lstMusicFiles.SelectedIndex];

                try
                {
                    // Open the selected music file with the default player
                    _ = Process.Start(musicFile);
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show("Error playing music: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _ = MessageBox.Show("Please select a music file to play.", "No Music Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
