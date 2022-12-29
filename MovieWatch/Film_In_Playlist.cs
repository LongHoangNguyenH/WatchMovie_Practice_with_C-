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
    public partial class Film_In_Playlist : UserControl
    {
        public Film_In_Playlist()
        {
            InitializeComponent();
        }
        public static Film_info choose_film_from_playlist = new Film_info();


        private void film_image_Click(object sender, EventArgs e)
        {
            string film_name = this.lbl_name.Text;
            foreach (DataRow row in MainUI.table_Film.Rows)
            {
                if (row["_FILM_NAME"].ToString() == film_name)
                {
                    choose_film_from_playlist = new Film_info();
                    choose_film_from_playlist.name = row["_FILM_NAME"].ToString();
                    choose_film_from_playlist.language = row["_FILM_LANGUAGE"].ToString();
                    choose_film_from_playlist.actor = row["_FILM_ACTOR"].ToString();
                    string rate = row["_FILM_RATE"].ToString();
                    choose_film_from_playlist.rate = int.Parse(rate);
                    choose_film_from_playlist.country = row["_FILM_COUNTRY"].ToString();
                    choose_film_from_playlist.content = row["_FILM_CONTENT"].ToString();
                    string year = row["_FILM_YEAR_RELEASE"].ToString();
                    choose_film_from_playlist.year = int.Parse(year);
                    choose_film_from_playlist.genre = row["_FILM_TYPE"].ToString();
                    choose_film_from_playlist.url = row["_FILM_URL"].ToString();
                    choose_film_from_playlist.url_image = row["_FILM_IMAGE_URL"].ToString();
                    string id = row["_ID"].ToString();
                    choose_film_from_playlist.id = int.Parse(id);
                    choose_film_from_playlist.url_web = row["_FILM_WEB_URL"].ToString();
                    //add film da chon vao myplaylist voi ten playlist tuong ung


                }
            }
        }
    }
}
