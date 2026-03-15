using System.ComponentModel;
using System.Windows.Forms;

namespace Ketarin.Forms
{
    partial class CloseProcessInstructionDialog
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
            this.lnlProcessName = new System.Windows.Forms.Label();
            this.cboProcessName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(501, 60);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(420, 60);
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // lnlProcessName
            // 
            this.lnlProcessName.AutoSize = true;
            this.lnlProcessName.Location = new System.Drawing.Point(12, 15);
            this.lnlProcessName.Name = "lnlProcessName";
            this.lnlProcessName.Size = new System.Drawing.Size(236, 13);
            this.lnlProcessName.TabIndex = 0;
            this.lnlProcessName.Text = "&Close all processes with the following name:";
            // 
            // cboProcessName
            // 
            this.cboProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProcessName.FormattingEnabled = true;
            this.cboProcessName.Location = new System.Drawing.Point(254, 12);
            this.cboProcessName.Name = "cboProcessName";
            this.cboProcessName.Size = new System.Drawing.Size(322, 21);
            this.cboProcessName.TabIndex = 1;
            // 
            // CloseProcessInstructionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 95);
            this.Controls.Add(this.lnlProcessName);
            this.Controls.Add(this.cboProcessName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CloseProcessInstructionDialog";
            this.Text = "Close Process";
            this.Controls.SetChildIndex(this.cboProcessName, 0);
            this.Controls.SetChildIndex(this.lnlProcessName, 0);
            this.Controls.SetChildIndex(this.bOK, 0);
            this.Controls.SetChildIndex(this.bCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lnlProcessName;
        private ComboBox cboProcessName;
    }
}