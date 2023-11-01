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
    public partial class Bai02 : Form
    {
        KetNoi kn = new KetNoi(); 
        SqlConnection con;
        public Bai02()
        {
            InitializeComponent();
            con = kn.conn;
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string insertString;
                insertString = "select * from Lop";
                SqlCommand cmd = new SqlCommand(insertString, con);


                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                dataGridView2.DataSource = dt;





            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }

        private void LoadKhoa_ComboBox()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            string insertString;
            insertString = "select * from Khoa";
            SqlCommand cmd = new SqlCommand(insertString, con);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cboKhoa.Items.Add(rd["MaKhoa"].ToString());
            }


            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bai02_Load(object sender, EventArgs e)
        {
            LoadKhoa_ComboBox();
        }

        public bool IsMaLopExists(string maKhoa)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                string insertString;
                insertString = "SELECT COUNT(*) FROM Lop WHERE MaLop ='" + txtMa.Text + "'";
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
                if (IsMaLopExists(txtMa.Text))
                {
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }


                        string insertString;
                        insertString = "insert into Lop values('" + txtMa.Text + "',N'" + txtTen.Text + "',N'" + cboKhoa.Text + "')";
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
                    MessageBox.Show("Đã tồn tại Mã Lớp " + txtMa.Text);
                }


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Length == 0)
            {
                MessageBox.Show("Hãy điền Mã Lớp cần xóa! ");
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

                    insertString = "delete Lop where MaLop='" + txtMa.Text + "'";
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
            if (txtMa.Text.Length == 0 || txtTen.Text.Length == 0)
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
                    insertString = "update Lop set TenLop='" + txtTen.Text + "',MaKhoa='" + cboKhoa.Text + "' where MaLop='" + txtMa.Text + "'";
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
    }
}
