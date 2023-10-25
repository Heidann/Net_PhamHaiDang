using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi07
{
    public partial class BaiTapTaiLop01 : Form
    {
        public BaiTapTaiLop01()
        {
            InitializeComponent();
        }

        private void btnThemSo_Click(object sender, EventArgs e)
        {
            if (txtNhapso.Text != null)
            {
               
                foreach (var cbo in cboNhapso.Items)
                {
                    if (txtNhapso.Text == cbo.ToString())
                    {
                        MessageBox.Show("Trung!");
                        txtNhapso.Text = "";
                        break;
                    }
                   
                      
                    
                }
                cboNhapso.Items.Add(txtNhapso.Text);
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(cboNhapso.SelectedItem);
            listBox1.Items.Clear();
            TongUocSo(so);

        }
        public void TongUocSo(int so)
        {
            for (int i = 1; i <= so;i++ )
            {
                if (so % i == 0)
                {
                    
                    listBox1.Items.Add(i);

                }

            }

        }
        public void TongUocSoChan(int so)
        {
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                    if (i % 2 == 0)
                    {
                       
                        listBox1.Items.Add(i);  


                    }

            }

        }
        public void UocSNT(int so)
        {
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0 && IsSNT(i))
                    {

                        listBox1.Items.Add(i);


                    }

            }

        }
        public bool IsSNT(int number)
        {
            if (number < 2)
                return false;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnListchan_Click(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(cboNhapso.SelectedItem);
            listBox1.Items.Clear();

            TongUocSoChan(so);
        }

        private void btnListNT_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (cboNhapso.Text != null)
                UocSNT(Convert.ToInt32(cboNhapso.SelectedItem));
        }
        

    }
}
