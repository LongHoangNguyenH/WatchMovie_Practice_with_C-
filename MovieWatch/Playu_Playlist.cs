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
    public partial class Playu_Playlist : Form
    {
        public Playu_Playlist()
        {
            InitializeComponent();

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MainUI_Click(object sender, EventArgs e)
        {
            this.Close();
            axWindowsMediaPlayer1.URL = "";
        }


        private void Playu_Playlist_Load(object sender, EventArgs e)
        {
            foreach (Film_info item in CreatePlayList.myplaylist[int.Parse(CreatePlayList.Flag)].film_info)
            {
                string[] row = { item.name };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }

            axWindowsMediaPlayer1.URL = CreatePlayList.myplaylist[int.Parse(CreatePlayList.Flag)].film_info[0].url;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count!=-1)
            //{
            //    int index = 0;
            //    string name = listView1.SelectedItems[0].ToString();
            //    foreach (Film_info item in CreatePlayList.myplaylist[int.Parse(CreatePlayList.Flag)].film_info)
            //    {
            //        //string[] row = { item.name };
            //        //var listViewItem = new ListViewItem(row);
            //        //listView1.Items.Add(listViewItem);
            //        if(item.name == name)
            //        {
            //            axWindowsMediaPlayer1.URL = CreatePlayList.myplaylist[int.Parse(CreatePlayList.Flag)].film_info[index].url;

            //        }
            //        index++;
            //    }
            //}
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = 0;
                string name = listView1.SelectedItems[0].Text.ToString();
                foreach (Film_info item in CreatePlayList.myplaylist[int.Parse(CreatePlayList.Flag)].film_info)
                {
                    //string[] row = { item.name };
                    //var listViewItem = new ListViewItem(row);
                    //listView1.Items.Add(listViewItem);
                    if (item.name == name)
                    {
                        axWindowsMediaPlayer1.URL = CreatePlayList.myplaylist[int.Parse(CreatePlayList.Flag)].film_info[index].url;

                    }
                    index++;
                }
            }
        }

    }
}
