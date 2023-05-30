namespace SimpleFileShredder
{
    partial class frmShredder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShredder));
            this.ofdBrowse = new System.Windows.Forms.OpenFileDialog();
            this.ofdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShredFile = new System.Windows.Forms.Button();
            this.btnOverwrite = new System.Windows.Forms.Button();
            this.cmbOverwite = new System.Windows.Forms.ComboBox();
            this.lblOverwite = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.grbFolders = new System.Windows.Forms.GroupBox();
            this.btnShredFolder = new System.Windows.Forms.Button();
            this.btnOverwriteFolder = new System.Windows.Forms.Button();
            this.cmbOverwiteFolder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.txtPathFolder = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grbFolders.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShredFile);
            this.groupBox1.Controls.Add(this.btnOverwrite);
            this.groupBox1.Controls.Add(this.cmbOverwite);
            this.groupBox1.Controls.Add(this.lblOverwite);
            this.groupBox1.Controls.Add(this.lblPath);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 135);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файли";
            // 
            // btnShredFile
            // 
            this.btnShredFile.Enabled = false;
            this.btnShredFile.Location = new System.Drawing.Point(15, 105);
            this.btnShredFile.Name = "btnShredFile";
            this.btnShredFile.Size = new System.Drawing.Size(224, 23);
            this.btnShredFile.TabIndex = 14;
            this.btnShredFile.Text = "Утилізувати (переписати та видалити)";
            this.btnShredFile.UseVisualStyleBackColor = true;
            this.btnShredFile.Click += new System.EventHandler(this.btnShredFile_Click);
            // 
            // btnOverwrite
            // 
            this.btnOverwrite.Enabled = false;
            this.btnOverwrite.Location = new System.Drawing.Point(15, 76);
            this.btnOverwrite.Name = "btnOverwrite";
            this.btnOverwrite.Size = new System.Drawing.Size(85, 23);
            this.btnOverwrite.TabIndex = 13;
            this.btnOverwrite.Text = "Переписати";
            this.btnOverwrite.UseVisualStyleBackColor = true;
            this.btnOverwrite.Click += new System.EventHandler(this.btnOverwrite_Click);
            // 
            // cmbOverwite
            // 
            this.cmbOverwite.AutoCompleteCustomSource.AddRange(new string[] {
            "Zeros",
            "Random Data"});
            this.cmbOverwite.FormattingEnabled = true;
            this.cmbOverwite.Items.AddRange(new object[] {
            "Нульові байти",
            "Випадкові данні"});
            this.cmbOverwite.Location = new System.Drawing.Point(95, 46);
            this.cmbOverwite.Name = "cmbOverwite";
            this.cmbOverwite.Size = new System.Drawing.Size(121, 21);
            this.cmbOverwite.TabIndex = 12;
            // 
            // lblOverwite
            // 
            this.lblOverwite.AutoSize = true;
            this.lblOverwite.Location = new System.Drawing.Point(3, 49);
            this.lblOverwite.Name = "lblOverwite";
            this.lblOverwite.Size = new System.Drawing.Size(86, 13);
            this.lblOverwite.TabIndex = 11;
            this.lblOverwite.Text = "Переписати як:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(5, 20);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(85, 13);
            this.lblPath.TabIndex = 10;
            this.lblPath.Text = "Шлях до файлу:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(252, 45);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(121, 21);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Завантажити з...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(95, 15);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(224, 20);
            this.txtPath.TabIndex = 8;
            // 
            // grbFolders
            // 
            this.grbFolders.Controls.Add(this.btnShredFolder);
            this.grbFolders.Controls.Add(this.btnOverwriteFolder);
            this.grbFolders.Controls.Add(this.cmbOverwiteFolder);
            this.grbFolders.Controls.Add(this.label1);
            this.grbFolders.Controls.Add(this.lblFolder);
            this.grbFolders.Controls.Add(this.btnBrowseFolder);
            this.grbFolders.Controls.Add(this.txtPathFolder);
            this.grbFolders.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFolders.Location = new System.Drawing.Point(0, 135);
            this.grbFolders.Name = "grbFolders";
            this.grbFolders.Size = new System.Drawing.Size(464, 136);
            this.grbFolders.TabIndex = 9;
            this.grbFolders.TabStop = false;
            this.grbFolders.Text = "Папки";
            // 
            // btnShredFolder
            // 
            this.btnShredFolder.Enabled = false;
            this.btnShredFolder.Location = new System.Drawing.Point(15, 105);
            this.btnShredFolder.Name = "btnShredFolder";
            this.btnShredFolder.Size = new System.Drawing.Size(224, 23);
            this.btnShredFolder.TabIndex = 14;
            this.btnShredFolder.Text = "Утилізувати (переписати та видалити)";
            this.btnShredFolder.UseVisualStyleBackColor = true;
            this.btnShredFolder.Click += new System.EventHandler(this.btnShredFolder_Click);
            // 
            // btnOverwriteFolder
            // 
            this.btnOverwriteFolder.Enabled = false;
            this.btnOverwriteFolder.Location = new System.Drawing.Point(15, 76);
            this.btnOverwriteFolder.Name = "btnOverwriteFolder";
            this.btnOverwriteFolder.Size = new System.Drawing.Size(85, 23);
            this.btnOverwriteFolder.TabIndex = 13;
            this.btnOverwriteFolder.Text = "Переписати";
            this.btnOverwriteFolder.UseVisualStyleBackColor = true;
            this.btnOverwriteFolder.Click += new System.EventHandler(this.btnOverwriteFolder_Click);
            // 
            // cmbOverwiteFolder
            // 
            this.cmbOverwiteFolder.AutoCompleteCustomSource.AddRange(new string[] {
            "Zeros",
            "Random Data"});
            this.cmbOverwiteFolder.FormattingEnabled = true;
            this.cmbOverwiteFolder.Items.AddRange(new object[] {
            "Нульові байти",
            "Випадкові данні"});
            this.cmbOverwiteFolder.Location = new System.Drawing.Point(95, 41);
            this.cmbOverwiteFolder.Name = "cmbOverwiteFolder";
            this.cmbOverwiteFolder.Size = new System.Drawing.Size(121, 21);
            this.cmbOverwiteFolder.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Переписати як:";
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(3, 16);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(84, 13);
            this.lblFolder.TabIndex = 10;
            this.lblFolder.Text = "Шлях до папки:";
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(252, 39);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(121, 23);
            this.btnBrowseFolder.TabIndex = 9;
            this.btnBrowseFolder.Text = "Завантажити з,,,";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // txtPathFolder
            // 
            this.txtPathFolder.Location = new System.Drawing.Point(95, 9);
            this.txtPathFolder.Name = "txtPathFolder";
            this.txtPathFolder.Size = new System.Drawing.Size(224, 20);
            this.txtPathFolder.TabIndex = 8;
            // 
            // frmShredder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(464, 279);
            this.Controls.Add(this.grbFolders);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShredder";
            this.Text = "Утилізатор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbFolders.ResumeLayout(false);
            this.grbFolders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdBrowse;
        private System.Windows.Forms.FolderBrowserDialog ofdFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShredFile;
        private System.Windows.Forms.Button btnOverwrite;
        private System.Windows.Forms.ComboBox cmbOverwite;
        private System.Windows.Forms.Label lblOverwite;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox grbFolders;
        private System.Windows.Forms.Button btnShredFolder;
        private System.Windows.Forms.Button btnOverwriteFolder;
        private System.Windows.Forms.ComboBox cmbOverwiteFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox txtPathFolder;
    }
}

