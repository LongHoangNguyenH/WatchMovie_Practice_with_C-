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
    public partial class Sign_In : Form
    {
        string str_connect = @"Data Source=DESKTOP-JMN4VSF\SQLEXPRESS;Initial Catalog=MOVIE;Integrated Security=True";
        SqlConnection conn = null;
        public static DataTable table_Account = new DataTable();
        public Sign_In()
        {
            InitializeComponent();
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "username";
                txt_username.ForeColor = Color.Silver;
            }
        }
        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "username")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.Black;
            }
        }
        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "password";
                txt_password.ForeColor = Color.Silver;
            }
        }
        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "password")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
            }
        }
        public static User user = new User();
        public static bool flag = false;
        private void tn_LogIn_Click(object sender, EventArgs e)
        {
            string query2 = "SELECT * FROM ACCOUNT";
            conn = new SqlConnection(str_connect);
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            conn.Open();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(table_Account);
            conn.Close();
            da2.Dispose();

            foreach (DataRow dr in table_Account.Rows)
            {
                if (dr["_NAME_ACCOUNT"].ToString() == txt_username.Text && dr["_PASSWORD"].ToString() == txt_password.Text)
                {
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            if (flag == true)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công", "Chúc mừng", MessageBoxButtons.OK);
                user.username = txt_username.Text;
                MainUI.IsLogin = true;
                this.Close();
            } 
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_password.Text = "";
            txt_username.Text = "";
            this.Close();
            CreateAccount sign = new CreateAccount();
            sign.ShowDialog();
            
        }
    }
}
