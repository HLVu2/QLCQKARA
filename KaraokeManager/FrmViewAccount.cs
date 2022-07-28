using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KaraokeManager
{
    public partial class FrmViewAccount : Form
    {
        String user;
        string connectionString = "Server = localhost; Database=kara; Port = 4306; User ID = root ; Password =;";
        public FrmViewAccount(string name)
        {
            user = name;
            InitializeComponent();
            button2.Enabled = false;
            textEdit1.Enabled = false;
            textEdit2.Enabled = false;
            textEdit3.Enabled = false;
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            string sql = "select *from user where UserName= '" + user + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            textEdit1.Text = dataReader.GetString(2);
            textEdit2.Text = dataReader.GetString(0);
            textEdit3.Text = dataReader.GetString(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            textEdit1.Enabled = true;
            textEdit2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE user set 	UserName = ('" + textEdit2.Text + "'), Pass = ('" + textEdit3.Text + "') WHERE Name = ('" + textEdit1.Text + "') ";
            MySqlDataReader sdr = cmd.ExecuteReader();
            button2.Enabled = false;
        }
    }
}
