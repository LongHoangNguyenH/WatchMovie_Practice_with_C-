namespace MovieWatch
{
    partial class Film
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_rate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_heart = new System.Windows.Forms.PictureBox();
            this.rate_image = new System.Windows.Forms.PictureBox();
            this.Film_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Film_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(4, 324);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(270, 45);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Tên phim";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_country
            // 
            this.lbl_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_country.Location = new System.Drawing.Point(70, 367);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(107, 39);
            this.lbl_country.TabIndex = 2;
            this.lbl_country.Text = "Quốc gia";
            this.lbl_country.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_rate
            // 
            this.lbl_rate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_rate.AutoSize = true;
            this.lbl_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rate.Location = new System.Drawing.Point(224, 377);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(20, 24);
            this.lbl_rate.TabIndex = 2;
            this.lbl_rate.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quốc gia:";
            // 
            // pic_heart
            // 
            this.pic_heart.Image = global::MovieWatch.Properties.Resources.Heart_off;
            this.pic_heart.Location = new System.Drawing.Point(183, 372);
            this.pic_heart.Name = "pic_heart";
            this.pic_heart.Size = new System.Drawing.Size(36, 34);
            this.pic_heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_heart.TabIndex = 5;
            this.pic_heart.TabStop = false;
            this.pic_heart.Click += new System.EventHandler(this.pic_heart_Click);
            // 
            // rate_image
            // 
            this.rate_image.Image = global::MovieWatch.Properties.Resources.star;
            this.rate_image.Location = new System.Drawing.Point(241, 372);
            this.rate_image.Name = "rate_image";
            this.rate_image.Size = new System.Drawing.Size(24, 31);
            this.rate_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rate_image.TabIndex = 4;
            this.rate_image.TabStop = false;
            // 
            // Film_Image
            // 
            this.Film_Image.Dock = System.Windows.Forms.DockStyle.Top;
            this.Film_Image.Location = new System.Drawing.Point(0, 0);
            this.Film_Image.Name = "Film_Image";
            this.Film_Image.Size = new System.Drawing.Size(277, 318);
            this.Film_Image.TabIndex = 0;
            this.Film_Image.TabStop = false;
            this.Film_Image.Click += new System.EventHandler(this.Film_Image_Click);
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pic_heart);
            this.Controls.Add(this.rate_image);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_rate);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.Film_Image);
            this.Name = "Film";
            this.Size = new System.Drawing.Size(277, 409);
            this.Load += new System.EventHandler(this.Film_Load);
            this.Click += new System.EventHandler(this.Film_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pic_heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Film_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox Film_Image;
        public System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.Label lbl_country;
        public System.Windows.Forms.Label lbl_rate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox rate_image;
        private System.Windows.Forms.PictureBox pic_heart;
    }
}
