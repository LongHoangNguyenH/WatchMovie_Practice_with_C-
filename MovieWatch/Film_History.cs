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
    public partial class Film_History : UserControl
    {
        public Film_History()
        {
            InitializeComponent();
        }

        private void Film_History_Load(object sender, EventArgs e)
        {

        }

        private void film_image_Click(object sender, EventArgs e)
        {
            
            foreach(Film_info fi in Film.history)
            {
                if( fi.name == this.lbl_name.Text)
                {
                    Film.choose_film = fi;
                }

            }
            if (Film.history.Count > 1)
            {
                Film_UI film_UI = new Film_UI();
                film_UI.ShowDialog();
            }

            

        }
    }
}
