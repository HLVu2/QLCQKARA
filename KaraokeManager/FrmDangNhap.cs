using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace KaraokeManager
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            textEdit2.Properties.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Database=kara; Port = 4306; User ID = root ; Password =;";
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                string tk = textEdit1.Text;
                string mk = textEdit2.Text;
                string sql = "select *from user where UserName='" + tk + "' and Pass= '" + mk + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read() == true)
                {
                    if (dataReader.GetInt32(3) == 1)
                    {
                        FrmAdmin mainmenu = new FrmAdmin(tk);
                        mainmenu.Show();
                        this.Hide();
                    }
                    if (dataReader.GetInt32(3) == 2)
                    {
                        FrmNhanVien form6 = new FrmNhanVien(tk);
                        form6.Show();
                        this.Hide();
                    }
                }
                else
                {
                    Notice.Text = "Login Failer";
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
