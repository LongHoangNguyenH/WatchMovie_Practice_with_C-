using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatch
{
    public class Film_info
    {
        public int id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }
        public int year { get; set; }
        public string actor { get; set; }
        public string language { get; set; }
        public int rate { get; set; }
        public string country { get; set; }
        public string content { get; set; }
        public string url { get; set; }
        public string url_image { get; set; }
        public string url_web { get; set; }
        public bool Favor { get; set; }

        public Film_info()
        {
            id = 0;
            name = "";
            genre = "";
            year = 2000;
            actor = "";
            language = "Phụ đề Việt";
            rate = 6;
            country = "Âu - Mỹ";
            content = "";
            url = "";
            url_image = "";
            url_web = "";
            Favor = false;
        }
        public Film_info(bool favor,int id, string name, string genre, int year, string actor, string language, int rate, string country, string content, string url, string url_image)
        {
            this.id = id;
            this.name = name;
            this.genre = genre;
            this.year = year;
            this.actor = actor;
            this.language = language;
            this.rate = rate;
            this.country = country;
            this.content = content;
            this.url = url;
            this.url_image = url_image;
            this.Favor = favor;
        }


    }

}
