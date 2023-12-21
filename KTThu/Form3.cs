using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KTThu
{
    public partial class Form3 : Form
    {
        Bai14DataContext db = new Bai14DataContext();
        public Form3()
        {
            InitializeComponent();
            Load_CboCoSo();
            
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedServerCode = comboBox1.SelectedValue as string;
            if (!string.IsNullOrEmpty(selectedServerCode))
            {
                Load_CboDonViDaoTao(selectedServerCode);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void Load_CboCoSo()
        {
            

            try
            {
                var servers = from server in db.COSOs
                              select new { ServerName = server.tencoso, ServerCode = server.macoso }; // Thêm ServerCode vào mỗi mục

                comboBox1.DisplayMember = "ServerName";
                comboBox1.ValueMember = "ServerCode";
                comboBox1.DataSource = servers.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy danh sách máy chủ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Load_CboDonViDaoTao(string code)
        {
            try
            {
                var databases = from database in db.DONVIs
                                where database.macoso == code
                                select new { DatabaseName = database.tendonvi, DatabaseCode = database.madonvi }; // Thêm DatabaseCode vào mỗi mục

                comboBox2.DisplayMember = "DatabaseName";
                comboBox2.ValueMember = "DatabaseCode";
                comboBox2.DataSource = databases.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy danh sách cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedServerCode = comboBox2.SelectedValue as string;
            if (!string.IsNullOrEmpty(selectedServerCode))
            {
                load(selectedServerCode);
            }
        }
        public void load(string code)
        {


            try
            {
                var databases = from database in db.GVs
                                where database.madonvi == code
                                select new { Hoten = database.hoten, MaGV = database.madonvi,SDT = database.sdt , GhiChu = database.ghichu }; // Thêm DatabaseCode vào mỗi mục

               
                dataGridView1.DataSource = databases.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy danh sách cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Quản lý Giáo Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
