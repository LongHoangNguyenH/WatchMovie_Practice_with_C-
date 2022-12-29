using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieWatch
{
    public partial class FilmPlay : Form
    {
        public FilmPlay()
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
            axWindowsMediaPlayer1.URL = "";
            this.Close();
        }

        private void FilmPlay_Load(object sender, EventArgs e)
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
            axWindowsMediaPlayer1.URL = Film.choose_film.url;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void LogoutClick(object sender, EventArgs e)
        {
            Sign_In.user.password = "";
            Sign_In.user.username = "";
            Sign_In.user.name_account = "";
            MainUI.IsLogin = false;
            MessageBox.Show("Bạn đã đăng xuất thành công");

        }

        private void pic_star1_Click(object sender, EventArgs e)
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
        private void pic_star2_Click(object sender, EventArgs e)
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
        private void pic_star3_Click(object sender, EventArgs e)
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
        private void pic_star4_Click(object sender, EventArgs e)
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
        private void pic_star5_Click(object sender, EventArgs e)
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

        private void btn_MainUI_Click(object sender, EventArgs e)
        {
            this.Close();
            axWindowsMediaPlayer1.URL = "";
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
    }
}
