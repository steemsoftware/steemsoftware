﻿// <copyright file="CompressByPatternForm.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
// <auto-generated />
namespace SteemSoftware
{
    partial class CompressByPatternForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompressByPatternForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressionLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noCompressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchSubdirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateIntoworkingDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateSinglezipFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.patternColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRegexColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.setWorkingDirectoryButton = new System.Windows.Forms.Button();
            this.compressByPatternButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.toolStripProgressBar,
                                    this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 240);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(310, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Visible = false;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabel.Text = "Enter pattern + target";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.fileToolStripMenuItem,
                                    this.optionsToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(310, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.newToolStripMenuItem,
                                    this.openToolStripMenuItem,
                                    this.toolStripSeparator,
                                    this.saveToolStripMenuItem,
                                    this.toolStripSeparator2,
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
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnSaveToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.compressionLevelToolStripMenuItem,
                                    this.searchSubdirectoriesToolStripMenuItem,
                                    this.generateIntoworkingDirectoryToolStripMenuItem,
                                    this.generateSinglezipFileToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
            // 
            // compressionLevelToolStripMenuItem
            // 
            this.compressionLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.fastestToolStripMenuItem,
                                    this.noCompressionToolStripMenuItem,
                                    this.optimalToolStripMenuItem});
            this.compressionLevelToolStripMenuItem.Name = "compressionLevelToolStripMenuItem";
            this.compressionLevelToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
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
            // searchSubdirectoriesToolStripMenuItem
            // 
            this.searchSubdirectoriesToolStripMenuItem.Checked = true;
            this.searchSubdirectoriesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchSubdirectoriesToolStripMenuItem.Name = "searchSubdirectoriesToolStripMenuItem";
            this.searchSubdirectoriesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.searchSubdirectoriesToolStripMenuItem.Text = "Search sub-directories";
            // 
            // generateIntoworkingDirectoryToolStripMenuItem
            // 
            this.generateIntoworkingDirectoryToolStripMenuItem.Checked = true;
            this.generateIntoworkingDirectoryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.generateIntoworkingDirectoryToolStripMenuItem.Name = "generateIntoworkingDirectoryToolStripMenuItem";
            this.generateIntoworkingDirectoryToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.generateIntoworkingDirectoryToolStripMenuItem.Text = "Generate into &working directory";
            // 
            // generateSinglezipFileToolStripMenuItem
            // 
            this.generateSinglezipFileToolStripMenuItem.Name = "generateSinglezipFileToolStripMenuItem";
            this.generateSinglezipFileToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.generateSinglezipFileToolStripMenuItem.Text = "Generate single &zip file";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.setWorkingDirectoryButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.compressByPatternButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 216);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                                    this.patternColumn,
                                    this.targetColumn,
                                    this.isRegexColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView, 3);
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 38);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(304, 140);
            this.dataGridView.TabIndex = 0;
            // 
            // patternColumn
            // 
            this.patternColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patternColumn.HeaderText = "Pattern";
            this.patternColumn.Name = "patternColumn";
            // 
            // targetColumn
            // 
            this.targetColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.targetColumn.HeaderText = "Target";
            this.targetColumn.Name = "targetColumn";
            // 
            // isRegexColumn
            // 
            this.isRegexColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isRegexColumn.FillWeight = 50F;
            this.isRegexColumn.HeaderText = "Regex";
            this.isRegexColumn.Name = "isRegexColumn";
            this.isRegexColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isRegexColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // setWorkingDirectoryButton
            // 
            this.setWorkingDirectoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setWorkingDirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setWorkingDirectoryButton.Image = ((System.Drawing.Image)(resources.GetObject("setWorkingDirectoryButton.Image")));
            this.setWorkingDirectoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setWorkingDirectoryButton.Location = new System.Drawing.Point(47, 1);
            this.setWorkingDirectoryButton.Margin = new System.Windows.Forms.Padding(1);
            this.setWorkingDirectoryButton.Name = "setWorkingDirectoryButton";
            this.setWorkingDirectoryButton.Size = new System.Drawing.Size(215, 33);
            this.setWorkingDirectoryButton.TabIndex = 1;
            this.setWorkingDirectoryButton.Text = "Set working directory";
            this.setWorkingDirectoryButton.UseVisualStyleBackColor = true;
            this.setWorkingDirectoryButton.Click += new System.EventHandler(this.OnSetWorkingDirectoryButtonClick);
            // 
            // compressByPatternButton
            // 
            this.compressByPatternButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compressByPatternButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressByPatternButton.Image = ((System.Drawing.Image)(resources.GetObject("compressByPatternButton.Image")));
            this.compressByPatternButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compressByPatternButton.Location = new System.Drawing.Point(47, 182);
            this.compressByPatternButton.Margin = new System.Windows.Forms.Padding(1);
            this.compressByPatternButton.Name = "compressByPatternButton";
            this.compressByPatternButton.Size = new System.Drawing.Size(215, 33);
            this.compressByPatternButton.TabIndex = 2;
            this.compressByPatternButton.Text = "Compress target(s) to ZIP";
            this.compressByPatternButton.UseVisualStyleBackColor = true;
            this.compressByPatternButton.Click += new System.EventHandler(this.OnCompressByPatternButtonClick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "zip";
            this.saveFileDialog.Filter = "Zip Files (*.zip)|*.zip|All files (*.*)|*.*";
            this.saveFileDialog.Title = "Save ZIP file";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog.Title = "Open pattern file";
            // 
            // CompressByPatternForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Name = "CompressByPatternForm";
            this.Text = "Compress By Pattern";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem optimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noCompressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressionLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripMenuItem searchSubdirectoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem generateSinglezipFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateIntoworkingDirectoryToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button compressByPatternButton;
        private System.Windows.Forms.Button setWorkingDirectoryButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRegexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patternColumn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
    }
}
