﻿// <copyright file="MainForm.Designer.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
// <auto-generated />
namespace SteemSoftware
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubRepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.busyorgBlogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steemitcomBlogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionalityLabel = new System.Windows.Forms.Label();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askOnNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rememberWindowLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rememberWindowSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askOnExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.launchButton = new System.Windows.Forms.Button();
            this.functionalityListView = new System.Windows.Forms.ListView();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleClickLaunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchcenteredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainStatusStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryListBox
            // 
            this.categoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.IntegralHeight = false;
            this.categoryListBox.ItemHeight = 16;
            this.categoryListBox.Location = new System.Drawing.Point(3, 23);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(101, 233);
            this.categoryListBox.Sorted = true;
            this.categoryListBox.TabIndex = 0;
            this.categoryListBox.SelectedIndexChanged += new System.EventHandler(this.OnCategoryListBoxSelectedIndexChanged);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.statusToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 405);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(341, 22);
            this.mainStatusStrip.TabIndex = 3;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // statusToolStripStatusLabel
            // 
            this.statusToolStripStatusLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusToolStripStatusLabel.Name = "statusToolStripStatusLabel";
            this.statusToolStripStatusLabel.Size = new System.Drawing.Size(284, 17);
            this.statusToolStripStatusLabel.Text = "1) Pick category 2) Set functionality 3) Hit launch";
            // 
            // categoryLabel
            // 
            this.categoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(3, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(101, 20);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category:";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.githubRepositoryToolStripMenuItem,
                                    this.toolStripSeparator3,
                                    this.busyorgBlogToolStripMenuItem,
                                    this.steemitcomBlogToolStripMenuItem,
                                    this.toolStripSeparator5,
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // githubRepositoryToolStripMenuItem
            // 
            this.githubRepositoryToolStripMenuItem.Name = "githubRepositoryToolStripMenuItem";
            this.githubRepositoryToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.githubRepositoryToolStripMenuItem.Text = "&Github Repository";
            this.githubRepositoryToolStripMenuItem.Click += new System.EventHandler(this.OnGithubRepositoryToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(166, 6);
            // 
            // busyorgBlogToolStripMenuItem
            // 
            this.busyorgBlogToolStripMenuItem.Name = "busyorgBlogToolStripMenuItem";
            this.busyorgBlogToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.busyorgBlogToolStripMenuItem.Text = "&Busy.org blog";
            this.busyorgBlogToolStripMenuItem.Click += new System.EventHandler(this.OnBusyorgBlogToolStripMenuItemClick);
            // 
            // steemitcomBlogToolStripMenuItem
            // 
            this.steemitcomBlogToolStripMenuItem.Name = "steemitcomBlogToolStripMenuItem";
            this.steemitcomBlogToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.steemitcomBlogToolStripMenuItem.Text = "&Steemit.com blog";
            this.steemitcomBlogToolStripMenuItem.Click += new System.EventHandler(this.OnSteemitcomBlogToolStripMenuItemClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(166, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // functionalityLabel
            // 
            this.functionalityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.functionalityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionalityLabel.Location = new System.Drawing.Point(110, 0);
            this.functionalityLabel.Name = "functionalityLabel";
            this.functionalityLabel.Size = new System.Drawing.Size(228, 20);
            this.functionalityLabel.TabIndex = 3;
            this.functionalityLabel.Text = "Functionality:";
            this.functionalityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.askOnNewToolStripMenuItem,
                                    this.rememberWindowLocationToolStripMenuItem,
                                    this.rememberWindowSizeToolStripMenuItem,
                                    this.askOnExitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnToolStripMenuItemDropDownItemClicked);
            // 
            // askOnNewToolStripMenuItem
            // 
            this.askOnNewToolStripMenuItem.Checked = true;
            this.askOnNewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.askOnNewToolStripMenuItem.Name = "askOnNewToolStripMenuItem";
            this.askOnNewToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.askOnNewToolStripMenuItem.Text = "Ask on &new";
            // 
            // rememberWindowlocationToolStripMenuItem
            // 
            this.rememberWindowLocationToolStripMenuItem.Checked = true;
            this.rememberWindowLocationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rememberWindowLocationToolStripMenuItem.Name = "rememberWindowlocationToolStripMenuItem";
            this.rememberWindowLocationToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.rememberWindowLocationToolStripMenuItem.Text = "Remember window &location";
            // 
            // rememberWindowsizeToolStripMenuItem
            // 
            this.rememberWindowSizeToolStripMenuItem.Checked = true;
            this.rememberWindowSizeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rememberWindowSizeToolStripMenuItem.Name = "rememberWindowsizeToolStripMenuItem";
            this.rememberWindowSizeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.rememberWindowSizeToolStripMenuItem.Text = "Remember window &size";
            // 
            // askOnExitToolStripMenuItem
            // 
            this.askOnExitToolStripMenuItem.Checked = true;
            this.askOnExitToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.askOnExitToolStripMenuItem.Name = "askOnExitToolStripMenuItem";
            this.askOnExitToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.askOnExitToolStripMenuItem.Text = "Ask on &exit";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(3, 259);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(101, 32);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Description:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionRichTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.descriptionRichTextBox, 2);
            this.descriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(3, 294);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(335, 106);
            this.descriptionRichTextBox.TabIndex = 4;
            this.descriptionRichTextBox.Text = "";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.67155F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.32845F));
            this.mainTableLayoutPanel.Controls.Add(this.categoryListBox, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.categoryLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.functionalityLabel, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.descriptionRichTextBox, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.descriptionLabel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.launchButton, 1, 2);
            this.mainTableLayoutPanel.Controls.Add(this.functionalityListView, 1, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.24147F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.75853F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(341, 403);
            this.mainTableLayoutPanel.TabIndex = 5;
            // 
            // launchButton
            // 
            this.launchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.launchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.launchButton.Location = new System.Drawing.Point(110, 262);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(228, 26);
            this.launchButton.TabIndex = 6;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.OnLaunchButtonClick);
            // 
            // functionalityListView
            // 
            this.functionalityListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.functionalityListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionalityListView.FullRowSelect = true;
            this.functionalityListView.Location = new System.Drawing.Point(110, 23);
            this.functionalityListView.Name = "functionalityListView";
            this.functionalityListView.Size = new System.Drawing.Size(228, 233);
            this.functionalityListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.functionalityListView.TabIndex = 7;
            this.functionalityListView.UseCompatibleStateImageBehavior = false;
            this.functionalityListView.View = System.Windows.Forms.View.List;
            this.functionalityListView.SelectedIndexChanged += new System.EventHandler(this.OnFunctionalityListViewSelectedIndexChanged);
            this.functionalityListView.DoubleClick += new System.EventHandler(this.OnFunctionalityListViewDoubleClick);
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.doubleClickLaunchToolStripMenuItem,
                                    this.launchcenteredToolStripMenuItem});
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            this.customizeToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnToolStripMenuItemDropDownItemClicked);
            // 
            // doubleClickLaunchToolStripMenuItem
            // 
            this.doubleClickLaunchToolStripMenuItem.Checked = true;
            this.doubleClickLaunchToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doubleClickLaunchToolStripMenuItem.Name = "doubleClickLaunchToolStripMenuItem";
            this.doubleClickLaunchToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.doubleClickLaunchToolStripMenuItem.Text = "&Double click launch";
            // 
            // launchcenteredToolStripMenuItem
            // 
            this.launchcenteredToolStripMenuItem.Name = "launchcenteredToolStripMenuItem";
            this.launchcenteredToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.launchcenteredToolStripMenuItem.Text = "Launch &centered";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.customizeToolStripMenuItem,
                                    this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Visible = false;
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
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.newToolStripMenuItem,
                                    this.openToolStripMenuItem,
                                    this.toolStripSeparator,
                                    this.saveToolStripMenuItem,
                                    this.saveAsToolStripMenuItem,
                                    this.toolStripSeparator1,
                                    this.printToolStripMenuItem,
                                    this.printPreviewToolStripMenuItem,
                                    this.toolStripSeparator2,
                                    this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            this.toolStripSeparator.Visible = false;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Visible = false;
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Visible = false;
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            this.printPreviewToolStripMenuItem.Visible = false;
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
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.fileToolStripMenuItem,
                                    this.toolsToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(341, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AcceptButton = this.launchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 427);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SteemSoftware";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormFormClosing);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem askOnExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askOnNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem steemitcomBlogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busyorgBlogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchcenteredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rememberWindowSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rememberWindowLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleClickLaunchToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ListView functionalityListView;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label functionalityLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem githubRepositoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ListBox categoryListBox;
    }
}
