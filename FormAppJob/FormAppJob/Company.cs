using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FormAppJob
{
    internal class Company : User
    {
        private string website;
        public Company(string name, string phone, string diaChi, string email, string website, string linhVuc): base(name, phone, diaChi, email, linhVuc)
        {
            this.website = website;
        }
        public string Web
        {
            get { return website; }
        }
    }
    
}
