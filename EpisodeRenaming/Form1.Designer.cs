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
            this.txtOriginalName = new System.Windows.Forms.TextBox();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblFolderPathForOnline = new System.Windows.Forms.Label();
            this.btnOnlineOpenFolder = new System.Windows.Forms.Button();
            this.btnTraktAPI = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOfflineUndo = new System.Windows.Forms.Button();
            this.lvOfflineAllFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOfflineTvShowName = new System.Windows.Forms.Label();
            this.txtOfflineTvShowName = new System.Windows.Forms.TextBox();
            this.btnOfflineRename = new System.Windows.Forms.Button();
            this.btnOfflineOpenFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOriginalName
            // 
            this.txtOriginalName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOriginalName.Location = new System.Drawing.Point(65, 6);
            this.txtOriginalName.Name = "txtOriginalName";
            this.txtOriginalName.Size = new System.Drawing.Size(242, 20);
            this.txtOriginalName.TabIndex = 0;
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyse.Location = new System.Drawing.Point(608, 9);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(67, 23);
            this.btnAnalyse.TabIndex = 2;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.Location = new System.Drawing.Point(523, 9);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(79, 23);
            this.btnRename.TabIndex = 4;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 333);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblFolderPathForOnline);
            this.tabPage1.Controls.Add(this.btnOnlineOpenFolder);
            this.tabPage1.Controls.Add(this.btnTraktAPI);
            this.tabPage1.Controls.Add(this.txtOriginalName);
            this.tabPage1.Controls.Add(this.btnRename);
            this.tabPage1.Controls.Add(this.btnAnalyse);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Online";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblFolderPathForOnline
            // 
            this.lblFolderPathForOnline.AutoSize = true;
            this.lblFolderPathForOnline.Location = new System.Drawing.Point(6, 34);
            this.lblFolderPathForOnline.Name = "lblFolderPathForOnline";
            this.lblFolderPathForOnline.Size = new System.Drawing.Size(32, 13);
            this.lblFolderPathForOnline.TabIndex = 7;
            this.lblFolderPathForOnline.Text = "Path:";
            // 
            // btnOnlineOpenFolder
            // 
            this.btnOnlineOpenFolder.Location = new System.Drawing.Point(586, 67);
            this.btnOnlineOpenFolder.Name = "btnOnlineOpenFolder";
            this.btnOnlineOpenFolder.Size = new System.Drawing.Size(89, 23);
            this.btnOnlineOpenFolder.TabIndex = 6;
            this.btnOnlineOpenFolder.Text = "Open Folder";
            this.btnOnlineOpenFolder.UseVisualStyleBackColor = true;
            this.btnOnlineOpenFolder.Click += new System.EventHandler(this.btnOnlineOpenFolder_Click);
            // 
            // btnTraktAPI
            // 
            this.btnTraktAPI.Location = new System.Drawing.Point(523, 38);
            this.btnTraktAPI.Name = "btnTraktAPI";
            this.btnTraktAPI.Size = new System.Drawing.Size(152, 23);
            this.btnTraktAPI.TabIndex = 5;
            this.btnTraktAPI.Text = "Trakt API";
            this.btnTraktAPI.UseVisualStyleBackColor = true;
            this.btnTraktAPI.Click += new System.EventHandler(this.btnTraktAPI_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnOfflineUndo);
            this.tabPage2.Controls.Add(this.lvOfflineAllFiles);
            this.tabPage2.Controls.Add(this.lblOfflineTvShowName);
            this.tabPage2.Controls.Add(this.txtOfflineTvShowName);
            this.tabPage2.Controls.Add(this.btnOfflineRename);
            this.tabPage2.Controls.Add(this.btnOfflineOpenFolder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Offline";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOfflineUndo
            // 
            this.btnOfflineUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOfflineUndo.Enabled = false;
            this.btnOfflineUndo.Location = new System.Drawing.Point(519, 281);
            this.btnOfflineUndo.Name = "btnOfflineUndo";
            this.btnOfflineUndo.Size = new System.Drawing.Size(75, 23);
            this.btnOfflineUndo.TabIndex = 5;
            this.btnOfflineUndo.Text = "Undo";
            this.btnOfflineUndo.UseVisualStyleBackColor = true;
            this.btnOfflineUndo.Click += new System.EventHandler(this.btnOfflineUndo_Click);
            // 
            // lvOfflineAllFiles
            // 
            this.lvOfflineAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvOfflineAllFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvOfflineAllFiles.Location = new System.Drawing.Point(9, 61);
            this.lvOfflineAllFiles.Name = "lvOfflineAllFiles";
            this.lvOfflineAllFiles.Size = new System.Drawing.Size(666, 214);
            this.lvOfflineAllFiles.TabIndex = 4;
            this.lvOfflineAllFiles.UseCompatibleStateImageBehavior = false;
            this.lvOfflineAllFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Original File Name";
            this.columnHeader1.Width = 360;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Modified File Name";
            this.columnHeader2.Width = 300;
            // 
            // lblOfflineTvShowName
            // 
            this.lblOfflineTvShowName.AutoSize = true;
            this.lblOfflineTvShowName.Location = new System.Drawing.Point(6, 38);
            this.lblOfflineTvShowName.Name = "lblOfflineTvShowName";
            this.lblOfflineTvShowName.Size = new System.Drawing.Size(35, 13);
            this.lblOfflineTvShowName.TabIndex = 3;
            this.lblOfflineTvShowName.Text = "Name";
            // 
            // txtOfflineTvShowName
            // 
            this.txtOfflineTvShowName.Location = new System.Drawing.Point(47, 35);
            this.txtOfflineTvShowName.Name = "txtOfflineTvShowName";
            this.txtOfflineTvShowName.Size = new System.Drawing.Size(234, 20);
            this.txtOfflineTvShowName.TabIndex = 2;
            this.txtOfflineTvShowName.Text = "The Blacklist";
            this.txtOfflineTvShowName.TextChanged += new System.EventHandler(this.txtOfflineTvShowName_TextChanged);
            this.txtOfflineTvShowName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOfflineTvShowName_KeyPress);
            // 
            // btnOfflineRename
            // 
            this.btnOfflineRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOfflineRename.Location = new System.Drawing.Point(600, 281);
            this.btnOfflineRename.Name = "btnOfflineRename";
            this.btnOfflineRename.Size = new System.Drawing.Size(75, 23);
            this.btnOfflineRename.TabIndex = 1;
            this.btnOfflineRename.Text = "Rename";
            this.btnOfflineRename.UseVisualStyleBackColor = true;
            this.btnOfflineRename.Click += new System.EventHandler(this.btnOfflineRename_Click);
            // 
            // btnOfflineOpenFolder
            // 
            this.btnOfflineOpenFolder.Location = new System.Drawing.Point(6, 6);
            this.btnOfflineOpenFolder.Name = "btnOfflineOpenFolder";
            this.btnOfflineOpenFolder.Size = new System.Drawing.Size(89, 23);
            this.btnOfflineOpenFolder.TabIndex = 0;
            this.btnOfflineOpenFolder.Text = "Open Folder";
            this.btnOfflineOpenFolder.UseVisualStyleBackColor = true;
            this.btnOfflineOpenFolder.Click += new System.EventHandler(this.btnOfflineOpenFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 357);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(729, 396);
            this.Name = "Form1";
            this.Text = "Episode Renaming";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtOriginalName;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblOfflineTvShowName;
        private System.Windows.Forms.TextBox txtOfflineTvShowName;
        private System.Windows.Forms.Button btnOfflineRename;
        private System.Windows.Forms.Button btnOfflineOpenFolder;
        private System.Windows.Forms.ListView lvOfflineAllFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnOfflineUndo;
        private System.Windows.Forms.Button btnTraktAPI;
        private System.Windows.Forms.Button btnOnlineOpenFolder;
        private System.Windows.Forms.Label lblFolderPathForOnline;
        private System.Windows.Forms.Label label2;
    }
}

