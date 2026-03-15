using System.ComponentModel;
using System.Windows.Forms;
using CDBurnerXP.Controls;

namespace Ketarin.Forms
{
    partial class AboutDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.bClose = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblVersionDesc = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblDatabasePath = new CDBurnerXP.Controls.WebLink();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.webLink1 = new CDBurnerXP.Controls.WebLink();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lnkGPL = new CDBurnerXP.Controls.WebLink();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblImagesExcluded = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(319, 165);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 0;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(67, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(245, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Ketarin: Keep your setup packages up-to-date.";
            // 
            // lblVersionDesc
            // 
            this.lblVersionDesc.AutoSize = true;
            this.lblVersionDesc.Location = new System.Drawing.Point(3, 0);
            this.lblVersionDesc.Name = "lblVersionDesc";
            this.lblVersionDesc.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.lblVersionDesc.Size = new System.Drawing.Size(50, 17);
            this.lblVersionDesc.TabIndex = 2;
            this.lblVersionDesc.Text = "Version:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblAuthor, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDatabasePath, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDatabase, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.webLink1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblVersionDesc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblVersion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lnkGPL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLicense, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblImagesExcluded, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblWebsite, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAuthor, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(64, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 132);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(3, 107);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.lblAuthor.Size = new System.Drawing.Size(48, 17);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "&Author:";
            // 
            // lblDatabasePath
            // 
            this.lblDatabasePath.AutoSize = true;
            this.lblDatabasePath.Location = new System.Drawing.Point(69, 90);
            this.lblDatabasePath.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.lblDatabasePath.Name = "lblDatabasePath";
            this.lblDatabasePath.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblDatabasePath.Size = new System.Drawing.Size(0, 15);
            this.lblDatabasePath.TabIndex = 9;
            this.lblDatabasePath.Url = "";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(3, 90);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.lblDatabase.Size = new System.Drawing.Size(60, 17);
            this.lblDatabase.TabIndex = 8;
            this.lblDatabase.Text = "Database:";
            // 
            // webLink1
            // 
            this.webLink1.AutoSize = true;
            this.webLink1.Location = new System.Drawing.Point(69, 73);
            this.webLink1.Name = "webLink1";
            this.webLink1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.webLink1.Size = new System.Drawing.Size(162, 15);
            this.webLink1.TabIndex = 7;
            this.webLink1.TabStop = true;
            this.webLink1.Text = "http://ketarin.canneverbe.com";
            this.webLink1.Url = "http://ketarin.canneverbe.com";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(69, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.lblVersion.Size = new System.Drawing.Size(2, 17);
            this.lblVersion.TabIndex = 3;
            // 
            // lnkGPL
            // 
            this.lnkGPL.AutoSize = true;
            this.lnkGPL.LinkArea = new System.Windows.Forms.LinkArea(0, 29);
            this.lnkGPL.Location = new System.Drawing.Point(69, 17);
            this.lnkGPL.Name = "lnkGPL";
            this.lnkGPL.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.lnkGPL.Size = new System.Drawing.Size(70, 24);
            this.lnkGPL.TabIndex = 4;
            this.lnkGPL.TabStop = true;
            this.lnkGPL.Text = "GNU GPL v.2";
            this.lnkGPL.Url = "http://www.gnu.org/licenses/gpl-2.0.txt";
            this.lnkGPL.UseCompatibleTextRendering = true;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(3, 17);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.lblLicense.Size = new System.Drawing.Size(49, 17);
            this.lblLicense.TabIndex = 3;
            this.lblLicense.Text = "License:";
            // 
            // lblImagesExcluded
            // 
            this.lblImagesExcluded.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImagesExcluded.Location = new System.Drawing.Point(69, 41);
            this.lblImagesExcluded.Name = "lblImagesExcluded";
            this.lblImagesExcluded.Size = new System.Drawing.Size(258, 32);
            this.lblImagesExcluded.TabIndex = 5;
            this.lblImagesExcluded.Text = "This excludes the used icons, which are copyrighted by  VirtualLNK, LLC.";
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(3, 73);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.lblWebsite.Size = new System.Drawing.Size(54, 17);
            this.lblWebsite.TabIndex = 6;
            this.lblWebsite.Text = "Website:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Location = new System.Drawing.Point(69, 110);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(258, 15);
            this.txtAuthor.TabIndex = 11;
            // 
            // picIcon
            // 
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(8, 9);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(48, 48);
            this.picIcon.TabIndex = 7;
            this.picIcon.TabStop = false;
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 200);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.bClose);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bClose;
        private Label lblInfo;
        private Label lblVersionDesc;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblVersion;
        private WebLink lnkGPL;
        private Label lblLicense;
        private Label lblImagesExcluded;
        private Label lblWebsite;
        private WebLink webLink1;
        private PictureBox picIcon;
        private WebLink lblDatabasePath;
        private Label lblDatabase;
        private Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
    }
}