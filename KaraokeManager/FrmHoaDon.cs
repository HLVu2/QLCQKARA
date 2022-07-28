using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeManager
{
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon(string Name, int soluong, int Dongia, string tenphong)
        {
            InitializeComponent();
            textEdit1.Enabled = false;
            textEdit2.Enabled = false;
            textEdit3.Enabled = false;
            textEdit4.Enabled = false;
            textEdit1.Text = Name;
            textEdit2.Text = soluong.ToString();
            textEdit4.Text = Dongia.ToString();
            textEdit3.Text = (Dongia * soluong).ToString();
            label6.Text = " -- " + tenphong; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
