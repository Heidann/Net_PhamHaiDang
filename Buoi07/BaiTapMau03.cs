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
    public partial class BaiTapMau03 : Form
    {
        
        public BaiTapMau03()
        {
            InitializeComponent();

            treeView1.Nodes.Add("Giám đốc");
            treeView1.Nodes.Add("Tổ chức hành chính");
            treeView1.Nodes.Add("Kế hoạch");
            treeView1.Nodes.Add("Kế Toán");

            LoadCbo();


        }

        private void ThemBP_Click(object sender, EventArgs e)
        {

            string str = txtPB.Text;

            if (Duplicates(str))
            {
                treeView1.Nodes.Add(str);
                comboBox1.Items.Clear();
                LoadCbo();
            }
            else
            {
                MessageBox.Show("Trùng Phòng Ban!");
                txtPB.Text = "";
            }

        }

        private void XoaPB_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
            comboBox1.Items.Clear();
            LoadCbo();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach(TreeNode node in treeView1.Nodes)
            {
                if (node.Text == comboBox1.Text)
                {
                    index = node.Index;
                    break;
                }
            }
            treeView1.Nodes[index].Nodes.Add(txtHoten.Text + "(" + txtMaso.Text  +")");
            treeView1.ExpandAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (treeView1.HasChildren)
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
                LoadCbo();
            }
            else
            {
                MessageBox.Show("Khac!");
            }

            


        }
        public void LoadCbo()
        {
            foreach (TreeNode node in treeView1.Nodes)
            {

                comboBox1.Items.Add(node.Text);

            }
        }
        public bool Duplicates(string item)
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                if (item == node.Text)
                    return false;


            }
            return true;
        }

      
    }
}
