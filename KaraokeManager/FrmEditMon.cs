using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KaraokeManager
{
    public partial class FrmEditMon : Form
    {
        MySqlConnection con;
        DataTable dtrecord = new DataTable();
        string connectionString = "Server = localhost; Database=kara; Port = 4306; User ID = root ; Password =;";
        public FrmEditMon()
        {
            InitializeComponent();
            con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from menu";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            textEdit1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textEdit2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Database=kara; Port = 4306; User ID = root ; Password =;";
            con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO menu VALUES('" + textEdit1.Text + "'," + textEdit2.Text + ")";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM menu WHERE NameOfFood = ('" + textEdit1.Text + "')";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
