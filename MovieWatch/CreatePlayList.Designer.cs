namespace MovieWatch
{
    partial class CreatePlayList
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
            this.flp_DanhSachPhim = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_XoaPlayList = new System.Windows.Forms.Button();
            this.btn_TaoPlayList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_PhatPlayList = new System.Windows.Forms.Button();
            this.txt_TenPlayList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ThemPhim = new System.Windows.Forms.Button();
            this.btn_XoaPhim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Listview_ListFilm = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_DanhSachPhim
            // 
            this.flp_DanhSachPhim.AutoScroll = true;
            this.flp_DanhSachPhim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_DanhSachPhim.Dock = System.Windows.Forms.DockStyle.Right;
            this.flp_DanhSachPhim.Location = new System.Drawing.Point(908, 0);
            this.flp_DanhSachPhim.Name = "flp_DanhSachPhim";
            this.flp_DanhSachPhim.Size = new System.Drawing.Size(372, 641);
            this.flp_DanhSachPhim.TabIndex = 0;
            // 
            // btn_XoaPlayList
            // 
            this.btn_XoaPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaPlayList.Location = new System.Drawing.Point(160, 52);
            this.btn_XoaPlayList.Name = "btn_XoaPlayList";
            this.btn_XoaPlayList.Size = new System.Drawing.Size(132, 50);
            this.btn_XoaPlayList.TabIndex = 1;
            this.btn_XoaPlayList.Text = "Xóa Playlist";
            this.btn_XoaPlayList.UseVisualStyleBackColor = true;
            this.btn_XoaPlayList.Click += new System.EventHandler(this.btn_XoaPlayList_Click);
            // 
            // btn_TaoPlayList
            // 
            this.btn_TaoPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoPlayList.Location = new System.Drawing.Point(8, 52);
            this.btn_TaoPlayList.Name = "btn_TaoPlayList";
            this.btn_TaoPlayList.Size = new System.Drawing.Size(132, 50);
            this.btn_TaoPlayList.TabIndex = 1;
            this.btn_TaoPlayList.Text = "Tạo PlayList";
            this.btn_TaoPlayList.UseVisualStyleBackColor = true;
            this.btn_TaoPlayList.Click += new System.EventHandler(this.btn_TaoPlayList_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_PhatPlayList);
            this.panel1.Controls.Add(this.txt_TenPlayList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_TaoPlayList);
            this.panel1.Controls.Add(this.btn_XoaPlayList);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 157);
            this.panel1.TabIndex = 2;
            // 
            // btn_PhatPlayList
            // 
            this.btn_PhatPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhatPlayList.Location = new System.Drawing.Point(311, 52);
            this.btn_PhatPlayList.Name = "btn_PhatPlayList";
            this.btn_PhatPlayList.Size = new System.Drawing.Size(132, 50);
            this.btn_PhatPlayList.TabIndex = 4;
            this.btn_PhatPlayList.Text = "Phát PlayList";
            this.btn_PhatPlayList.UseVisualStyleBackColor = true;
            this.btn_PhatPlayList.Click += new System.EventHandler(this.btn_PhatPlayList_Click);
            // 
            // txt_TenPlayList
            // 
            this.txt_TenPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenPlayList.ForeColor = System.Drawing.Color.Silver;
            this.txt_TenPlayList.Location = new System.Drawing.Point(79, 109);
            this.txt_TenPlayList.Multiline = true;
            this.txt_TenPlayList.Name = "txt_TenPlayList";
            this.txt_TenPlayList.Size = new System.Drawing.Size(279, 32);
            this.txt_TenPlayList.TabIndex = 3;
            this.txt_TenPlayList.Text = "Nhập tên playlist...";
            this.txt_TenPlayList.Enter += new System.EventHandler(this.txt_TenPlayList_Enter);
            this.txt_TenPlayList.Leave += new System.EventHandler(this.txt_TenPlayList_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLAYLIST CONTROL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_ThemPhim);
            this.panel2.Controls.Add(this.btn_XoaPhim);
            this.panel2.Location = new System.Drawing.Point(461, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 157);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "FILM CONTROL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ThemPhim
            // 
            this.btn_ThemPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemPhim.Location = new System.Drawing.Point(73, 63);
            this.btn_ThemPhim.Name = "btn_ThemPhim";
            this.btn_ThemPhim.Size = new System.Drawing.Size(132, 50);
            this.btn_ThemPhim.TabIndex = 1;
            this.btn_ThemPhim.Text = "Thêm Phim";
            this.btn_ThemPhim.UseVisualStyleBackColor = true;
            this.btn_ThemPhim.Click += new System.EventHandler(this.btn_ThemPhim_Click);
            // 
            // btn_XoaPhim
            // 
            this.btn_XoaPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaPhim.Location = new System.Drawing.Point(245, 63);
            this.btn_XoaPhim.Name = "btn_XoaPhim";
            this.btn_XoaPhim.Size = new System.Drawing.Size(132, 50);
            this.btn_XoaPhim.TabIndex = 1;
            this.btn_XoaPhim.Text = "Xóa Phim";
            this.btn_XoaPhim.UseVisualStyleBackColor = true;
            this.btn_XoaPhim.Click += new System.EventHandler(this.btn_XoaPhim_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên PlayList";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Danh Sách Phim";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Danh Sách Phim";
            this.columnHeader1.Width = 442;
            // 
            // Listview_ListFilm
            // 
            this.Listview_ListFilm.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Listview_ListFilm.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Listview_ListFilm.AllowDrop = true;
            this.Listview_ListFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Listview_ListFilm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Listview_ListFilm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.Listview_ListFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listview_ListFilm.FullRowSelect = true;
            this.Listview_ListFilm.GridLines = true;
            this.Listview_ListFilm.HideSelection = false;
            this.Listview_ListFilm.HoverSelection = true;
            this.Listview_ListFilm.Location = new System.Drawing.Point(461, 203);
            this.Listview_ListFilm.Name = "Listview_ListFilm";
            this.Listview_ListFilm.Size = new System.Drawing.Size(444, 438);
            this.Listview_ListFilm.TabIndex = 5;
            this.Listview_ListFilm.UseCompatibleStateImageBehavior = false;
            this.Listview_ListFilm.View = System.Windows.Forms.View.Details;
            this.Listview_ListFilm.Click += new System.EventHandler(this.Listview_ListFilm_Click);
            // 
            // CreatePlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1280, 641);
            this.Controls.Add(this.Listview_ListFilm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flp_DanhSachPhim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreatePlayList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePlayList";
            this.Load += new System.EventHandler(this.CreatePlayList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_DanhSachPhim;
        private System.Windows.Forms.Button btn_XoaPlayList;
        private System.Windows.Forms.Button btn_TaoPlayList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ThemPhim;
        private System.Windows.Forms.Button btn_XoaPhim;
        private System.Windows.Forms.TextBox txt_TenPlayList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_PhatPlayList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView Listview_ListFilm;
    }
}