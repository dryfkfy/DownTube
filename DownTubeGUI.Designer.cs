
namespace DownTube
{
    partial class DownTubeGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownTubeGUI));
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.DTWatermark = new System.Windows.Forms.Label();
            this.DTVersion = new System.Windows.Forms.Label();
            this.TabController = new System.Windows.Forms.TabControl();
            this.DownloaderTab = new System.Windows.Forms.TabPage();
            this.AboutLink = new System.Windows.Forms.LinkLabel();
            this.WebsiteLink = new System.Windows.Forms.LinkLabel();
            this.DirectoryTab = new System.Windows.Forms.TabPage();
            this.LinkWatermark = new System.Windows.Forms.Label();
            this.VideoLinkData = new System.Windows.Forms.TextBox();
            this.PasteLinkButton = new System.Windows.Forms.Button();
            this.ClearDataButton = new System.Windows.Forms.Button();
            this.DivideComponentsLabel = new System.Windows.Forms.Label();
            this.SaveVideoWatermark = new System.Windows.Forms.Label();
            this.SaveVideoDirectoryData = new System.Windows.Forms.TextBox();
            this.SearchForDirectoryButton = new System.Windows.Forms.Button();
            this.YTVideoInfoWatermark = new System.Windows.Forms.Label();
            this.VideoInfoData = new System.Windows.Forms.TextBox();
            this.DownloadVideoButton = new System.Windows.Forms.Button();
            this.DownloadProgress = new System.Windows.Forms.ProgressBar();
            this.ConvertVideoWatermark = new System.Windows.Forms.Label();
            this.SelectMP3Format = new System.Windows.Forms.RadioButton();
            this.SelectMP4Format = new System.Windows.Forms.RadioButton();
            this.DownloadHistoryData = new System.Windows.Forms.ListBox();
            this.ClearHistoryButton = new System.Windows.Forms.Button();
            this.YourHistoryWatermark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.TabController.SuspendLayout();
            this.DownloaderTab.SuspendLayout();
            this.DirectoryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoImage
            // 
            this.LogoImage.Image = ((System.Drawing.Image)(resources.GetObject("LogoImage.Image")));
            this.LogoImage.Location = new System.Drawing.Point(12, 12);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(70, 64);
            this.LogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImage.TabIndex = 0;
            this.LogoImage.TabStop = false;
            // 
            // DTWatermark
            // 
            this.DTWatermark.AutoSize = true;
            this.DTWatermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTWatermark.Location = new System.Drawing.Point(88, 23);
            this.DTWatermark.Name = "DTWatermark";
            this.DTWatermark.Size = new System.Drawing.Size(115, 25);
            this.DTWatermark.TabIndex = 1;
            this.DTWatermark.Text = "DownTube";
            // 
            // DTVersion
            // 
            this.DTVersion.AutoSize = true;
            this.DTVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTVersion.Location = new System.Drawing.Point(90, 48);
            this.DTVersion.Name = "DTVersion";
            this.DTVersion.Size = new System.Drawing.Size(62, 18);
            this.DTVersion.TabIndex = 2;
            this.DTVersion.Text = "Version:";
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.DownloaderTab);
            this.TabController.Controls.Add(this.DirectoryTab);
            this.TabController.Location = new System.Drawing.Point(0, 86);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(560, 302);
            this.TabController.TabIndex = 3;
            // 
            // DownloaderTab
            // 
            this.DownloaderTab.Controls.Add(this.SelectMP4Format);
            this.DownloaderTab.Controls.Add(this.SelectMP3Format);
            this.DownloaderTab.Controls.Add(this.ConvertVideoWatermark);
            this.DownloaderTab.Controls.Add(this.DownloadProgress);
            this.DownloaderTab.Controls.Add(this.DownloadVideoButton);
            this.DownloaderTab.Controls.Add(this.VideoInfoData);
            this.DownloaderTab.Controls.Add(this.YTVideoInfoWatermark);
            this.DownloaderTab.Controls.Add(this.SearchForDirectoryButton);
            this.DownloaderTab.Controls.Add(this.SaveVideoDirectoryData);
            this.DownloaderTab.Controls.Add(this.SaveVideoWatermark);
            this.DownloaderTab.Controls.Add(this.DivideComponentsLabel);
            this.DownloaderTab.Controls.Add(this.ClearDataButton);
            this.DownloaderTab.Controls.Add(this.PasteLinkButton);
            this.DownloaderTab.Controls.Add(this.VideoLinkData);
            this.DownloaderTab.Controls.Add(this.LinkWatermark);
            this.DownloaderTab.Location = new System.Drawing.Point(4, 22);
            this.DownloaderTab.Name = "DownloaderTab";
            this.DownloaderTab.Padding = new System.Windows.Forms.Padding(3);
            this.DownloaderTab.Size = new System.Drawing.Size(552, 276);
            this.DownloaderTab.TabIndex = 0;
            this.DownloaderTab.Text = "Video Downloader";
            this.DownloaderTab.UseVisualStyleBackColor = true;
            // 
            // AboutLink
            // 
            this.AboutLink.AutoSize = true;
            this.AboutLink.Location = new System.Drawing.Point(459, 12);
            this.AboutLink.Name = "AboutLink";
            this.AboutLink.Size = new System.Drawing.Size(91, 13);
            this.AboutLink.TabIndex = 4;
            this.AboutLink.TabStop = true;
            this.AboutLink.Text = "About DownTube";
            this.AboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLink_LinkClicked);
            // 
            // WebsiteLink
            // 
            this.WebsiteLink.AutoSize = true;
            this.WebsiteLink.Location = new System.Drawing.Point(482, 32);
            this.WebsiteLink.Name = "WebsiteLink";
            this.WebsiteLink.Size = new System.Drawing.Size(68, 13);
            this.WebsiteLink.TabIndex = 5;
            this.WebsiteLink.TabStop = true;
            this.WebsiteLink.Text = "Visit Website";
            this.WebsiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebsiteLink_LinkClicked);
            // 
            // DirectoryTab
            // 
            this.DirectoryTab.Controls.Add(this.YourHistoryWatermark);
            this.DirectoryTab.Controls.Add(this.ClearHistoryButton);
            this.DirectoryTab.Controls.Add(this.DownloadHistoryData);
            this.DirectoryTab.Location = new System.Drawing.Point(4, 22);
            this.DirectoryTab.Name = "DirectoryTab";
            this.DirectoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.DirectoryTab.Size = new System.Drawing.Size(552, 276);
            this.DirectoryTab.TabIndex = 1;
            this.DirectoryTab.Text = "View Download Directory";
            this.DirectoryTab.UseVisualStyleBackColor = true;
            // 
            // LinkWatermark
            // 
            this.LinkWatermark.AutoSize = true;
            this.LinkWatermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkWatermark.Location = new System.Drawing.Point(11, 10);
            this.LinkWatermark.Name = "LinkWatermark";
            this.LinkWatermark.Size = new System.Drawing.Size(67, 15);
            this.LinkWatermark.TabIndex = 6;
            this.LinkWatermark.Text = "Video Link:";
            // 
            // VideoLinkData
            // 
            this.VideoLinkData.Location = new System.Drawing.Point(14, 28);
            this.VideoLinkData.Multiline = true;
            this.VideoLinkData.Name = "VideoLinkData";
            this.VideoLinkData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VideoLinkData.Size = new System.Drawing.Size(385, 61);
            this.VideoLinkData.TabIndex = 7;
            this.VideoLinkData.WordWrap = false;
            // 
            // PasteLinkButton
            // 
            this.PasteLinkButton.Location = new System.Drawing.Point(405, 28);
            this.PasteLinkButton.Name = "PasteLinkButton";
            this.PasteLinkButton.Size = new System.Drawing.Size(139, 28);
            this.PasteLinkButton.TabIndex = 8;
            this.PasteLinkButton.Text = "Paste From Clipboard";
            this.PasteLinkButton.UseVisualStyleBackColor = true;
            this.PasteLinkButton.Click += new System.EventHandler(this.PasteLinkButton_Click);
            // 
            // ClearDataButton
            // 
            this.ClearDataButton.Location = new System.Drawing.Point(405, 62);
            this.ClearDataButton.Name = "ClearDataButton";
            this.ClearDataButton.Size = new System.Drawing.Size(139, 28);
            this.ClearDataButton.TabIndex = 9;
            this.ClearDataButton.Text = "Clear Link Content";
            this.ClearDataButton.UseVisualStyleBackColor = true;
            this.ClearDataButton.Click += new System.EventHandler(this.ClearDataButton_Click);
            // 
            // DivideComponentsLabel
            // 
            this.DivideComponentsLabel.AutoSize = true;
            this.DivideComponentsLabel.Location = new System.Drawing.Point(-45, 102);
            this.DivideComponentsLabel.Name = "DivideComponentsLabel";
            this.DivideComponentsLabel.Size = new System.Drawing.Size(829, 13);
            this.DivideComponentsLabel.TabIndex = 10;
            this.DivideComponentsLabel.Text = "_________________________________________________________________________________" +
    "________________________________________________________";
            // 
            // SaveVideoWatermark
            // 
            this.SaveVideoWatermark.AutoSize = true;
            this.SaveVideoWatermark.Location = new System.Drawing.Point(9, 143);
            this.SaveVideoWatermark.Name = "SaveVideoWatermark";
            this.SaveVideoWatermark.Size = new System.Drawing.Size(81, 13);
            this.SaveVideoWatermark.TabIndex = 11;
            this.SaveVideoWatermark.Text = "Save Video To:";
            // 
            // SaveVideoDirectoryData
            // 
            this.SaveVideoDirectoryData.Location = new System.Drawing.Point(97, 140);
            this.SaveVideoDirectoryData.Name = "SaveVideoDirectoryData";
            this.SaveVideoDirectoryData.Size = new System.Drawing.Size(394, 20);
            this.SaveVideoDirectoryData.TabIndex = 12;
            // 
            // SearchForDirectoryButton
            // 
            this.SearchForDirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForDirectoryButton.Location = new System.Drawing.Point(497, 134);
            this.SearchForDirectoryButton.Name = "SearchForDirectoryButton";
            this.SearchForDirectoryButton.Size = new System.Drawing.Size(45, 30);
            this.SearchForDirectoryButton.TabIndex = 13;
            this.SearchForDirectoryButton.Text = "🔍";
            this.SearchForDirectoryButton.UseVisualStyleBackColor = true;
            this.SearchForDirectoryButton.Click += new System.EventHandler(this.SearchForDirectoryButton_Click);
            // 
            // YTVideoInfoWatermark
            // 
            this.YTVideoInfoWatermark.AutoSize = true;
            this.YTVideoInfoWatermark.Location = new System.Drawing.Point(11, 177);
            this.YTVideoInfoWatermark.Name = "YTVideoInfoWatermark";
            this.YTVideoInfoWatermark.Size = new System.Drawing.Size(139, 13);
            this.YTVideoInfoWatermark.TabIndex = 14;
            this.YTVideoInfoWatermark.Text = "YouTube Video Information:";
            // 
            // VideoInfoData
            // 
            this.VideoInfoData.Location = new System.Drawing.Point(156, 174);
            this.VideoInfoData.Name = "VideoInfoData";
            this.VideoInfoData.ReadOnly = true;
            this.VideoInfoData.Size = new System.Drawing.Size(386, 20);
            this.VideoInfoData.TabIndex = 15;
            // 
            // DownloadVideoButton
            // 
            this.DownloadVideoButton.Location = new System.Drawing.Point(6, 241);
            this.DownloadVideoButton.Name = "DownloadVideoButton";
            this.DownloadVideoButton.Size = new System.Drawing.Size(222, 29);
            this.DownloadVideoButton.TabIndex = 16;
            this.DownloadVideoButton.Text = "Download YouTube Video";
            this.DownloadVideoButton.UseVisualStyleBackColor = true;
            this.DownloadVideoButton.Click += new System.EventHandler(this.DownloadVideoButton_Click);
            // 
            // DownloadProgress
            // 
            this.DownloadProgress.Location = new System.Drawing.Point(234, 241);
            this.DownloadProgress.Name = "DownloadProgress";
            this.DownloadProgress.Size = new System.Drawing.Size(312, 29);
            this.DownloadProgress.TabIndex = 17;
            // 
            // ConvertVideoWatermark
            // 
            this.ConvertVideoWatermark.AutoSize = true;
            this.ConvertVideoWatermark.Location = new System.Drawing.Point(11, 208);
            this.ConvertVideoWatermark.Name = "ConvertVideoWatermark";
            this.ConvertVideoWatermark.Size = new System.Drawing.Size(93, 13);
            this.ConvertVideoWatermark.TabIndex = 18;
            this.ConvertVideoWatermark.Text = "Convert Video To:";
            // 
            // SelectMP3Format
            // 
            this.SelectMP3Format.AutoSize = true;
            this.SelectMP3Format.Location = new System.Drawing.Point(156, 206);
            this.SelectMP3Format.Name = "SelectMP3Format";
            this.SelectMP3Format.Size = new System.Drawing.Size(66, 17);
            this.SelectMP3Format.TabIndex = 19;
            this.SelectMP3Format.Text = "MP3 File";
            this.SelectMP3Format.UseVisualStyleBackColor = true;
            // 
            // SelectMP4Format
            // 
            this.SelectMP4Format.AutoSize = true;
            this.SelectMP4Format.Checked = true;
            this.SelectMP4Format.Location = new System.Drawing.Point(234, 206);
            this.SelectMP4Format.Name = "SelectMP4Format";
            this.SelectMP4Format.Size = new System.Drawing.Size(66, 17);
            this.SelectMP4Format.TabIndex = 20;
            this.SelectMP4Format.TabStop = true;
            this.SelectMP4Format.Text = "MP4 File";
            this.SelectMP4Format.UseVisualStyleBackColor = true;
            // 
            // DownloadHistoryData
            // 
            this.DownloadHistoryData.FormattingEnabled = true;
            this.DownloadHistoryData.Location = new System.Drawing.Point(8, 35);
            this.DownloadHistoryData.Name = "DownloadHistoryData";
            this.DownloadHistoryData.Size = new System.Drawing.Size(536, 212);
            this.DownloadHistoryData.TabIndex = 0;
            // 
            // ClearHistoryButton
            // 
            this.ClearHistoryButton.Location = new System.Drawing.Point(8, 249);
            this.ClearHistoryButton.Name = "ClearHistoryButton";
            this.ClearHistoryButton.Size = new System.Drawing.Size(536, 23);
            this.ClearHistoryButton.TabIndex = 1;
            this.ClearHistoryButton.Text = "Clear Download History";
            this.ClearHistoryButton.UseVisualStyleBackColor = true;
            this.ClearHistoryButton.Click += new System.EventHandler(this.ClearHistoryButton_Click);
            // 
            // YourHistoryWatermark
            // 
            this.YourHistoryWatermark.AutoSize = true;
            this.YourHistoryWatermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourHistoryWatermark.Location = new System.Drawing.Point(8, 11);
            this.YourHistoryWatermark.Name = "YourHistoryWatermark";
            this.YourHistoryWatermark.Size = new System.Drawing.Size(168, 15);
            this.YourHistoryWatermark.TabIndex = 2;
            this.YourHistoryWatermark.Text = "Your Video Download History:";
            // 
            // DownTubeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 387);
            this.Controls.Add(this.WebsiteLink);
            this.Controls.Add(this.AboutLink);
            this.Controls.Add(this.TabController);
            this.Controls.Add(this.DTVersion);
            this.Controls.Add(this.DTWatermark);
            this.Controls.Add(this.LogoImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DownTubeGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DownTube";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownTubeGUI_FormClosing);
            this.Load += new System.EventHandler(this.DownTubeGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.TabController.ResumeLayout(false);
            this.DownloaderTab.ResumeLayout(false);
            this.DownloaderTab.PerformLayout();
            this.DirectoryTab.ResumeLayout(false);
            this.DirectoryTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoImage;
        private System.Windows.Forms.Label DTWatermark;
        private System.Windows.Forms.Label DTVersion;
        private System.Windows.Forms.TabControl TabController;
        private System.Windows.Forms.TabPage DownloaderTab;
        private System.Windows.Forms.TabPage DirectoryTab;
        private System.Windows.Forms.LinkLabel AboutLink;
        private System.Windows.Forms.LinkLabel WebsiteLink;
        private System.Windows.Forms.Button ClearDataButton;
        private System.Windows.Forms.Button PasteLinkButton;
        private System.Windows.Forms.TextBox VideoLinkData;
        private System.Windows.Forms.Label LinkWatermark;
        private System.Windows.Forms.Label DivideComponentsLabel;
        private System.Windows.Forms.TextBox VideoInfoData;
        private System.Windows.Forms.Label YTVideoInfoWatermark;
        private System.Windows.Forms.Button SearchForDirectoryButton;
        private System.Windows.Forms.TextBox SaveVideoDirectoryData;
        private System.Windows.Forms.Label SaveVideoWatermark;
        private System.Windows.Forms.RadioButton SelectMP4Format;
        private System.Windows.Forms.RadioButton SelectMP3Format;
        private System.Windows.Forms.Label ConvertVideoWatermark;
        private System.Windows.Forms.ProgressBar DownloadProgress;
        private System.Windows.Forms.Button DownloadVideoButton;
        private System.Windows.Forms.Label YourHistoryWatermark;
        private System.Windows.Forms.Button ClearHistoryButton;
        private System.Windows.Forms.ListBox DownloadHistoryData;
    }
}

