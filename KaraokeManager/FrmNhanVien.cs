using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace KaraokeManager
{
    public partial class FrmNhanVien : Form
    {
        MySqlConnection con,con1;
        DataTable dtrecord = new DataTable();
        DataTable dtrecord1 = new DataTable();
        string connectionString = "Server = localhost; Database=kara; Port = 4306; User ID = root ; Password =;";
        string user;
        string nos;
        public FrmNhanVien(string name)
        {
            user = name;
            InitializeComponent();
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            string sql = "select *from user where UserName= '" + user + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            label6.Text = "Xin chào " + dataReader.GetString(2);
            label1.Text = dataReader.GetString(4);
            nos = dataReader.GetString(4);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            textEdit4.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            textEdit1.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            textEdit3.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHoaDon form = new FrmHoaDon(textEdit1.Text, int.Parse(textEdit2.Text), int.Parse(textEdit3.Text), textEdit4.Text);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE tableinfo set RoomStatus = ('Đang có khách') WHERE RoomID = ('" + textEdit4.Text + "') AND NameOfStore =('" + label1.Text + "')";
            MySqlDataReader sdr = cmd.ExecuteReader();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE tableinfo set RoomStatus = ('Đang không có khách') WHERE RoomID = ('" + textEdit4.Text + "') AND NameOfStore =('" + label1.Text + "')";
            MySqlDataReader sdr = cmd.ExecuteReader();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tableinfo WHERE NameOfStore = '" + nos +"'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;

            con = new MySqlConnection(connectionString);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from menu";
            sdr = cmd.ExecuteReader();
            dtrecord1 = new DataTable();
            dtrecord1.Load(sdr);
            dataGridView2.DataSource = dtrecord1;
        }
    }
}
