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
    public partial class Form1 : Form
    {
        List<string> list;
        public Form1()
        {
            InitializeComponent();
            list = new List<string>();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            string text = txtNhap.Text;
            if (!DoubleCheck(text))
                MessageBox.Show("Trung");
            else
            {
                list.Add(text);
                foreach (string item in list)
                {

                    treeView1.Nodes.Add(item);
                }
            }

          
            
        }
        public bool DoubleCheck(string item)
        {
            foreach (string i in list)
            {
                if (item == i)
                    return false;
                
            }
            return true;
        }
       
    }
}
