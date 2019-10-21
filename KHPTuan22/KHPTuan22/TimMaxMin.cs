using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHPTuan22
{
    public partial class TimMaxMin : Form
    {
        public TimMaxMin()
        {
            InitializeComponent();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtso1.Text);
            int b = int.Parse(txtso2.Text);
            int Max;
            int Min;
            if(a > b)
            {
                Max = a;
                Min = b;
            }
            else
            {
                Max = b;
                Min = a;
            }
            txtmax.Text = Max.ToString();
            txtmin.Text = Min.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnchuyen1_Click(object sender, EventArgs e)
        {
            Tinh frm = new Tinh();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
            
        }

        private void btnchuyen3_Click(object sender, EventArgs e)
        {
            PTBac2 frm = new PTBac2();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
            
        }
    }
}
