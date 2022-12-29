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
    public partial class MainUI : Form
    {

        string str_connect = @"Data Source=DESKTOP-JMN4VSF\SQLEXPRESS;Initial Catalog=MOVIE;Integrated Security=True";
        SqlConnection conn = null;
        public static DataTable table_Film = new DataTable();
        public static bool IsLogin = false;
        public static DataTable storaged_comment = new DataTable();
        public static DataTable playlist = new DataTable();
        public MainUI()
        {
            InitializeComponent();
            storaged_comment.Columns.Add("FilmName");
            storaged_comment.Columns.Add("Content_comment");
            storaged_comment.Columns.Add("NameUser");

            playlist.Columns.Add("PlaylistName");
            playlist.Columns.Add("PlaylistFilmName");

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
        private void txt_Search_Leave(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
            {
                txt_Search.Text = "Nhập từ khóa...";
                txt_Search.ForeColor = Color.Silver;
            }
        }
        private void txt_Search_Enter(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Nhập từ khóa...")
            {
                txt_Search.Text = "";
                txt_Search.ForeColor = Color.Black;
            }
        }
        //display film 
        public void Display_film(DataTable table_Film,FlowLayoutPanel flp_Display)
        {
            foreach (DataRow dr in table_Film.Rows)
            {
                Film f = new Film();
                flp_Display.Controls.Add(f);
                f.lbl_country.Text = dr["_FILM_COUNTRY"].ToString();
                f.lbl_name.Text = dr["_FILM_Name"].ToString();
                f.lbl_rate.Text = dr["_FILM_RATE"].ToString();
                f.Film_Image.ImageLocation = dr["_FILM_IMAGE_URL"].ToString();
                f.Film_Image.SizeMode = PictureBoxSizeMode.StretchImage;
                f.Film_Image.Show();
            }
        }
        private void MainUI_Load(object sender, EventArgs e)
        {
            #region Connect to database & Load film to dataTable
             string query2 = "SELECT * FROM FILM";
             conn = new SqlConnection(str_connect);
             SqlCommand cmd2 = new SqlCommand(query2, conn);
             conn.Open();
             SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
             da2.Fill(table_Film);
             conn.Close();
             da2.Dispose();
            #endregion
            #region Load film to UI
            Display_film(table_Film, flp_Display);
            #endregion

        }
        #region devide topic
        void ChangeTopic(DataTable dt,string query)
        {
            flp_Display.Controls.Clear();
            conn = new SqlConnection(str_connect);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            Display_film(dt, flp_Display);
        }
        public void btn_action_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            DataTable action_table = new DataTable();
            string query = "SELECT * FROM FILM " +
                           "WHERE _FILM_TYPE = N'Hành động'";
            ChangeTopic(action_table, query);
        }
        private void btn_Psychological_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            DataTable Psychological_table = new DataTable();
            string query = "SELECT * FROM FILM " +
                           "WHERE _FILM_TYPE = N'Tâm lí'";
            ChangeTopic(Psychological_table, query);
        }
        private void btn_Romatic_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            DataTable Romantic_table = new DataTable();
            string query = "SELECT * FROM FILM " +
                            "WHERE _FILM_TYPE = N'Tình cảm'";
            ChangeTopic(Romantic_table, query);
        }
        private void btn_Animation_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            DataTable Animation_table = new DataTable();
            string query = "SELECT * FROM FILM " +
                            "WHERE _FILM_TYPE = N'Hoạt hình'";
            ChangeTopic(Animation_table, query);
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            table_Film.Clear();
            txt_Search.Text = "";
            flp_Display.Controls.Clear();
            MainUI_Load(sender, e);
        }
        #endregion

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                flp_Display.Controls.Clear();
                DataRow[] filteredRows = new DataRow[table_Film.Rows.Count];
                filteredRows = table_Film.Select("_FILM_NAME LIKE '%" + txt_Search.Text.Trim() + "%'");
                foreach(DataRow row in filteredRows)
                {
                    Film f = new Film();
                    flp_Display.Controls.Add(f);
                    f.lbl_country.Text = row["_FILM_COUNTRY"].ToString();
                    f.lbl_name.Text = row["_FILM_NAME"].ToString();
                    f.lbl_rate.Text = row["_FILM_RATE"].ToString();
                    f.Film_Image.ImageLocation = row["_FILM_IMAGE_URL"].ToString();
                    f.Film_Image.SizeMode = PictureBoxSizeMode.StretchImage;
                    f.Film_Image.Show();
                }
                
            }

        }
        private void btn_History_Click(object sender, EventArgs e)
        {
            lbl_TieuDe.Text = "Lịch Sử Tìm Kiếm";
            flp_History.Controls.Clear();
            foreach(Film_info film in Film.history)
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
        private void button2_Click(object sender, EventArgs e)
        {
            lbl_TieuDe.Text = "Danh Sách Yêu Thích";
            flp_History.Controls.Clear();
            foreach (Film_info film in Film.FavorList)
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
        private void btn_Playlist_Click(object sender, EventArgs e)
        {

            CreatePlayList cpl = new CreatePlayList();
            cpl.ShowDialog();
        }
    }
}
