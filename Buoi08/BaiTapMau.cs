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


namespace Buoi08
{
    public partial class BaiTapMau : Form
    {
        KetNoi kn = new KetNoi();
        SqlConnection con;
        public BaiTapMau()
        {
            InitializeComponent();
            con = kn.conn;
            LoadData();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Length == 0 || txtTen.Text.Length ==0)
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
                    insertString = "insert into Khoa values('" + txtMa.Text + "',N'" + txtTen.Text + "')";
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Length == 0 )
            {
                MessageBox.Show("Hãy điền Mã Khoa cần xóa! ");
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

                    insertString = "delete Khoa where MaKhoa='" + txtMa.Text + "'";
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
                    insertString = "update Khoa set TenKhoa='" + txtTen.Text + "' where MaKhoa='" + txtMa.Text + "'";
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

        private void btnHienThi_Click(object sender, EventArgs e)
        {

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string insertString;
                insertString = "select * from Khoa";
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
        private void LoadData()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string insertString;
                insertString = "select * from Khoa";
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
