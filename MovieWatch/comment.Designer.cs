namespace MovieWatch
{
    partial class comment
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_NoiDung = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Tai Le", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(113, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(541, 38);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "label1";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::MovieWatch.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_NoiDung
            // 
            this.lbl_NoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_NoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoiDung.Location = new System.Drawing.Point(113, 38);
            this.lbl_NoiDung.Name = "lbl_NoiDung";
            this.lbl_NoiDung.Size = new System.Drawing.Size(541, 61);
            this.lbl_NoiDung.TabIndex = 3;
            this.lbl_NoiDung.Text = "label1";
            this.lbl_NoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_NoiDung);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "comment";
            this.Size = new System.Drawing.Size(654, 99);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbl_NoiDung;
        public System.Windows.Forms.Label lbl_name;
    }
}
