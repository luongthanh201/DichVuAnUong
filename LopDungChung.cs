using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDichVuAnUong
{
    internal class LopDungChung
    {
        SqlConnection conn;

        public LopDungChung()
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CS464K_Laptrinh.net\QuanLyDichVuAnUong\QuanLyDichVuAnUong\DichVuAnUong.mdf;Integrated Security=True";
            conn = new SqlConnection(chuoiketnoi);
        }
        public object LayGiaTri(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public int ThemSuaXoa(string sql)
        {
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            int kq = command.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
