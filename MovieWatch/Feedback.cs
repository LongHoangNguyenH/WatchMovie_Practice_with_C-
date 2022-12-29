using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MovieWatch
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JMN4VSF\SQLEXPRESS;Initial Catalog=MOVIE;Integrated Security=True");
        SqlDataAdapter cmd = new SqlDataAdapter();



        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comment c = new comment();
                flowLayoutPanel1.Controls.Add(c);
                c.lbl_name.Text = Sign_In.user.username;
                c.lbl_NoiDung.Text = richTextBox1.Text;
                c.lbl_NoiDung.BackColor = Color.White;



                DataRow r = MainUI.storaged_comment.NewRow();
                r["FilmName"] = lbl_name.Text;
                r["Content_comment"] = richTextBox1.Text;
                r["NameUser"] = c.lbl_name.Text;
                MainUI.storaged_comment.Rows.Add(r);

                richTextBox1.Text = "";
            }
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            film_image.ImageLocation = Film.choose_film.url_image;
            film_image.Show();
            lbl_name.Text = Film.choose_film.name;
            lbl_actor.Text=Film.choose_film.actor;
            lbl_country.Text = Film.choose_film.country;
            lbl_year.Text = Film.choose_film.year.ToString();
            comment1.lbl_name.Text = Sign_In.user.username;
            //Load comment tu database

            foreach(DataRow dr in MainUI.storaged_comment.Rows)
            {
                if (lbl_name.Text == dr["FilmName"].ToString())
                {
                    comment c = new comment();
                    flowLayoutPanel1.Controls.Add(c);
                    c.lbl_name.Text = dr["NameUser"].ToString();
                    c.lbl_NoiDung.Text = dr["Content_comment"].ToString();
                    c.lbl_NoiDung.BackColor = Color.White;
                }
            }

        }
    }
}
