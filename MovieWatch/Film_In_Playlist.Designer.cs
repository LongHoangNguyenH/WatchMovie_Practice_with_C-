namespace MovieWatch
{
    partial class Film_In_Playlist
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
            this.film_image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_rate = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.film_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // film_image
            // 
            this.film_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.film_image.Dock = System.Windows.Forms.DockStyle.Left;
            this.film_image.Location = new System.Drawing.Point(0, 0);
            this.film_image.Name = "film_image";
            this.film_image.Size = new System.Drawing.Size(108, 113);
            this.film_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.film_image.TabIndex = 0;
            this.film_image.TabStop = false;
            this.film_image.Click += new System.EventHandler(this.film_image_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quốc Gia:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MovieWatch.Properties.Resources.star;
            this.pictureBox2.Location = new System.Drawing.Point(306, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_rate
            // 
            this.lbl_rate.AutoSize = true;
            this.lbl_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rate.Location = new System.Drawing.Point(284, 86);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(16, 17);
            this.lbl_rate.TabIndex = 6;
            this.lbl_rate.Text = "0";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_country.Location = new System.Drawing.Point(191, 86);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(68, 17);
            this.lbl_country.TabIndex = 7;
            this.lbl_country.Text = "Quốc Gia";
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(114, 12);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(247, 59);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Name";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Film_In_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_rate);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.film_image);
            this.Name = "Film_In_Playlist";
            this.Size = new System.Drawing.Size(370, 113);
            ((System.ComponentModel.ISupportInitialize)(this.film_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lbl_rate;
        public System.Windows.Forms.Label lbl_country;
        public System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.PictureBox film_image;
    }
}
