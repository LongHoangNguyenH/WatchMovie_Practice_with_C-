using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatch
{
    public class playlist_user
    {
        public List<Film_info> film_info { get; set; }
        public string NamePlaylist { get; set; }
        public playlist_user()
        {
            film_info = new List<Film_info>();
            NamePlaylist = "";
        }
    }

}
