﻿// <copyright file="AboutForm.Designer.cs" company="SteemSoftware">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
// <auto-generated />
namespace SteemSoftware
{
    partial class AboutForm
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.moduleInformationLabel = new System.Windows.Forms.Label();
            this.licenseInfoLabel = new System.Windows.Forms.Label();
            this.licenseRichTextBox = new System.Windows.Forms.RichTextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.nameVersionLabel = new System.Windows.Forms.Label();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.mainTableLayoutPanel.Controls.Add(this.moduleInformationLabel, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.licenseInfoLabel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.licenseRichTextBox, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.okButton, 2, 4);
            this.mainTableLayoutPanel.Controls.Add(this.nameVersionLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.mainPictureBox, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 5;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(284, 262);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // moduleInformationLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.moduleInformationLabel, 2);
            this.moduleInformationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleInformationLabel.Location = new System.Drawing.Point(97, 20);
            this.moduleInformationLabel.Name = "moduleInformationLabel";
            this.moduleInformationLabel.Size = new System.Drawing.Size(184, 93);
            this.moduleInformationLabel.TabIndex = 1;
            this.moduleInformationLabel.Text = "Module information";
            this.moduleInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // licenseInfoLabel
            // 
            this.licenseInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licenseInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseInfoLabel.Location = new System.Drawing.Point(3, 113);
            this.licenseInfoLabel.Name = "licenseInfoLabel";
            this.licenseInfoLabel.Size = new System.Drawing.Size(88, 20);
            this.licenseInfoLabel.TabIndex = 2;
            this.licenseInfoLabel.Text = "License info:";
            this.licenseInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // licenseRichTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.licenseRichTextBox, 3);
            this.licenseRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licenseRichTextBox.Location = new System.Drawing.Point(3, 136);
            this.licenseRichTextBox.Name = "licenseRichTextBox";
            this.licenseRichTextBox.Size = new System.Drawing.Size(278, 87);
            this.licenseRichTextBox.TabIndex = 1;
            this.licenseRichTextBox.Text = "";
            this.licenseRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.OnLicenseRichTextBoxLinkClicked);
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(191, 229);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(90, 30);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OnOkButtonClick);
            // 
            // nameVersionLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.nameVersionLabel, 3);
            this.nameVersionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameVersionLabel.Location = new System.Drawing.Point(3, 0);
            this.nameVersionLabel.Name = "nameVersionLabel";
            this.nameVersionLabel.Size = new System.Drawing.Size(278, 20);
            this.nameVersionLabel.TabIndex = 0;
            this.nameVersionLabel.Text = "Full name + version";
            this.nameVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.Location = new System.Drawing.Point(3, 23);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(88, 87);
            this.mainPictureBox.TabIndex = 5;
            this.mainPictureBox.TabStop = false;
            // 
            // AboutForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.mainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Label nameVersionLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.RichTextBox licenseRichTextBox;
        private System.Windows.Forms.Label licenseInfoLabel;
        private System.Windows.Forms.Label moduleInformationLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
    }
}