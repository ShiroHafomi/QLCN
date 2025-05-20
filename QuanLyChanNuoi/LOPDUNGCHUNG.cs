using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyChanNuoi
{
    class LOPDUNGCHUNG
    {
        SqlConnection conn;
        public LOPDUNGCHUNG()
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Code\C#\QuanLyChanNuoi\QuanLyChanNuoi\QuanLyChanNuoi1.mdf;Integrated Security=True";
            conn = new SqlConnection(chuoikn);
        }
        public int ChucNang(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public object LayGT(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        //Viết phương thức cho dữ liệu bảng
        public DataTable LayDLBang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
    }
}
