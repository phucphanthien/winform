using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAppJob
{
    internal class CongViecDAO
    {
        DBConnections connect = new DBConnections();
        public void Them(CongViec cv)
        {
            string sqlStr = string.Format("INSERT INTO Job(viTri , linhVuc, mucLuong) VALUES ('{0}', '{1}', '{2}')", cv.ViTri, cv.LinhVuc, cv.MucLuong);
            connect.ThucThi(sqlStr);
        }
        public void Xoa(CongViec cv)
        {
            string sqlStr = string.Format("DELETE FROM Job WHERE ID = '{0}'", cv.Id);
            connect.ThucThi(sqlStr);
        }
        public void Sua(CongViec cv)
        {
            string sqlStr = string.Format("UPDATE Job SET viTri = '{0}', linhVuc ='{1}', mucLuong ='{2}' WHERE ID = '{3}'", cv.ViTri, cv.LinhVuc, cv.MucLuong, cv.Id);
            connect.ThucThi(sqlStr);
        }
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT * FROM Job");
            return connect.Load();
        }
    }
}
