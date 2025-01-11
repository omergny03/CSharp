using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporcuOtomasyonu
{
     public class User
    {
        public string username;
        public string email;
        public string password;
        public string name; 
        public string surname;

        public User() { }
        public User(string username,string email,string password ,string name,string surname)
        {
            this.username = username;
            this.email = email; 
            this.password = password;
            this.name = name;  
            this.surname = surname;
        }
        public User(SQLiteDataReader reader)
        {
            try
            {
                this.username = reader.GetString(1);
                this.email = reader.GetString(2);
                this.password = reader.GetString(3);
                this.name = reader.GetString(4);
                this.surname=reader.GetString(5);
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Invalid DataReader");
            }
        }
    }
}
