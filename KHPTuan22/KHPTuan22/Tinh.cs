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
    public partial class Tinh : Form
    {
        public Tinh()
        {
            InitializeComponent();
        }

        //public int Tong()
        //{
        //    int a = int.Parse(txtSo1.Text);
        //    int b = int.Parse(txtSo2.Text);
        //    int kq = a+b;
        //    return kq;
        //}
        //public int Hieu()
        //{
        //    int a = int.Parse(txtSo1.Text);
        //    int b = int.Parse(txtSo2.Text);
        //    int kq = a - b;
        //    return kq;
        //}
        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtSo1.Text);
                double b = double.Parse(txtSo2.Text);
                double tong = a + b;
                double hieu = a - b;
                double tich = a * b;
                double thuong = a / b;
                lblKQTong.Text = tong.ToString();
                lblKQHieu.Text = hieu.ToString();
                lblKQTich.Text = tich.ToString();
                if(b == 0)
                {
                    lblKQThuong.Text = "Không tính được phép tính";
                }
                else lblKQThuong.Text = thuong.ToString();
                
            }
            catch
            {
                lblKQTong.Text = "Không tính được phép tính";
                lblKQHieu.Text = "Không tính được phép tính";
                lblKQTich.Text = "Không tính được phép tính";
                lblKQThuong.Text = "Không tính được phép tính";
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimMaxMin frm = new TimMaxMin();
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
