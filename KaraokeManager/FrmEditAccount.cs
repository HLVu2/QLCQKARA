using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace KaraokeManager
{
    public partial class FrmEditAccount : Form
    {
        MySqlConnection con;
        DataTable dtrecord = new DataTable();
        public FrmEditAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Database=kara; Port = 4306; User ID = root ; Password =;";
            con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO user VALUES('" + textEdit1.Text + "','" + textEdit2.Text + "','" + textEdit3.Text + "',2,'" +textEdit4.Text+"')";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE user set 	UserName = ('" + textEdit1.Text + "'), Pass = ('" + textEdit2.Text + "'), store = ('"+textEdit4.Text+"') WHERE Name = ('" + textEdit3.Text + "') ";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM user WHERE UserName = ('" + textEdit1.Text + "') AND Pass = ('" + textEdit2.Text + "')";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            textEdit1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textEdit2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textEdit3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textEdit4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Database=kara; Port = 4306; User ID = root ; Password =;";
            con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from user WHERE priority = 2";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }
    }
}
