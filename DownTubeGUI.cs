// Down Tube
// By dryfkfy

// DownTube uses VideoLibrary or libvideo. It's license can be found here:
// https://github.com/omansak/libvideo/blob/master/LICENSE

// DownTube is licensed under the BSD 2-Clause license. It's license and
// GitHub repository can be found here:

//https://github.com/dryfkfy/DownTube

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using System.Threading;
using VideoLibrary.Exceptions;
using System.IO;
using System.Diagnostics;

namespace DownTube
{
    public partial class DownTubeGUI : Form
    {

        public DownTubeGUI()
        {
            InitializeComponent();
        }

        private void DownTubeGUI_Load(object sender, EventArgs e)
        {
            DownloadHistoryData.Items.Clear();
            DownloadProgress.Visible = false;
            DTVersion.Text = "Version: " + ProductVersion.ToString();
        }

        private void DownTubeGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to exit DownTube? This will result in all current downloads being removed!", "Exit DownTube?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(DialogResult == DialogResult.Yes)
            {
                GC.Collect();
                Thread.Sleep(250);
                Environment.Exit(1);
            }
            else
            {
                return;
            }
        }

        private void AboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("DownTube\nBy dryfkfy\n\nDownTube uses VideoLibrary or better known as libvideo. It's license can be found here: \n\nhttps://github.com/omansak/libvideo/blob/master/LICENSE\n\nDownTube is licensed under the BSD 2-Clause License which you can find in the GitHub repository here: \n\nhttps://github.com/dryfkfy/DownTube", "About DownTube", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("DownTube is in no way associated with YouTube, Google, or any product by them. This software is seperate from them and they don't own it and we don't own them.", "Legal Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WebsiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://github.com/dryfkfy/DownTube");
            }
            catch
            {
                return;
            }
        }

        private void PasteLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                VideoLinkData.Text = Clipboard.GetText();
                string VideoURL = VideoLinkData.Text.ToString();
                var YTDownload = YouTube.Default;
                var SelectVideo = YTDownload.GetVideo(VideoURL);
                string InfoOnVideo = SelectVideo.FullName.ToString();
                VideoInfoData.Text = InfoOnVideo.ToString();
                DownloadHistoryData.Items.Add(VideoURL.ToString());
            }
            catch
            {
                MessageBox.Show("The URL you have pasted is not a valid YouTube video URL! Make sure the URL is correct and a valid format and try again.", "Invalid YouTube URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VideoLinkData.Text = "";
                VideoInfoData.Text = "";
            }
        }

        private void ClearDataButton_Click(object sender, EventArgs e)
        {
            VideoLinkData.Text = "";
            VideoInfoData.Text = "";
        }

        private void SearchForDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = true;
            FBD.Description = "Select A Directory To Place Downloaded Video";
            if(FBD.ShowDialog() == DialogResult.OK)
            {
                SaveVideoDirectoryData.Text = @FBD.SelectedPath.ToString();
            }
            else
            {
                return;
            }
        }

        private void DownloadVideoButton_Click(object sender, EventArgs e)
        {
            try
            {
                VideoLinkData.Text = Clipboard.GetText();
                string VideoURL = VideoLinkData.Text.ToString();
                var YTDownload = YouTube.Default;
                var SelectVideo = YTDownload.GetVideo(VideoURL);
                string InfoOnVideo = SelectVideo.FullName.ToString();
                string InfoOnVideoNoExtension = SelectVideo.FullName.ToString();
                string CorrectStringNoExtension = InfoOnVideoNoExtension.Replace(".mp4", "");
                VideoInfoData.Text = InfoOnVideo.ToString();

                byte[] StreamByte = SelectVideo.GetBytes();
                var StreamData = SelectVideo.Stream();

                DownloadProgress.Visible = false;
                DownloadProgress.Style = ProgressBarStyle.Blocks;

                if(SelectMP4Format.Checked == true)
                {
                    File.WriteAllBytes(@SaveVideoDirectoryData.Text.ToString() + @"\" + InfoOnVideo.ToString(), StreamByte);
                }
                else
                {
                    File.WriteAllBytes(@SaveVideoDirectoryData.Text.ToString() + @"\" + InfoOnVideo.ToString(), StreamByte);
                    File.Move(@SaveVideoDirectoryData.Text.ToString() + @"\" + InfoOnVideo.ToString(), SaveVideoDirectoryData.Text.ToString() + @"\" + CorrectStringNoExtension.ToString() + ".mp3");
                }

                DownloadProgress.Visible = true;
                DownloadProgress.Value = 100;
                MessageBox.Show("Download has been completed! The video has been saved to: " + SaveVideoDirectoryData.Text.ToString(), "Download Completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DownloadProgress.Visible = false;
            }
            catch
            {
                MessageBox.Show("The URL you have selected is either invalid or you have not selected a directory to save the downloaded video. Make sure these settings are correct before downloading.", "Invalid Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VideoLinkData.Text = "";
                VideoInfoData.Text = "";
            }
        }

        private void ClearHistoryButton_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to clear you download history? You can always close the program to clear it later!", "Clear Download History?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(DialogResult == DialogResult.Yes)
            {
                DownloadHistoryData.Items.Clear();
            }
            else
            {
                return;
            }
        }
    }
}
