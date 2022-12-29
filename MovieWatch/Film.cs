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
    public partial class Film : UserControl
    {
        public static Film_info choose_film = null;
        public static List<Film_info> history = new List<Film_info>();
        public static List<Film_info> FavorList = new List<Film_info>();

        string heart_on_path = "P:\\CS511\\BTH\\Movie\\MovieWatch\\MovieWatch\\Resources\\Heart_on.png";
        string heart_off_path = "P:\\CS511\\BTH\\Movie\\MovieWatch\\MovieWatch\\Resources\\Heart_off.png";


        public Film()
        {
            InitializeComponent();
        }

        private void Film_Click(object sender, EventArgs e)
        {
            Film_UI film_UI = new Film_UI();    
            film_UI.Show();
        }

        private void Film_Load(object sender, EventArgs e)
        {
            pic_heart.ImageLocation = heart_off_path;
        }
        void Add_film(List<Film_info> l,Film_info f)
        {
            int index = 0;
            if (l.Count == 0)
            {
                l.Add(f);
                index++;
            }
            else
            {
                foreach(Film_info fi in l.ToList())
                {
                    if (fi.id == f.id)
                        continue;
                    else if(fi.id != f.id && index == l.Count - 1)
                    {
                        l.Add(f);
                    }
                    index++;
                }
            }
        }
        
        private void Film_Image_Click(object sender, EventArgs e)
        {
            //Load film has choosen
            string film_name=this.lbl_name.Text;
            foreach(DataRow row in MainUI.table_Film.Rows)
            {
                if (row["_FILM_NAME"].ToString() == film_name)
                {
                    choose_film  = new Film_info();
                    choose_film.name=row["_FILM_NAME"].ToString();
                    choose_film.language = row["_FILM_LANGUAGE"].ToString();
                    choose_film.actor = row["_FILM_ACTOR"].ToString();
                    string rate = row["_FILM_RATE"].ToString();
                    choose_film.rate = int.Parse(rate);
                    choose_film.country = row["_FILM_COUNTRY"].ToString();
                    choose_film.content = row["_FILM_CONTENT"].ToString();
                    string year = row["_FILM_YEAR_RELEASE"].ToString();
                    choose_film.year = int.Parse(year);
                    choose_film.genre = row["_FILM_TYPE"].ToString();
                    choose_film.url = row["_FILM_URL"].ToString();
                    choose_film.url_image = row["_FILM_IMAGE_URL"].ToString();
                    string id = row["_ID"].ToString();
                    choose_film.id = int.Parse(id);
                    choose_film.url_web = row["_FILM_WEB_URL"].ToString();
                    Add_film(history,choose_film);

                }
            }
            Film_UI film_UI = new Film_UI();
            film_UI.ShowDialog();
        }

        private void pic_heart_Click(object sender, EventArgs e)
        {
            string film_name = this.lbl_name.Text;
            foreach (DataRow row in MainUI.table_Film.Rows)
            {
                if (row["_FILM_NAME"].ToString() == film_name)
                {
                    choose_film = new Film_info();
                    choose_film.name = row["_FILM_NAME"].ToString();
                    choose_film.language = row["_FILM_LANGUAGE"].ToString();
                    choose_film.actor = row["_FILM_ACTOR"].ToString();
                    string rate = row["_FILM_RATE"].ToString();
                    choose_film.rate = int.Parse(rate);
                    choose_film.country = row["_FILM_COUNTRY"].ToString();
                    choose_film.content = row["_FILM_CONTENT"].ToString();
                    string year = row["_FILM_YEAR_RELEASE"].ToString();
                    choose_film.year = int.Parse(year);
                    choose_film.genre = row["_FILM_TYPE"].ToString();
                    choose_film.url = row["_FILM_URL"].ToString();
                    choose_film.url_image = row["_FILM_IMAGE_URL"].ToString();
                    string id = row["_ID"].ToString();
                    choose_film.id = int.Parse(id);
                    Add_film(history, choose_film);

                }
            }
            if (pic_heart.ImageLocation == heart_off_path)
            {
                choose_film.Favor = true;
                pic_heart.ImageLocation = heart_on_path;
                Add_film(FavorList, choose_film);
                pic_heart.Show();
            }
            else
            {
                choose_film.Favor=false;
                pic_heart.ImageLocation = heart_off_path;
                pic_heart.Show();
                int index = 0;
                foreach (Film_info i in FavorList)
                {
                    if (film_name == i.name)
                    {
                        FavorList.RemoveAt(index);
                        break;
                    }
                    index++;
                }

            }
            
        }
    }
}
