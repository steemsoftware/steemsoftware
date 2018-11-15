﻿// <copyright file="YouTubeDownloaderForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SteemSoftware
{
    partial class CompressDirectoryForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompressDirectoryForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.progressToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.compressButton = new System.Windows.Forms.Button();
            this.targetLabel = new System.Windows.Forms.Label();
            this.expandLabel = new System.Windows.Forms.Label();
            this.expandButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressionLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noCompressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.fileToolStripMenuItem,
                                    this.optionsToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(310, 24);
            this.mainMenuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.browseToolStripMenuItem,
                                    this.openToolStripMenuItem,
                                    this.toolStripSeparator2,
                                    this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("browseToolStripMenuItem.Image")));
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.browseToolStripMenuItem.Text = "&Browse";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.OnBrowseToolStripMenuItemClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OnOpenToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.progressToolStripProgressBar,
                                    this.statusToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 120);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(310, 22);
            this.mainStatusStrip.TabIndex = 1;
            // 
            // progressToolStripProgressBar
            // 
            this.progressToolStripProgressBar.Name = "progressToolStripProgressBar";
            this.progressToolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // statusToolStripStatusLabel
            // 
            this.statusToolStripStatusLabel.Name = "statusToolStripStatusLabel";
            this.statusToolStripStatusLabel.Size = new System.Drawing.Size(57, 17);
            this.statusToolStripStatusLabel.Text = "Waiting...";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33555F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66445F));
            this.mainTableLayoutPanel.Controls.Add(this.compressButton, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.targetLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.expandLabel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.expandButton, 1, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(310, 96);
            this.mainTableLayoutPanel.TabIndex = 2;
            // 
            // compressButton
            // 
            this.compressButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressButton.Image = ((System.Drawing.Image)(resources.GetObject("compressButton.Image")));
            this.compressButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compressButton.Location = new System.Drawing.Point(106, 3);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(201, 42);
            this.compressButton.TabIndex = 0;
            this.compressButton.Text = "&Browse for folder";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.OnCompressButtonClick);
            // 
            // targetLabel
            // 
            this.targetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetLabel.Location = new System.Drawing.Point(3, 0);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(97, 48);
            this.targetLabel.TabIndex = 4;
            this.targetLabel.Text = "&Compress:";
            this.targetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expandLabel
            // 
            this.expandLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.expandLabel.Location = new System.Drawing.Point(3, 48);
            this.expandLabel.Name = "expandLabel";
            this.expandLabel.Size = new System.Drawing.Size(97, 48);
            this.expandLabel.TabIndex = 5;
            this.expandLabel.Text = "&Expand:";
            this.expandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expandButton
            // 
            this.expandButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.expandButton.Image = ((System.Drawing.Image)(resources.GetObject("expandButton.Image")));
            this.expandButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expandButton.Location = new System.Drawing.Point(106, 51);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(201, 42);
            this.expandButton.TabIndex = 6;
            this.expandButton.Text = "&Open zip file";
            this.expandButton.UseVisualStyleBackColor = true;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.compressionLevelToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // compressionLevelToolStripMenuItem
            // 
            this.compressionLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.fastestToolStripMenuItem,
                                    this.noCompressionToolStripMenuItem,
                                    this.optimalToolStripMenuItem});
            this.compressionLevelToolStripMenuItem.Name = "compressionLevelToolStripMenuItem";
            this.compressionLevelToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.compressionLevelToolStripMenuItem.Text = "&Compression level";
            this.compressionLevelToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnCompressionLevelToolStripMenuItemDropDownItemClicked);
            // 
            // fastestToolStripMenuItem
            // 
            this.fastestToolStripMenuItem.Name = "fastestToolStripMenuItem";
            this.fastestToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.fastestToolStripMenuItem.Text = "&Fastest";
            // 
            // noCompressionToolStripMenuItem
            // 
            this.noCompressionToolStripMenuItem.Name = "noCompressionToolStripMenuItem";
            this.noCompressionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.noCompressionToolStripMenuItem.Text = "&No compression";
            // 
            // optimalToolStripMenuItem
            // 
            this.optimalToolStripMenuItem.Checked = true;
            this.optimalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optimalToolStripMenuItem.Name = "optimalToolStripMenuItem";
            this.optimalToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.optimalToolStripMenuItem.Text = "&Optimal";
            // 
            // CompressDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 142);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "CompressDirectoryForm";
            this.Text = "Compress Directory";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem optimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noCompressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressionLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button expandButton;
        private System.Windows.Forms.Label expandLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressToolStripProgressBar;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.Button compressButton;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}