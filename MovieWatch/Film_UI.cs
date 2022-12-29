using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using VideoLibrary;
namespace MovieWatch
{
    public partial class Film_UI : Form
    {
        public Film_UI()
        {
            InitializeComponent();
            pic_star1.ImageLocation = path_star;
            pic_star2.ImageLocation = path_star;
            pic_star3.ImageLocation = path_star;
            pic_star4.ImageLocation = path_star;
            pic_star5.ImageLocation = path_star;
        }
        string path_shine_star = "P:\\CS511\\BTH\\Movie\\MovieWatch\\MovieWatch\\Resources\\star_on.png";
        string path_star = "P:\\CS511\\BTH\\Movie\\MovieWatch\\MovieWatch\\Resources\\star_off.png";
        private void btn_Back_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void Film_UI_Load(object sender, EventArgs e)
        {
            if (MainUI.IsLogin == true)
            {
                pn_LogIn_Acc.Visible = false;
                //this.Controls.Remove(pn_LogIn_Acc);
                pn_LogIn_Acc.SendToBack();

                Button Logout = new Button();
                this.Controls.Add(Logout);
                Logout.Size = new Size(117, 50);
                Logout.Location = new Point(997, 13);
                Logout.Text = "Đăng Xuất";
                Logout.BackColor = Color.White;
                Logout.Click += LogoutClick;
            }

            lbl_name.Text = Film.choose_film.name;
            lbl_language.Text = Film.choose_film.language;
            lbl_genre.Text=Film.choose_film.genre;
            lbl_country.Text = Film.choose_film.country;
            lbl_actor.Text = Film.choose_film.actor;
            lbl_rate.Text = Film.choose_film.rate.ToString();
            lbl_year.Text = Film.choose_film.year.ToString();
            lbl_content.Text = Film.choose_film.content;
            film_image.ImageLocation = Film.choose_film.url_image;
            film_image.Show();

            flp_History.Controls.Clear();
            foreach (Film_info film in Film.history)
            {
                Film_History h = new Film_History();
                flp_History.Controls.Add(h);
                h.lbl_country.Text = film.country;
                h.lbl_name.Text = film.name;
                h.lbl_rate.Text = film.rate.ToString();
                h.film_image.ImageLocation = film.url_image;
                h.film_image.Show();
            }

        }

        private void LogoutClick(object sender, EventArgs e)
        {
            Sign_In.user.password = "";
            Sign_In.user.username = "";
            Sign_In.user.name_account = "";
            MainUI.IsLogin=false;
            MessageBox.Show("Bạn đã đăng xuất thành công");
        }

        private void btn_watch_Click(object sender, EventArgs e)
        {
            FilmPlay fl = new FilmPlay();
            fl.ShowDialog(this);
            this.Close();

        }
        private void btn_Download_Click(object sender, EventArgs e)
        {
            var youTube = YouTube.Default;
            var video = youTube.GetVideo(Film.choose_film.url_web);
            File.WriteAllBytes(@"D:\" + video.FullName, video.GetBytes());
            MessageBox.Show("Đã tải về thành công","Chúc Mừng");
        }

        private void star1_Click(object sender, EventArgs e)
        {
            if (pic_star1.ImageLocation == path_star)
            {
                pic_star1.ImageLocation = path_shine_star;
                pic_star1.Show();
                pic_star2.ImageLocation = path_star;
                pic_star3.ImageLocation = path_star;
                pic_star4.ImageLocation = path_star;
                pic_star5.ImageLocation = path_star;
                pic_star2.Show();
                pic_star3.Show();
                pic_star4.Show();
                pic_star5.Show();
            }
            else
            {
                pic_star2.ImageLocation = path_star;
                pic_star3.ImageLocation = path_star;
                pic_star4.ImageLocation = path_star;
                pic_star5.ImageLocation = path_star;
                pic_star2.Show();
                pic_star3.Show();
                pic_star4.Show();
                pic_star5.Show();
                pic_star1.Show();
            }
        }
        private void star2_Click(object sender, EventArgs e)
        {
            if (pic_star2.ImageLocation == path_star)
            {
                pic_star1.ImageLocation = path_shine_star;
                pic_star2.ImageLocation = path_shine_star;
                pic_star1.Show();
                pic_star2.Show();
            }
            else
            {
                pic_star3.ImageLocation = path_star;
                pic_star4.ImageLocation = path_star;
                pic_star5.ImageLocation = path_star;
                pic_star1.Show();
                pic_star2.Show();
                pic_star1.Show();
                pic_star2.Show();
                pic_star3.Show();
            }
        }
        private void star3_Click(object sender, EventArgs e)
        {
            if (pic_star3.ImageLocation == path_star)
            {
                pic_star1.ImageLocation = path_shine_star;
                pic_star2.ImageLocation = path_shine_star;
                pic_star3.ImageLocation = path_shine_star;
                pic_star1.Show();
                pic_star2.Show();
                pic_star3.Show();

            }
            else
            {
                pic_star4.ImageLocation = path_star;
                pic_star5.ImageLocation = path_star;
                pic_star1.Show();
                pic_star2.Show();
                pic_star3.Show();
                pic_star4.Show();
                pic_star5.Show();
            }
        }
        private void star4_Click(object sender, EventArgs e)
        {
            if (pic_star4.ImageLocation == path_star)
            {
                pic_star1.ImageLocation = path_shine_star;
                pic_star2.ImageLocation = path_shine_star;
                pic_star3.ImageLocation = path_shine_star;
                pic_star4.ImageLocation = path_shine_star;
                pic_star1.Show();
                pic_star2.Show();
                pic_star3.Show();
                pic_star4.Show();
            }
            else
            {
                pic_star5.ImageLocation = path_star;
                pic_star1.Show();
                pic_star2.Show();
                pic_star3.Show();
                pic_star4.Show();
                pic_star5.Show();
            }
        }
        private void star5_Click(object sender, EventArgs e)
        {
            if (pic_star5.ImageLocation == path_star)
            {

                pic_star1.ImageLocation = path_shine_star;
                pic_star2.ImageLocation = path_shine_star;
                pic_star3.ImageLocation = path_shine_star;
                pic_star4.ImageLocation = path_shine_star;
                pic_star5.ImageLocation = path_shine_star;
                pic_star1.Show();
                pic_star2.Show();
                pic_star3.Show();
                pic_star4.Show();
                pic_star5.Show();
            }
        }
        private void btn_comment_Click(object sender, EventArgs e)
        {
            if (MainUI.IsLogin == false)
            {
                MessageBox.Show("Bạn phải đăng nhập trước");
            }
            else
            {
                Feedback fb = new Feedback();
                fb.ShowDialog();
            }
        }
        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            Sign_In signin = new Sign_In();
            signin.ShowDialog();
        }
        private void btn_Create_Account_Click(object sender, EventArgs e)
        {
            CreateAccount acc = new CreateAccount();
            acc.ShowDialog();
        }

        private void pn_LogIn_Acc_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
