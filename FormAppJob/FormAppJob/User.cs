using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAppJob
{
    internal class User
    {
        private string name;
        private string phone;
        private string diaChi;
        private string email;
        private string linhVuc;

        public User(string name, string phone, string diaChi, string email, string linhVuc)
        {
            this.name = name;
            this.phone = phone;
            this.diaChi = diaChi;
            this.email = email;
            this.linhVuc = linhVuc;
        }
        public string Name
        {
            get { return name; }
        }
        public string Phone
        {
            get { return phone; }
        }
        public string DiaChi
        {
            get { return diaChi; }
        }
        public string Email
        {
            get { return email; }
        }
        public string LinhVuc
        {
            get { return linhVuc; }
        }
    }
}
