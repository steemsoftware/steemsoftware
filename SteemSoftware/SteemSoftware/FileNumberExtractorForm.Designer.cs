﻿// <copyright file="FileNumberExtractorForm.Designer.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
// <auto-generated />
namespace SteemSoftware
{
    partial class FileNumberExtractorForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
        private System.Windows.Forms.FolderBrowserDialog mainFolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label suffixLabel;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TextBox suffixTextBox;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.Button browseForFolderButton;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileNumberExtractorForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fileLabel = new System.Windows.Forms.Label();
            this.suffixLabel = new System.Windows.Forms.Label();
            this.folderLabel = new System.Windows.Forms.Label();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.browseForFolderButton = new System.Windows.Forms.Button();
            this.suffixTextBox = new System.Windows.Forms.TextBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.fileToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.mainMenuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.newToolStripMenuItem,
                                    this.openToolStripMenuItem,
                                    this.toolStripSeparator,
                                    this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OnOpenToolStripMenuItemClick);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
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
                                    this.statusToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 172);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(284, 22);
            this.mainStatusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.statusToolStripStatusLabel.Name = "statusToolStripStatusLabel";
            this.statusToolStripStatusLabel.Size = new System.Drawing.Size(130, 17);
            this.statusToolStripStatusLabel.Text = "Browse for file or folder";
            // 
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.DefaultExt = "txt";
            this.mainOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            this.mainOpenFileDialog.Multiselect = true;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.mainTableLayoutPanel.Controls.Add(this.fileLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.suffixLabel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.folderLabel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.extensionLabel, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.openFileButton, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.browseForFolderButton, 1, 2);
            this.mainTableLayoutPanel.Controls.Add(this.suffixTextBox, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.extensionTextBox, 1, 3);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(284, 148);
            this.mainTableLayoutPanel.TabIndex = 3;
            // 
            // fileLabel
            // 
            this.fileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.Location = new System.Drawing.Point(3, 0);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(88, 37);
            this.fileLabel.TabIndex = 0;
            this.fileLabel.Text = "&File(s)";
            this.fileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suffixLabel
            // 
            this.suffixLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suffixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suffixLabel.Location = new System.Drawing.Point(3, 37);
            this.suffixLabel.Name = "suffixLabel";
            this.suffixLabel.Size = new System.Drawing.Size(88, 37);
            this.suffixLabel.TabIndex = 2;
            this.suffixLabel.Text = "&Suffix";
            this.suffixLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // folderLabel
            // 
            this.folderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderLabel.Location = new System.Drawing.Point(3, 74);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(88, 37);
            this.folderLabel.TabIndex = 4;
            this.folderLabel.Text = "&Folder";
            this.folderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // extensionLabel
            // 
            this.extensionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extensionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extensionLabel.Location = new System.Drawing.Point(3, 111);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(88, 37);
            this.extensionLabel.TabIndex = 6;
            this.extensionLabel.Text = "Extension(s)";
            this.extensionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileButton
            // 
            this.openFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openFileButton.Location = new System.Drawing.Point(97, 3);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(184, 31);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "&Open file(s)";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.OnOpenFileButtonClick);
            // 
            // browseForFolderButton
            // 
            this.browseForFolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseForFolderButton.Location = new System.Drawing.Point(97, 77);
            this.browseForFolderButton.Name = "browseForFolderButton";
            this.browseForFolderButton.Size = new System.Drawing.Size(184, 31);
            this.browseForFolderButton.TabIndex = 5;
            this.browseForFolderButton.Text = "&Browse for folder";
            this.browseForFolderButton.UseVisualStyleBackColor = true;
            this.browseForFolderButton.Click += new System.EventHandler(this.OnBrowseForFolderButtonClick);
            // 
            // suffixTextBox
            // 
            this.suffixTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.suffixTextBox.Location = new System.Drawing.Point(97, 45);
            this.suffixTextBox.Name = "suffixTextBox";
            this.suffixTextBox.Size = new System.Drawing.Size(184, 20);
            this.suffixTextBox.TabIndex = 3;
            this.suffixTextBox.Text = "_numbers";
            this.suffixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extensionTextBox.Location = new System.Drawing.Point(97, 114);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(184, 20);
            this.extensionTextBox.TabIndex = 7;
            this.extensionTextBox.Text = "txt,text";
            this.extensionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FileNumberExtractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "FileNumberExtractorForm";
            this.Text = "File Number Extractor";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}