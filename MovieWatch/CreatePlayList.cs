using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MovieWatch
{
    public partial class CreatePlayList : Form
    {
        public CreatePlayList()
        {
            InitializeComponent();


        }

        //bool IsPlayListNameEmpty = true;
        static int x = 7, y = 203;
        static int amount_of_playlist = 1;
        private void CreatePlayList_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in MainUI.table_Film.Rows)
            {
                Film_In_Playlist f = new Film_In_Playlist();
                flp_DanhSachPhim.Controls.Add(f);
                f.lbl_country.Text = dr["_FILM_COUNTRY"].ToString();
                f.lbl_name.Text = dr["_FILM_Name"].ToString();
                f.lbl_rate.Text = dr["_FILM_RATE"].ToString();
                f.film_image.ImageLocation = dr["_FILM_IMAGE_URL"].ToString();
                f.film_image.SizeMode = PictureBoxSizeMode.StretchImage;
                f.film_image.Show();
            }
        }
        public static List<playlist_user> myplaylist = new List<playlist_user>();
        private void txt_TenPlayList_Leave(object sender, EventArgs e)
        {
            if (txt_TenPlayList.Text =="")
            {
                txt_TenPlayList.Text = "Nhập tên playlist...";
                txt_TenPlayList.ForeColor = Color.Silver;
            }
        }
        private void txt_TenPlayList_Enter(object sender, EventArgs e)
        {
            if (txt_TenPlayList.Text == "Nhập tên playlist...")
            {
                txt_TenPlayList.Text = "";
                txt_TenPlayList.ForeColor = Color.Black;
            }
        }

        public static int tag = 0;
        Button playlist0;
        Button playlist1;
        Button playlist2;
        Button playlist3;
        Button playlist4;
        int index = 0;
        private void btn_TaoPlayList_Click(object sender, EventArgs e)
        {
            if (txt_TenPlayList.Text == "" || txt_TenPlayList.Text == "Nhập tên playlist...")
                MessageBox.Show("Yêu Cầu nhập Tên PlayList");
            else
            {
                if (amount_of_playlist > 5)
                {
                    MessageBox.Show("Chỉ có thể tạo tối đa 5 Playlist");
                    txt_TenPlayList.Text = "";
                }
                else
                {
                    amount_of_playlist += 1;
                    if(index == 0)
                    {
                        playlist0 = new Button();
                        this.Controls.Add(playlist0);
                        playlist0.Text = txt_TenPlayList.Text;
                        playlist0.Size = new Size(444, 51);
                        playlist0.Location = new Point(x, y);
                        playlist0.BackColor = Color.Beige;
                        playlist0.Tag = tag.ToString();
             
                        tag++;
                        index = index + 1;
                        y = y + 80;
                        playlist0.Click += ChonPlaylistClick;
                    }
                    else if(index == 1)
                    {
                        playlist1 = new Button();
                        this.Controls.Add(playlist1);
                        playlist1.Text = txt_TenPlayList.Text;
                        playlist1.Size = new Size(444, 51);
                        playlist1.Location = new Point(x, y);
                        playlist1.BackColor = Color.Beige;
                        playlist1.Tag = tag.ToString();
                        tag++;
                        index++;
                        y = y + 80;
                        playlist1.Click += ChonPlaylistClick;
                    }
                    else if(index == 2)
                    {
                        playlist2 = new Button();
                        this.Controls.Add(playlist2);
                        playlist2.Text = txt_TenPlayList.Text;
                        playlist2.Size = new Size(444, 51);
                        playlist2.Location = new Point(x, y);
                        playlist2.BackColor = Color.Beige;
                        playlist2.Tag = tag.ToString();
                        tag++;
                        index++;
                        y = y + 80;
                        playlist2.Click += ChonPlaylistClick;
                    }
                    else if(index == 3)
                    {
                        playlist3 = new Button();
                        this.Controls.Add(playlist3);
                        playlist3.Text = txt_TenPlayList.Text;
                        playlist3.Size = new Size(444, 51);
                        playlist3.Location = new Point(x, y);
                        playlist3.BackColor = Color.Beige;
                        playlist3.Tag = tag.ToString();
                        tag++;
                        index++;
                        y = y + 80;
                        playlist3.Click += ChonPlaylistClick;
                    }
                    else
                    {
                        playlist4 = new Button();
                        this.Controls.Add(playlist4);
                        playlist4.Text = txt_TenPlayList.Text;
                        playlist4.Size = new Size(444, 51);
                        playlist4.Location = new Point(x, y);
                        playlist4.BackColor = Color.Beige;
                        playlist4.Tag = tag.ToString();
                        tag++;
                        index++;
                        y = y + 80;
                        playlist4.Click += ChonPlaylistClick;
                    }

                    // add name playlist into myplaylist
                    playlist_user item = new playlist_user();
                    item.NamePlaylist = txt_TenPlayList.Text;

                    myplaylist.Add(item);
                    // refresh playlist name
                    txt_TenPlayList.Text = "";
                }
            }
            //mmới chỉ thêm tên playlist vào từng playlist trong danh sách myplaylist

            //tạo 1 biến đánh dấu khi click vào button nào thì đánh dấu là nameplaylist là cái đó
            //sau đó dựa vào name playlist thì add phim vào từng playlist
        }
        public static string Flag = "";
        private void btn_ThemPhim_Click(object sender, EventArgs e)
        {
            switch (int.Parse(Flag))
            {
                case 0:               
                    Add_Movie_Into_Playlist_Has_Flag_is_Flag(myplaylist[0].film_info,Film_In_Playlist.choose_film_from_playlist);
                    string[] row = { Film_In_Playlist.choose_film_from_playlist.name};
                    var listViewItem = new ListViewItem(row);
                    Listview_ListFilm.Items.Add(listViewItem);
                    break;
                case 1:
                    Add_Movie_Into_Playlist_Has_Flag_is_Flag(myplaylist[1].film_info, Film_In_Playlist.choose_film_from_playlist);
                    string[] row1 = { Film_In_Playlist.choose_film_from_playlist.name };
                    var listViewItem1 = new ListViewItem(row1);
                    Listview_ListFilm.Items.Add(listViewItem1);
                    break;
                case 2:
                    Add_Movie_Into_Playlist_Has_Flag_is_Flag(myplaylist[2].film_info, Film_In_Playlist.choose_film_from_playlist);
                    string[] row2 = { Film_In_Playlist.choose_film_from_playlist.name };
                    var listViewItem2 = new ListViewItem(row2);
                    Listview_ListFilm.Items.Add(listViewItem2);
                    break;
                case 3:
                    Add_Movie_Into_Playlist_Has_Flag_is_Flag(myplaylist[3].film_info, Film_In_Playlist.choose_film_from_playlist);
                    string[] row3 = { Film_In_Playlist.choose_film_from_playlist.name };
                    var listViewItem3 = new ListViewItem(row3);
                    Listview_ListFilm.Items.Add(listViewItem3);
                    break;
                case 4:
                    Add_Movie_Into_Playlist_Has_Flag_is_Flag(myplaylist[4].film_info, Film_In_Playlist.choose_film_from_playlist);
                    string[] row4 = { Film_In_Playlist.choose_film_from_playlist.name };
                    var listViewItem4 = new ListViewItem(row4);
                    Listview_ListFilm.Items.Add(listViewItem4);
                    break;
                default:
                    break;
            }
        }
        private void Add_Movie_Into_Playlist_Has_Flag_is_Flag(List<Film_info> l,Film_info f)
        {
            int index = 0;
            if (l.Count == 0)
            {
                l.Add(f);
                index++;
            }
            else
            {
                foreach (Film_info fi in l.ToList())
                {
                    if (fi.id == f.id)
                        continue;
                    else if (fi.id != f.id && index == l.Count - 1)
                    {
                        l.Add(f);
                    }
                    index++;
                }
            }
        }
        private void btn_XoaPhim_Click(object sender, EventArgs e)
        {
            if (Listview_ListFilm.SelectedItems.Count > 0)
            {
                Listview_ListFilm.Items.Remove(Listview_ListFilm.SelectedItems[0]);
                foreach (Film_info f in myplaylist[int.Parse(Flag)].film_info)
                {
                    if (f.name == name)
                    {
                        myplaylist[int.Parse(Flag)].film_info.Remove(f);
                        break;
                    }
                }
            }
            else
            {
                return;
            }
        }
        private void btn_XoaPlayList_Click(object sender, EventArgs e)
        {

            switch (int.Parse(Flag))
            {
                case 0:
                    this.Controls.Remove(playlist0);
                    myplaylist.Remove(myplaylist[int.Parse(Flag)]);

                    break;
                case 1:
                    this.Controls.Remove(playlist1);
                    myplaylist.Remove(myplaylist[int.Parse(Flag)]);
                    break;
                case 2:
                    this.Controls.Remove(playlist2);
                    myplaylist.Remove(myplaylist[int.Parse(Flag)]);
                    break;
                case 3:
                    this.Controls.Remove(playlist3);
                    myplaylist.Remove(myplaylist[int.Parse(Flag)]);
                    break;
                case 4:
                    this.Controls.Remove(playlist4);
                    myplaylist.Remove(myplaylist[int.Parse(Flag)]);
                    break;
                default:
                    break;
            }
        }
        private void btn_PhatPlayList_Click(object sender, EventArgs e)
        {
            Playu_Playlist playu_Playlist = new Playu_Playlist();
            playu_Playlist.ShowDialog();  
        }

        static string name;
        private void Listview_ListFilm_Click(object sender, EventArgs e)
        {
            if (Listview_ListFilm.SelectedItems.Count > 0)
            {
                name = Listview_ListFilm.SelectedItems[0].Text.ToString();
            }
        }

        private void ChonPlaylistClick(object sender, EventArgs e)
        {   
            Button btn = sender as Button;
            Flag = btn.Tag.ToString();
            //Clear all item in the tableLayoutPanel

            Listview_ListFilm.Items.Clear();

            //Show all item in the tableLayoutPanel
            if (myplaylist[int.Parse(Flag)].film_info.Count > 0) {
                foreach (Film_info f in myplaylist[int.Parse(Flag)].film_info)
                {
                    string[] row4 = { f.name };
                    var listViewItem4 = new ListViewItem(row4);
                    Listview_ListFilm.Items.Add(listViewItem4);
                }
            }
        }
    }
}
