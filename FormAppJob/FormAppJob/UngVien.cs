using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAppJob
{
    internal class UngVien : User
    {
        private string sex;
        private DateTime date;
        private string salary;

        public UngVien(string name, string sex, string phone, DateTime date, string diaChi, string email, string salary, string linhVuc) : base(name, phone, diaChi, email, linhVuc)
        {
            this.sex = sex;
            this.date = date;
            this.salary = salary;
        }
        public string Sex
        {
            get { return sex; }
        }
        public DateTime Date
        {
            get { return date; }
        }
        public string Salary
        {
            get { return salary; }
        }
    }
}
