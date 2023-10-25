using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace _10_2001203033_PhamHaiDang
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void Bai02_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string mk = txtMatKhau.Text;
            string xacnhanmk = txtXacNhanMK.Text;
            if (!IsEmail(name))
                MessageBox.Show("Loi");
            if (!IsEmail(email))
                MessageBox.Show("Loi");
            if (!IsEmail(email))
                MessageBox.Show("Loi");
            if (!IsEmail(email))
                MessageBox.Show("Loi");


        }

        private void txtEmail_TextChanged(object sender, KeyPressEventArgs e)
        {

            
                
        }
        public bool IsEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public bool IsName(string name)
        {
            try
            {
                MailAddress m = new MailAddress(name);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        
    }
}
