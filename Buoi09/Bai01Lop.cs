using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Buoi09
{
    public partial class Bai01Lop : Form
    {
        KetNoi kn = new KetNoi();
        SqlConnection con;
        
        public Bai01Lop()
        {
            InitializeComponent();
            con = kn.conn;
            LoadData();
        }
        public void  LoadData()
        {
            try
            {
                con.Open();

                string str = "select * from SinhVien";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                dataGridView2.DataSource = dt;

            }
            catch(Exception ex)
            {
                MessageBox.Show("That bai!");
            }
        }
        private void LoadLop_ComboBox()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            string insertString;
            insertString = "select * from Lop";
            SqlCommand cmd = new SqlCommand(insertString, con);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cboLop.Items.Add(rd["MaLop"].ToString());
            }


            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public bool IsSinhVienExists(string maKhoa)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                string insertString;
                insertString = "SELECT COUNT(*) FROM SinhVien WHERE MaSinhVien ='" + txtMa.Text + "'";
                SqlCommand cmd = new SqlCommand(insertString, con);

                int count = Convert.ToInt32(cmd.ExecuteScalar());




                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                if (count >= 1)
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Length == 0 || txtTen.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống! ");
            }
            else
            {
                if (IsSinhVienExists(txtMa.Text))
                {
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }


                        string insertString;
                        insertString = "insert into SinhVien values('" + txtMa.Text + "',N'" + txtTen.Text +  "','" + dt_NgaySinh.Text + "',N'" + cboLop.Text + "')";
                        SqlCommand cmd = new SqlCommand(insertString, con);


                        cmd.ExecuteNonQuery();

                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        MessageBox.Show("Them thanh cong");

                        LoadData();



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("That bai");
                    }
                }
                else
                {
                    MessageBox.Show("Đã tồn tại Mã Sinh Vien " + txtMa.Text);
                }


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Length == 0)
            {
                MessageBox.Show("Hãy điền Mã Sinh Vien cần xóa! ");
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    string insertString;

                    insertString = "delete SinhVien where MaSinhVien='" + txtMa.Text + "'";
                    SqlCommand cmd = new SqlCommand(insertString, con);


                    cmd.ExecuteNonQuery();

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    MessageBox.Show("Thanh cong");


                    LoadData();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("That bai");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Length == 0 || txtTen.Text.Length == 0 || dt_NgaySinh.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống! ");
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    string insertString;
                    insertString = "update SinhVien set Hoten='" + txtTen.Text + "',MaLop='" + cboLop.Text + "',NgaySinh='" + dt_NgaySinh.Text + "' where MaSinhVien='" + txtMa.Text + "'";
                    SqlCommand cmd = new SqlCommand(insertString, con);


                    cmd.ExecuteNonQuery();

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    MessageBox.Show("Thanh cong");
                    LoadData();





                }
                catch (Exception ex)
                {
                    MessageBox.Show("That bai");
                }
            }
        }

        private void Bai01Lop_Load(object sender, EventArgs e)
        {
            LoadLop_ComboBox();
        }
    }
}
