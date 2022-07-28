using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace KaraokeManager
{
    public partial class FrmAdmin : Form
    {
        MySqlConnection con;
        DataTable dtrecord = new DataTable();
        String user;
        public FrmAdmin(string Name)
        {
            user = Name;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Database=kara; Port = 4306; User ID = root ; Password =;";
            con = new MySqlConnection(connectionString);
            con.Open();
            String name = button1.Text;
            labelName.Text = button1.Text;
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tableinfo WHERE NameOfStore = '" + name + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord = new DataTable();
            dtrecord.Load(sdr);
            TableView.DataSource = dtrecord;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Database=kara; Port = 4306; User ID = root ; Password =;";
            con = new MySqlConnection(connectionString);
            con.Open();
            String name = button2.Text;
            labelName.Text = button2.Text;
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tableinfo WHERE NameOfStore = '" + name + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord = new DataTable();
            dtrecord.Load(sdr);
            TableView.DataSource = dtrecord;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Database=kara; Port = 4306; User ID = root ; Password =;";
            con = new MySqlConnection(connectionString);
            con.Open();
            String name = button3.Text;
            labelName.Text = button3.Text;
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tableinfo WHERE NameOfStore = '" + name + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord = new DataTable();
            dtrecord.Load(sdr);
            TableView.DataSource = dtrecord;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Database=kara; Port = 4306; User ID = root ; Password =;";
            con = new MySqlConnection(connectionString);
            con.Open();
            String name = button4.Text;
            labelName.Text = button4.Text;
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tableinfo WHERE NameOfStore = '" + name + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord = new DataTable();
            dtrecord.Load(sdr);
            TableView.DataSource = dtrecord;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Database=kara; Port = 4306; User ID = root ; Password =;";
            con = new MySqlConnection(connectionString);
            con.Open();
            String name = button5.Text;
            labelName.Text = button5.Text;
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tableinfo WHERE NameOfStore = '" + name + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord = new DataTable();
            dtrecord.Load(sdr);
            TableView.DataSource = dtrecord;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Database=kara; Port = 4306; User ID = root ; Password =;";
            con = new MySqlConnection(connectionString);
            con.Open();
            String name = button6.Text;
            labelName.Text = button6.Text;
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tableinfo WHERE NameOfStore = '" + name + "'";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord = new DataTable();
            dtrecord.Load(sdr);
            TableView.DataSource = dtrecord;
        }

        private void TableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = TableView.CurrentRow.Index;
            textEdit1.Text = TableView.Rows[i].Cells[1].Value.ToString();
            textEdit2.Text = TableView.Rows[i].Cells[2].Value.ToString();
            textEdit3.Text = TableView.Rows[i].Cells[3].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String name = labelName.Text;
            string connectionString = "Server = localhost; Database=kara; Port = 4306; User ID = root ; Password =;";
            con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO tableinfo VALUES('" + labelName.Text +"','" + textEdit1.Text + "','" + textEdit2.Text + "','" + textEdit3.Text + "')";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord.Load(sdr);
            TableView.DataSource = dtrecord;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM tableinfo WHERE NameOfStore = ('" + labelName.Text + "') AND RoomID = ('" + textEdit1.Text + "')";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord.Load(sdr);
            TableView.DataSource = dtrecord;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE tableinfo set NameOfStore = ('" + labelName.Text + "'), TypeOfRoom = ('" + textEdit2.Text + "'), RoomStatus = ('" + textEdit3.Text + "') WHERE RoomID = ('" + textEdit1.Text + "') ";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrecord.Load(sdr);
            TableView.DataSource = dtrecord;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap form2 = new frmDangNhap();
            form2.Show();
            this.Hide();
        }

        private void viewYourAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewAccount form3 = new FrmViewAccount(user);
            form3.Show();
        }

        private void accountManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditAccount form4 = new FrmEditAccount();
            form4.Show();
        }

        private void menuInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditMon form5 = new FrmEditMon();
            form5.Show();
        }
    }
}
