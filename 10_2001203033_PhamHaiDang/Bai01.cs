using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_2001203033_PhamHaiDang
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();

        }



        
        private void a_TextChanged(object sender, EventArgs e)
        {
            //Control ctr = (Control)sender;
            //if (ctr.Text.Length > 0 && Char.IsDigit(ctr.Text[ctr.Text.Length - 11]))
            //    this.errorProvider1.SetError(ctr, "This is not avalid number!");
            //else
            //    this.errorProvider1.Clear();
            
        }

        private void b_TextChanged(object sender, EventArgs e)
        {
            //Control ctr = (Control)sender;
            //if (ctr.Text.Length > 0 && Char.IsDigit(ctr.Text[ctr.Text.Length-11]))
            //    this.errorProvider1.SetError(ctr, "This is not avalid number!");
            //else
            //    this.errorProvider1.Clear();
        }

        

        private void Bai01_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        public double Cong(double a, double b)
        {
            return a + b;
        }
        public double Tru(double a, double b)
        {
            return a - b;
        }
        public double Nhan(double a, double b)
        {
            return a * b;
        }
        public double Chia(double a, double b)
        {
            return a / b;
        }
        private void cong_Click(object sender, EventArgs e)
        {
            try
            {
                txtA.Text = (Convert.ToDouble(txtA.Text)).ToString();
                txtB.Text = (Convert.ToDouble(txtB.Text)).ToString();
                ketqua.Text = (Convert.ToDouble(txtA.Text) + Convert.ToDouble(txtB.Text)).ToString();
            
            }
            catch
            {
                MessageBox.Show("Bạn Đã Nhập Sai Dữ Liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                txtA.Text = (Convert.ToDouble(txtA.Text)).ToString();
                txtB.Text = (Convert.ToDouble(txtB.Text)).ToString();
                ketqua.Text = (Convert.ToDouble(txtA.Text) - Convert.ToDouble(txtB.Text)).ToString();

            }
            catch
            {
                MessageBox.Show("Bạn Đã Nhập Sai Dữ Liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                txtA.Text = (Convert.ToDouble(txtA.Text)).ToString();
                txtB.Text = (Convert.ToDouble(txtB.Text)).ToString();
                ketqua.Text = (Convert.ToDouble(txtA.Text) * Convert.ToDouble(txtB.Text)).ToString();

            }
            catch
            {
                MessageBox.Show("Bạn Đã Nhập Sai Dữ Liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                txtA.Text = (Convert.ToDouble(txtA.Text)).ToString();
                txtB.Text = (Convert.ToDouble(txtB.Text)).ToString();
                ketqua.Text = (Convert.ToDouble(txtA.Text) / Convert.ToDouble(txtB.Text)).ToString();

            }
            catch
            {
                MessageBox.Show("Bạn Đã Nhập Sai Dữ Liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            ketqua.Text = "";
        }

        

       
    }
}
