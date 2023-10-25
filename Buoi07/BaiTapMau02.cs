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
    public partial class BaiTapMau02 : Form
    {
        List<string> list;
        public BaiTapMau02()
        {
            InitializeComponent();
            list = new List<string> { "Kinh", "Hoa", "Khơ me", "H' Mông", "Khác" };
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            foreach(string item in list)
            {
                cbo_view.Items.Add(item);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Dân tộc được chọn:";
            if (cbo_view.SelectedIndex > 0)
                label2.Text = str + cbo_view.SelectedItem.ToString();
            else
                label2.Text = "Bạn chưa chọn dân tộc";
        }
    }
}
