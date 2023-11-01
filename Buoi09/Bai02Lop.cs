using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Buoi09
{
    public partial class Bai02Lop : Form
    {
        KetNoi kn = new KetNoi();
        SqlConnection con;
        public Bai02Lop()
        {
            InitializeComponent();
            con = kn.conn;
            LoadData();

        }
        public void LoadData()
        {
            try
            {
                con.Open();

                string str = "select * from Diem";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                dataGridView2.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai!");
            }
        }
        private void LoadMonHoc_ComboBox()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            string insertString;
            insertString = "select * from MonHoc";
            SqlCommand cmd = new SqlCommand(insertString, con);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cboMonHoc.Items.Add(rd["MaMonHoc"].ToString());
            }


            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        private void LoadSinhVien_ComboBox()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            string insertString;
            insertString = "select * from SinhVien";
            SqlCommand cmd = new SqlCommand(insertString, con);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cboSInhVien.Items.Add(rd["MaSinhVien"].ToString());
            }


            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public bool IsDiemExists(string maKhoa)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                string insertString;
                insertString = "SELECT COUNT(*) FROM Diem WHERE Diem ='" + txtDiem.Text + "'";
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
            if (cboMonHoc.Text.Length == 0 || cboSInhVien.Text.Length == 0 || txtDiem.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống! ");
            }
            else
            {
                if (IsDiemExists(txtDiem.Text))
                {
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }


                        string insertString;
                        insertString = "insert into Diem values('" + cboSInhVien.Text + "',N'" + cboMonHoc.Text + "','" + txtDiem.Text + "')";
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
                    MessageBox.Show("Đã tồn tại diem cua Sinh Vien " + cboSInhVien.Text);
                }


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboSInhVien.Text.Length == 0)
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

                    insertString = "delete Diem where MaSinhVien='" + cboSInhVien.Text + "'";
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
            if (cboSInhVien.Text.Length == 0 || cboMonHoc.Text.Length == 0 || txtDiem.Text.Length == 0)
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
                    insertString = "update Diem set MaMonHoc='" + cboMonHoc.Text + "',Diem='" + txtDiem.Text + "' where MaSinhVien='" + cboSInhVien.Text + "'";
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

        private void Bai02Lop_Load(object sender, EventArgs e)
        {
            LoadMonHoc_ComboBox();
            LoadSinhVien_ComboBox();
        }
    }
}
