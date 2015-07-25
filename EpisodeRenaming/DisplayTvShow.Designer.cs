namespace EpisodeRenaming {
    partial class DisplayTvShow {
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
            this.btnClose = new System.Windows.Forms.Button();
            this.pbShowPoster = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOverview = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTvRage = new System.Windows.Forms.Label();
            this.lblTmdb = new System.Windows.Forms.Label();
            this.lblImdb = new System.Windows.Forms.Label();
            this.lblTvdb = new System.Windows.Forms.Label();
            this.lblSlug = new System.Windows.Forms.Label();
            this.lblTrakt = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblNoImageAvailable = new System.Windows.Forms.Label();
            this.btnUse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(380, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbShowPoster
            // 
            this.pbShowPoster.Location = new System.Drawing.Point(12, 12);
            this.pbShowPoster.Name = "pbShowPoster";
            this.pbShowPoster.Size = new System.Drawing.Size(139, 194);
            this.pbShowPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowPoster.TabIndex = 1;
            this.pbShowPoster.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(170, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 22);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblOverview
            // 
            this.lblOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverview.Location = new System.Drawing.Point(171, 63);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(284, 265);
            this.lblOverview.TabIndex = 3;
            this.lblOverview.Text = "Overview";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(171, 43);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "IDs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "trakt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "slug";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "tvdb";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "imdb";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "tmdb";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "tvrage";
            // 
            // lblTvRage
            // 
            this.lblTvRage.AutoSize = true;
            this.lblTvRage.Location = new System.Drawing.Point(72, 296);
            this.lblTvRage.Name = "lblTvRage";
            this.lblTvRage.Size = new System.Drawing.Size(0, 13);
            this.lblTvRage.TabIndex = 17;
            // 
            // lblTmdb
            // 
            this.lblTmdb.AutoSize = true;
            this.lblTmdb.Location = new System.Drawing.Point(72, 283);
            this.lblTmdb.Name = "lblTmdb";
            this.lblTmdb.Size = new System.Drawing.Size(0, 13);
            this.lblTmdb.TabIndex = 16;
            // 
            // lblImdb
            // 
            this.lblImdb.AutoSize = true;
            this.lblImdb.Location = new System.Drawing.Point(72, 270);
            this.lblImdb.Name = "lblImdb";
            this.lblImdb.Size = new System.Drawing.Size(0, 13);
            this.lblImdb.TabIndex = 15;
            // 
            // lblTvdb
            // 
            this.lblTvdb.AutoSize = true;
            this.lblTvdb.Location = new System.Drawing.Point(72, 257);
            this.lblTvdb.Name = "lblTvdb";
            this.lblTvdb.Size = new System.Drawing.Size(0, 13);
            this.lblTvdb.TabIndex = 14;
            // 
            // lblSlug
            // 
            this.lblSlug.AutoSize = true;
            this.lblSlug.Location = new System.Drawing.Point(72, 244);
            this.lblSlug.Name = "lblSlug";
            this.lblSlug.Size = new System.Drawing.Size(0, 13);
            this.lblSlug.TabIndex = 13;
            // 
            // lblTrakt
            // 
            this.lblTrakt.AutoSize = true;
            this.lblTrakt.Location = new System.Drawing.Point(72, 231);
            this.lblTrakt.Name = "lblTrakt";
            this.lblTrakt.Size = new System.Drawing.Size(0, 13);
            this.lblTrakt.TabIndex = 12;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Location = new System.Drawing.Point(93, 331);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.Location = new System.Drawing.Point(12, 331);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblNoImageAvailable
            // 
            this.lblNoImageAvailable.AutoSize = true;
            this.lblNoImageAvailable.Location = new System.Drawing.Point(32, 102);
            this.lblNoImageAvailable.Name = "lblNoImageAvailable";
            this.lblNoImageAvailable.Size = new System.Drawing.Size(99, 13);
            this.lblNoImageAvailable.TabIndex = 20;
            this.lblNoImageAvailable.Text = "No Image Available";
            // 
            // btnUse
            // 
            this.btnUse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUse.Location = new System.Drawing.Point(299, 331);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(75, 23);
            this.btnUse.TabIndex = 21;
            this.btnUse.Text = "Use";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // DisplayTvShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 366);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblTvRage);
            this.Controls.Add(this.lblTmdb);
            this.Controls.Add(this.lblImdb);
            this.Controls.Add(this.lblTvdb);
            this.Controls.Add(this.lblSlug);
            this.Controls.Add(this.lblTrakt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblOverview);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNoImageAvailable);
            this.Controls.Add(this.pbShowPoster);
            this.Name = "DisplayTvShow";
            this.Text = "DisplayTvShow";
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbShowPoster;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTvRage;
        private System.Windows.Forms.Label lblTmdb;
        private System.Windows.Forms.Label lblImdb;
        private System.Windows.Forms.Label lblTvdb;
        private System.Windows.Forms.Label lblSlug;
        private System.Windows.Forms.Label lblTrakt;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblNoImageAvailable;
        private System.Windows.Forms.Button btnUse;
    }
}