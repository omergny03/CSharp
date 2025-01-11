using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_TabControlUygulaması
{
    internal class Person
    {
        private string kullanici_name;
        private string email;
        private string password;

        public Person(string kullanici_name,string email,string password)
        {
            Kullanici_Name = kullanici_name;
            Email = email;
            Password = password;
        }
        public string Kullanici_Name
        {
            get { return this.kullanici_name; }
            set { this.kullanici_name = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public override string ToString()
        {
            return "Kulalnıcı Adı: "+this.Kullanici_Name + " Email: "+ this.Email;
        }
    }
}
