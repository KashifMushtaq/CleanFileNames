
namespace CleanFileName
{
    partial class frmCleanFileName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCleanFileName));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.labelHelp = new System.Windows.Forms.Label();
            this.labelCFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(15, 146);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(122, 16);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Select Root Folder:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(144, 145);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(808, 22);
            this.textBoxPath.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(959, 135);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(52, 42);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(16, 293);
            this.richTextBoxLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(1374, 540);
            this.richTextBoxLog.TabIndex = 3;
            this.richTextBoxLog.TabStop = false;
            this.richTextBoxLog.Text = "";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(15, 174);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(65, 16);
            this.labelStart.TabIndex = 4;
            this.labelStart.Text = "Start Tag:";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(15, 206);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(62, 16);
            this.labelEnd.TabIndex = 5;
            this.labelEnd.Text = "End Tag:";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(144, 174);
            this.textBoxStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStart.MaxLength = 50;
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(167, 22);
            this.textBoxStart.TabIndex = 1;
            this.textBoxStart.Text = " (";
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(144, 204);
            this.textBoxEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEnd.MaxLength = 50;
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(167, 22);
            this.textBoxEnd.TabIndex = 2;
            this.textBoxEnd.Text = ")";
            // 
            // labelHelp
            // 
            this.labelHelp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.Location = new System.Drawing.Point(10, 9);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(1387, 98);
            this.labelHelp.TabIndex = 8;
            this.labelHelp.Text = resources.GetString("labelHelp.Text");
            // 
            // labelCFile
            // 
            this.labelCFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCFile.Location = new System.Drawing.Point(16, 243);
            this.labelCFile.Name = "labelCFile";
            this.labelCFile.Size = new System.Drawing.Size(1372, 32);
            this.labelCFile.TabIndex = 9;
            this.labelCFile.Text = "Current file being processed";
            // 
            // frmCleanFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 864);
            this.Controls.Add(this.labelCFile);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.textBoxEnd);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCleanFileName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clean File Name";
            this.Load += new System.EventHandler(this.frmCleanFileName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label labelCFile;
    }
}