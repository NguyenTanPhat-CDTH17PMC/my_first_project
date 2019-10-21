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
    public partial class PTBac2 : Form
    {
        public PTBac2()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnewPT_Click(object sender, EventArgs e)
        {
            txtsoA.Clear();
            txtsoB.Clear();
            txtsoC.Clear();
            txtkq.Clear();
        }

        private void btnchuyen1_Click(object sender, EventArgs e)
        {
            Tinh frm = new Tinh();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void btnchuyen2_Click(object sender, EventArgs e)
        {
            TimMaxMin frm = new TimMaxMin();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtsoA.Text);
            double b = double.Parse(txtsoB.Text);
            double c = double.Parse(txtsoC.Text);
            double x1;
            double x2;
            double kq;
            if(a==0)
                if(b==0)
                    if(c==0)
                    {
                        txtkq.Text = "Phương trình vô số nghiệm";
                    }
                    else
                        {
                            txtkq.Text = "Phương trình vô nghiệm";
                        }
                else
                {
                    txtkq.Text = "Phương trình có 1 nghiệm x2 = " + (-c/b);
                }
            else
            {
                double delta = (b * b) - (4 * a * c);
                if (delta < 0)
                {
                    txtkq.Text = "Phương trình vô nghiệm!!";
                }
                else if (delta == 0)
                {
                    kq = (-b / (2 * a));
                    txtkq.Text = "Phương trình có nghiệm kép x1 = x2 = " + kq.ToString();
                }
                else
                {
                    x1 = ((-b - Math.Sqrt(delta))) / (2 * a);
                    x2 = ((-b + Math.Sqrt(delta))) / (2 * a);
                    txtkq.Text = "Phương trình có 2 nghiệm phân biệt: " + Environment.NewLine
                        + x1.ToString() + Environment.NewLine
                        + x2.ToString()
                        ;
                    
                }
            }
        }
    }
}
