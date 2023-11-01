using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Buoi09
{
    class KetNoi
    {
        public SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection("Data Source=DESKTOP-60OJDK8;Initial Catalog=QLSinhVien;Integrated Security=True");
        }
        public KetNoi(string str)
        {
            conn = new SqlConnection(str);
        }
    }
}
