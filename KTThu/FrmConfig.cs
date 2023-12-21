using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KTThu
{
    public partial class FrmConfig : Form
    {
        
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void cbServer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serverName = txtServerName.Text;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string database = txtDatabase.Text;

            string connectionString = $"Data Source={serverName};Initial Catalog={database};User ID={userName};Password={password};";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Thử mở kết nối
                    // Nếu không có lỗi, thì thông tin đăng nhập là đúng
                    MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Thực hiện các hành động khác nếu cần
                    // Chẳng hạn, mở form tiếp theo
                    // this.Hide();
                    // FrmMain frmMain = new FrmMain();
                    // frmMain.Show();
                }
            }
            catch (Exception ex)
            {
                // Nếu có lỗi, hiển thị thông báo lỗi
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Quản lý Giáo Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }
    }
}
