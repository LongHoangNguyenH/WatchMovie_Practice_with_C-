namespace MovieWatch
{
    partial class MainUI
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
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Home = new System.Windows.Forms.Button();
            this.flp_Display = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_action = new System.Windows.Forms.Button();
            this.btn_Romatic = new System.Windows.Forms.Button();
            this.btn_Psychological = new System.Windows.Forms.Button();
            this.btn_Animation = new System.Windows.Forms.Button();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.btn_Create_Account = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flp_History = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_LogIn_Acc = new System.Windows.Forms.Panel();
            this.btn_History = new System.Windows.Forms.Button();
            this.btn_Playlist = new System.Windows.Forms.Button();
            this.btn_Favor = new System.Windows.Forms.Button();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pn_LogIn_Acc.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.Silver;
            this.txt_Search.Location = new System.Drawing.Point(10, 7);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(559, 41);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.Text = "Nhập từ khóa...";
            this.txt_Search.Enter += new System.EventHandler(this.txt_Search_Enter);
            this.txt_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyUp);
            this.txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave);
            // 
            // btn_Home
            // 
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(10, 59);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(107, 50);
            this.btn_Home.TabIndex = 6;
            this.btn_Home.Text = "Trang Chủ";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // flp_Display
            // 
            this.flp_Display.AllowDrop = true;
            this.flp_Display.AutoScroll = true;
            this.flp_Display.BackColor = System.Drawing.Color.OldLace;
            this.flp_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_Display.Location = new System.Drawing.Point(0, 120);
            this.flp_Display.Name = "flp_Display";
            this.flp_Display.Size = new System.Drawing.Size(856, 563);
            this.flp_Display.TabIndex = 7;
            // 
            // btn_action
            // 
            this.btn_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_action.Location = new System.Drawing.Point(123, 59);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(107, 50);
            this.btn_action.TabIndex = 6;
            this.btn_action.Text = "Hành Động";
            this.btn_action.UseVisualStyleBackColor = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // btn_Romatic
            // 
            this.btn_Romatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Romatic.Location = new System.Drawing.Point(236, 59);
            this.btn_Romatic.Name = "btn_Romatic";
            this.btn_Romatic.Size = new System.Drawing.Size(107, 50);
            this.btn_Romatic.TabIndex = 6;
            this.btn_Romatic.Text = "Tình Cảm";
            this.btn_Romatic.UseVisualStyleBackColor = true;
            this.btn_Romatic.Click += new System.EventHandler(this.btn_Romatic_Click);
            // 
            // btn_Psychological
            // 
            this.btn_Psychological.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Psychological.Location = new System.Drawing.Point(349, 59);
            this.btn_Psychological.Name = "btn_Psychological";
            this.btn_Psychological.Size = new System.Drawing.Size(107, 50);
            this.btn_Psychological.TabIndex = 6;
            this.btn_Psychological.Text = "Tâm Lí";
            this.btn_Psychological.UseVisualStyleBackColor = true;
            this.btn_Psychological.Click += new System.EventHandler(this.btn_Psychological_Click);
            // 
            // btn_Animation
            // 
            this.btn_Animation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Animation.Location = new System.Drawing.Point(462, 59);
            this.btn_Animation.Name = "btn_Animation";
            this.btn_Animation.Size = new System.Drawing.Size(107, 50);
            this.btn_Animation.TabIndex = 6;
            this.btn_Animation.Text = "Hoạt Hình";
            this.btn_Animation.UseVisualStyleBackColor = true;
            this.btn_Animation.Click += new System.EventHandler(this.btn_Animation_Click);
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogIn.Location = new System.Drawing.Point(59, 6);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(117, 50);
            this.btn_LogIn.TabIndex = 6;
            this.btn_LogIn.Text = "Đăng Nhập";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_Create_Account
            // 
            this.btn_Create_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Create_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create_Account.Location = new System.Drawing.Point(221, 6);
            this.btn_Create_Account.Name = "btn_Create_Account";
            this.btn_Create_Account.Size = new System.Drawing.Size(113, 50);
            this.btn_Create_Account.TabIndex = 6;
            this.btn_Create_Account.Text = "Đăng  Ký";
            this.btn_Create_Account.UseVisualStyleBackColor = true;
            this.btn_Create_Account.Click += new System.EventHandler(this.btn_Create_Account_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Controls.Add(this.btn_action);
            this.panel1.Controls.Add(this.btn_Romatic);
            this.panel1.Controls.Add(this.btn_Psychological);
            this.panel1.Controls.Add(this.btn_Animation);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Location = new System.Drawing.Point(2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 109);
            this.panel1.TabIndex = 8;
            // 
            // flp_History
            // 
            this.flp_History.AutoScroll = true;
            this.flp_History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flp_History.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_History.Location = new System.Drawing.Point(857, 120);
            this.flp_History.Name = "flp_History";
            this.flp_History.Size = new System.Drawing.Size(385, 563);
            this.flp_History.TabIndex = 9;
            // 
            // pn_LogIn_Acc
            // 
            this.pn_LogIn_Acc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_LogIn_Acc.Controls.Add(this.btn_LogIn);
            this.pn_LogIn_Acc.Controls.Add(this.btn_Create_Account);
            this.pn_LogIn_Acc.Location = new System.Drawing.Point(857, 5);
            this.pn_LogIn_Acc.Name = "pn_LogIn_Acc";
            this.pn_LogIn_Acc.Size = new System.Drawing.Size(385, 64);
            this.pn_LogIn_Acc.TabIndex = 11;
            // 
            // btn_History
            // 
            this.btn_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.Location = new System.Drawing.Point(711, 65);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(140, 50);
            this.btn_History.TabIndex = 12;
            this.btn_History.Text = "Lịch Sử Tìm Kiếm";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_Playlist
            // 
            this.btn_Playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Playlist.Location = new System.Drawing.Point(586, 65);
            this.btn_Playlist.Name = "btn_Playlist";
            this.btn_Playlist.Size = new System.Drawing.Size(119, 50);
            this.btn_Playlist.TabIndex = 13;
            this.btn_Playlist.Text = "Tạo Playlist";
            this.btn_Playlist.UseVisualStyleBackColor = true;
            this.btn_Playlist.Click += new System.EventHandler(this.btn_Playlist_Click);
            // 
            // btn_Favor
            // 
            this.btn_Favor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Favor.Location = new System.Drawing.Point(586, 5);
            this.btn_Favor.Name = "btn_Favor";
            this.btn_Favor.Size = new System.Drawing.Size(265, 49);
            this.btn_Favor.TabIndex = 14;
            this.btn_Favor.Text = "Danh Sách Yêu thích";
            this.btn_Favor.UseVisualStyleBackColor = true;
            this.btn_Favor.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.Location = new System.Drawing.Point(857, 78);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(385, 39);
            this.lbl_TieuDe.TabIndex = 15;
            this.lbl_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1243, 683);
            this.Controls.Add(this.lbl_TieuDe);
            this.Controls.Add(this.btn_Favor);
            this.Controls.Add(this.btn_Playlist);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.pn_LogIn_Acc);
            this.Controls.Add(this.flp_History);
            this.Controls.Add(this.flp_Display);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_LogIn_Acc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.FlowLayoutPanel flp_Display;
        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.Button btn_Romatic;
        private System.Windows.Forms.Button btn_Psychological;
        private System.Windows.Forms.Button btn_Animation;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Button btn_Create_Account;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flp_History;
        private System.Windows.Forms.Panel pn_LogIn_Acc;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button btn_Playlist;
        private System.Windows.Forms.Button btn_Favor;
        private System.Windows.Forms.Label lbl_TieuDe;
    }
}