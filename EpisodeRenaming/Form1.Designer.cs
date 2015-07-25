namespace EpisodeRenaming {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.btnOnlineOpenFolder = new System.Windows.Forms.Button();
            this.btnTraktAPI = new System.Windows.Forms.Button();
            this.btnOfflineUndo = new System.Windows.Forms.Button();
            this.btnOfflineRename = new System.Windows.Forms.Button();
            this.lvAllFiles = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lblFolderPathForOnline = new System.Windows.Forms.Label();
            this.txtOriginalName = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyse.Location = new System.Drawing.Point(623, 12);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(78, 23);
            this.btnAnalyse.TabIndex = 2;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // btnOnlineOpenFolder
            // 
            this.btnOnlineOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnlineOpenFolder.Location = new System.Drawing.Point(623, 70);
            this.btnOnlineOpenFolder.Name = "btnOnlineOpenFolder";
            this.btnOnlineOpenFolder.Size = new System.Drawing.Size(78, 23);
            this.btnOnlineOpenFolder.TabIndex = 6;
            this.btnOnlineOpenFolder.Text = "Open Folder";
            this.btnOnlineOpenFolder.UseVisualStyleBackColor = true;
            this.btnOnlineOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnTraktAPI
            // 
            this.btnTraktAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraktAPI.Location = new System.Drawing.Point(549, 41);
            this.btnTraktAPI.Name = "btnTraktAPI";
            this.btnTraktAPI.Size = new System.Drawing.Size(152, 23);
            this.btnTraktAPI.TabIndex = 5;
            this.btnTraktAPI.Text = "Trakt API";
            this.btnTraktAPI.UseVisualStyleBackColor = true;
            this.btnTraktAPI.Click += new System.EventHandler(this.btnTraktAPI_Click);
            // 
            // btnOfflineUndo
            // 
            this.btnOfflineUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOfflineUndo.Enabled = false;
            this.btnOfflineUndo.Location = new System.Drawing.Point(549, 70);
            this.btnOfflineUndo.Name = "btnOfflineUndo";
            this.btnOfflineUndo.Size = new System.Drawing.Size(68, 23);
            this.btnOfflineUndo.TabIndex = 5;
            this.btnOfflineUndo.Text = "Undo";
            this.btnOfflineUndo.UseVisualStyleBackColor = true;
            this.btnOfflineUndo.Click += new System.EventHandler(this.btnOfflineUndo_Click);
            // 
            // btnOfflineRename
            // 
            this.btnOfflineRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOfflineRename.Location = new System.Drawing.Point(549, 12);
            this.btnOfflineRename.Name = "btnOfflineRename";
            this.btnOfflineRename.Size = new System.Drawing.Size(68, 23);
            this.btnOfflineRename.TabIndex = 1;
            this.btnOfflineRename.Text = "Rename";
            this.btnOfflineRename.UseVisualStyleBackColor = true;
            this.btnOfflineRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // lvAllFiles
            // 
            this.lvAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAllFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvAllFiles.Location = new System.Drawing.Point(12, 99);
            this.lvAllFiles.Name = "lvAllFiles";
            this.lvAllFiles.Size = new System.Drawing.Size(689, 246);
            this.lvAllFiles.TabIndex = 10;
            this.lvAllFiles.UseCompatibleStateImageBehavior = false;
            this.lvAllFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Original File Name";
            this.columnHeader3.Width = 360;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Modified File Name";
            this.columnHeader4.Width = 300;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // lblFolderPathForOnline
            // 
            this.lblFolderPathForOnline.AutoSize = true;
            this.lblFolderPathForOnline.Location = new System.Drawing.Point(11, 43);
            this.lblFolderPathForOnline.Name = "lblFolderPathForOnline";
            this.lblFolderPathForOnline.Size = new System.Drawing.Size(32, 13);
            this.lblFolderPathForOnline.TabIndex = 12;
            this.lblFolderPathForOnline.Text = "Path:";
            // 
            // txtOriginalName
            // 
            this.txtOriginalName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOriginalName.Location = new System.Drawing.Point(70, 15);
            this.txtOriginalName.Name = "txtOriginalName";
            this.txtOriginalName.Size = new System.Drawing.Size(473, 20);
            this.txtOriginalName.TabIndex = 11;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(70, 40);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(473, 20);
            this.txtPath.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 357);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFolderPathForOnline);
            this.Controls.Add(this.txtOriginalName);
            this.Controls.Add(this.btnOfflineUndo);
            this.Controls.Add(this.lvAllFiles);
            this.Controls.Add(this.btnOnlineOpenFolder);
            this.Controls.Add(this.btnOfflineRename);
            this.Controls.Add(this.btnTraktAPI);
            this.Controls.Add(this.btnAnalyse);
            this.MinimumSize = new System.Drawing.Size(729, 396);
            this.Name = "Form1";
            this.Text = "Episode Renaming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Button btnOfflineRename;
        private System.Windows.Forms.Button btnOfflineUndo;
        private System.Windows.Forms.Button btnTraktAPI;
        private System.Windows.Forms.Button btnOnlineOpenFolder;
        private System.Windows.Forms.ListView lvAllFiles;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFolderPathForOnline;
        private System.Windows.Forms.TextBox txtOriginalName;
        private System.Windows.Forms.TextBox txtPath;
    }
}

