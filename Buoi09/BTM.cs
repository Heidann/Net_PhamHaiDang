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
    public partial class BTM : Form
    {
        KetNoi kn = new KetNoi()
;       SqlConnection con;
        public BTM()
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Length == 0 || txtTen.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống! ");
            }
            else
            {
               if (!IsMaKhoaExists(txtMa.Text))
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
                    MessageBox.Show("Đã tồn tại Mã Khoa " + txtMa.Text  );
                }    
                  
               
            }

        }
        public bool IsMaKhoaExists(string maKhoa)
        {
            
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            string insertString;
            insertString = "SELECT COUNT(*) FROM Khoa WHERE MaKhoa = @MaKhoa";
            SqlCommand cmd = new SqlCommand(insertString, con);

            cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0; 

            cmd.ExecuteNonQuery();

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            MessageBox.Show("Thêm thành công!");

            
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Length == 0)
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
    }
}
