using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FormAppJob
{
    
    internal class CongViec
    {
        private string id;
        private string viTri;
        private string linhVuc;
        private string mucLuong;

        public CongViec(string viTri, string linhVuc, string mucLuong)
        {
            // Trong constructor này, id sẽ được tự động sinh ra bởi cơ sở dữ liệu vì là identity
            this.viTri = viTri;
            this.linhVuc = linhVuc;
            this.mucLuong = mucLuong;
        }

        public CongViec(string id, string viTri, string linhVuc, string mucLuong)
        {
            this.id = id;
            this.viTri = viTri;
            this.linhVuc = linhVuc;
            this.mucLuong = mucLuong;
        }
        public string Id
        {
            get { return id; }
        }
        public string LinhVuc
        {
            get { return linhVuc; }
        }
        public string ViTri
        {
            get { return viTri; }
        }
        public String MucLuong
        {
            get { return mucLuong; }
        }
    }
}
