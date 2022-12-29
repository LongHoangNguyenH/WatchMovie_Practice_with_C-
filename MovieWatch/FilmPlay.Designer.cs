namespace MovieWatch
{
    partial class FilmPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmPlay));
            this.pn_LogIn_Acc = new System.Windows.Forms.Panel();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.btn_Create_Account = new System.Windows.Forms.Button();
            this.flp_History = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_namePlaylist = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_MainUI = new System.Windows.Forms.Button();
            this.pic_star5 = new System.Windows.Forms.PictureBox();
            this.pic_star4 = new System.Windows.Forms.PictureBox();
            this.pic_star3 = new System.Windows.Forms.PictureBox();
            this.pic_star2 = new System.Windows.Forms.PictureBox();
            this.pic_star1 = new System.Windows.Forms.PictureBox();
            this.btn_comment = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pn_LogIn_Acc.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_LogIn_Acc
            // 
            this.pn_LogIn_Acc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_LogIn_Acc.Controls.Add(this.btn_LogIn);
            this.pn_LogIn_Acc.Controls.Add(this.btn_Create_Account);
            this.pn_LogIn_Acc.Location = new System.Drawing.Point(850, 7);
            this.pn_LogIn_Acc.Name = "pn_LogIn_Acc";
            this.pn_LogIn_Acc.Size = new System.Drawing.Size(391, 80);
            this.pn_LogIn_Acc.TabIndex = 22;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogIn.Location = new System.Drawing.Point(73, 12);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(117, 50);
            this.btn_LogIn.TabIndex = 12;
            this.btn_LogIn.Text = "Đăng Nhập";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_Create_Account
            // 
            this.btn_Create_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Create_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create_Account.Location = new System.Drawing.Point(252, 12);
            this.btn_Create_Account.Name = "btn_Create_Account";
            this.btn_Create_Account.Size = new System.Drawing.Size(113, 50);
            this.btn_Create_Account.TabIndex = 11;
            this.btn_Create_Account.Text = "Đăng  Ký";
            this.btn_Create_Account.UseVisualStyleBackColor = true;
            this.btn_Create_Account.Click += new System.EventHandler(this.btn_Create_Account_Click);
            // 
            // flp_History
            // 
            this.flp_History.AutoScroll = true;
            this.flp_History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flp_History.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_History.Location = new System.Drawing.Point(850, 129);
            this.flp_History.Name = "flp_History";
            this.flp_History.Size = new System.Drawing.Size(391, 546);
            this.flp_History.TabIndex = 20;
            // 
            // lbl_namePlaylist
            // 
            this.lbl_namePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_namePlaylist.Location = new System.Drawing.Point(850, 102);
            this.lbl_namePlaylist.Name = "lbl_namePlaylist";
            this.lbl_namePlaylist.Size = new System.Drawing.Size(391, 24);
            this.lbl_namePlaylist.TabIndex = 19;
            this.lbl_namePlaylist.Text = "Lịch sử tìm kiếm phim";
            this.lbl_namePlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_MainUI);
            this.panel1.Controls.Add(this.pic_star5);
            this.panel1.Controls.Add(this.pic_star4);
            this.panel1.Controls.Add(this.pic_star3);
            this.panel1.Controls.Add(this.pic_star2);
            this.panel1.Controls.Add(this.pic_star1);
            this.panel1.Controls.Add(this.btn_comment);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Location = new System.Drawing.Point(1, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 80);
            this.panel1.TabIndex = 18;
            // 
            // btn_MainUI
            // 
            this.btn_MainUI.Location = new System.Drawing.Point(141, 12);
            this.btn_MainUI.Name = "btn_MainUI";
            this.btn_MainUI.Size = new System.Drawing.Size(107, 50);
            this.btn_MainUI.TabIndex = 21;
            this.btn_MainUI.Text = "Màn hình chính";
            this.btn_MainUI.UseVisualStyleBackColor = true;
            this.btn_MainUI.Click += new System.EventHandler(this.btn_MainUI_Click);
            // 
            // pic_star5
            // 
            this.pic_star5.Image = global::MovieWatch.Properties.Resources.star_off;
            this.pic_star5.Location = new System.Drawing.Point(675, 22);
            this.pic_star5.Name = "pic_star5";
            this.pic_star5.Size = new System.Drawing.Size(43, 41);
            this.pic_star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_star5.TabIndex = 20;
            this.pic_star5.TabStop = false;
            this.pic_star5.Click += new System.EventHandler(this.pic_star5_Click);
            // 
            // pic_star4
            // 
            this.pic_star4.Image = global::MovieWatch.Properties.Resources.star_off;
            this.pic_star4.Location = new System.Drawing.Point(607, 22);
            this.pic_star4.Name = "pic_star4";
            this.pic_star4.Size = new System.Drawing.Size(43, 41);
            this.pic_star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_star4.TabIndex = 20;
            this.pic_star4.TabStop = false;
            this.pic_star4.Click += new System.EventHandler(this.pic_star4_Click);
            // 
            // pic_star3
            // 
            this.pic_star3.Image = global::MovieWatch.Properties.Resources.star_off;
            this.pic_star3.Location = new System.Drawing.Point(539, 22);
            this.pic_star3.Name = "pic_star3";
            this.pic_star3.Size = new System.Drawing.Size(43, 41);
            this.pic_star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_star3.TabIndex = 20;
            this.pic_star3.TabStop = false;
            this.pic_star3.Click += new System.EventHandler(this.pic_star3_Click);
            // 
            // pic_star2
            // 
            this.pic_star2.Image = global::MovieWatch.Properties.Resources.star_off;
            this.pic_star2.Location = new System.Drawing.Point(474, 22);
            this.pic_star2.Name = "pic_star2";
            this.pic_star2.Size = new System.Drawing.Size(43, 41);
            this.pic_star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_star2.TabIndex = 20;
            this.pic_star2.TabStop = false;
            this.pic_star2.Click += new System.EventHandler(this.pic_star2_Click);
            // 
            // pic_star1
            // 
            this.pic_star1.Image = global::MovieWatch.Properties.Resources.star_off;
            this.pic_star1.Location = new System.Drawing.Point(406, 22);
            this.pic_star1.Name = "pic_star1";
            this.pic_star1.Size = new System.Drawing.Size(43, 41);
            this.pic_star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_star1.TabIndex = 20;
            this.pic_star1.TabStop = false;
            this.pic_star1.Click += new System.EventHandler(this.pic_star1_Click);
            // 
            // btn_comment
            // 
            this.btn_comment.Location = new System.Drawing.Point(277, 12);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Size = new System.Drawing.Size(107, 50);
            this.btn_comment.TabIndex = 19;
            this.btn_comment.Text = "Bình luận";
            this.btn_comment.UseVisualStyleBackColor = true;
            this.btn_comment.Click += new System.EventHandler(this.btn_comment_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(10, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(107, 50);
            this.btn_Back.TabIndex = 18;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1, 93);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(843, 582);
            this.axWindowsMediaPlayer1.TabIndex = 23;
            // 
            // FilmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 683);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pn_LogIn_Acc);
            this.Controls.Add(this.flp_History);
            this.Controls.Add(this.lbl_namePlaylist);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FilmPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmPlay";
            this.Load += new System.EventHandler(this.FilmPlay_Load);
            this.pn_LogIn_Acc.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_LogIn_Acc;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Button btn_Create_Account;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_star5;
        private System.Windows.Forms.PictureBox pic_star4;
        private System.Windows.Forms.PictureBox pic_star3;
        private System.Windows.Forms.PictureBox pic_star2;
        private System.Windows.Forms.PictureBox pic_star1;
        private System.Windows.Forms.Button btn_comment;
        private System.Windows.Forms.Button btn_Back;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        public System.Windows.Forms.FlowLayoutPanel flp_History;
        public System.Windows.Forms.Label lbl_namePlaylist;
        private System.Windows.Forms.Button btn_MainUI;
    }
}