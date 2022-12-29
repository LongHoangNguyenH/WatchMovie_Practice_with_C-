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
    public partial class CreateAccount : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JMN4VSF\SQLEXPRESS;Initial Catalog=MOVIE;Integrated Security=True");
        SqlDataAdapter cmd = new SqlDataAdapter();

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
        #region HieuUng
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Username";
                txt_username.ForeColor = Color.Silver;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Username")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.Black;
            }
        }
        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.ForeColor = Color.Silver;
            }
        }
        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
            }
        }
        private void txt_confirm_password_Leave(object sender, EventArgs e)
        {
            if (txt_confirm_password.Text == "")
            {
                txt_confirm_password.Text = "Confirm Password";
                txt_confirm_password.ForeColor = Color.Silver;
            }
        }
        private void txt_confirm_password_Enter(object sender, EventArgs e)
        {
            if (txt_confirm_password.Text == "Confirm Password")
            {
                txt_confirm_password.Text = "";
                txt_confirm_password.ForeColor = Color.Black;
            }
        }
        #endregion
        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Close();
            Sign_In signin = new Sign_In();
            signin.ShowDialog();
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (txt_confirm_password.Text == "Confirm Password" || txt_password.Text == "Password" || txt_username.Text == "Username" || txt_username.Text == "" || txt_password.Text == "" || txt_confirm_password.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin", "Nhắc nhở", MessageBoxButtons.OKCancel);
                flag = false;
            }
            else if(txt_confirm_password.Text!=txt_password.Text&&flag==true)
                MessageBox.Show("Mật khẩu không khớp", "Cảnh báo", MessageBoxButtons.OKCancel);
            else
            {
                con.Open();
                cmd.InsertCommand = new SqlCommand("INSERT INTO ACCOUNT(_NAME_ACCOUNT,_PASSWORD,_USERNAME) " +
                    "VALUES(@A,@B,@C)");
                cmd.InsertCommand.Connection = con;
                cmd.InsertCommand.Parameters.AddWithValue("@A",txt_username.Text);
                cmd.InsertCommand.Parameters.AddWithValue("@B", txt_password.Text);
                cmd.InsertCommand.Parameters.AddWithValue("@C", txt_name.Text);

                cmd.InsertCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bạn đã tạo tài khoản thành công", "Chúc mừng", MessageBoxButtons.OK);
                this.Close();

            }
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            if (txt_name.Text == "Name")
            {
                txt_name.Text = "";
                txt_name.ForeColor = Color.Black;
            }
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                txt_name.Text = "Name";
                txt_name.ForeColor = Color.Silver;
            }
        }
    }
}
