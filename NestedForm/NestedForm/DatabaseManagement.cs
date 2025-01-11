using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;

namespace NestedForm
{
     class DatabaseManagement
    {
        private string db_name { set; get; }
        public string connection;
        
        public DatabaseManagement(string dbName)
        {
            connection = $"Data Source = {dbName}";
        }

        public void createDatabase()
        {
            if (!File.Exists(db_name))
            {
                try
                {
                    SQLiteConnection.CreateFile(db_name);
                    using (SQLiteConnection con = new SQLiteConnection(connection))
                    {
                        con.Open();
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.Connection = con;
                        cmd.CommandText = $"CREATE TABLE IF NOT EXISTS user(id INTEGER NOT NULL PRIMARY KEY,name TEXT,surname TEXT)";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("createDatabase başarıyla çalıştı");
                        con.Close();
                    }

                }
                catch (SQLiteException ex) { 
                  
                    MessageBox.Show("CreateDatabase =>"+ex.Message);
                }
            }
        }
   
        public void add(string command , FormLab frm)
        {
            try
            {
                using(SQLiteConnection con = new SQLiteConnection(connection))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(command,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("add işlemi başarılı");
                    con.Close();
                }

            }
            catch (SQLiteException ex) {
                MessageBox.Show("add =>" + ex.Message);
            }
        }

        public void getUsers(string command) 
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connection))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(command,con);
                    SQLiteDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.HasRows == null)
                    {
                        MessageBox.Show("Tablo boş");
                        dataReader.Close();
                        con.Close();
                    }
                    else
                    {
                        while (dataReader.Read())
                        {
                            int id = dataReader.GetInt32(0);
                            string name = dataReader.GetString(1);  
                            string surname = dataReader.GetString(2);
                        }
                    }
                }

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("getUsers =>" + ex.Message);
            }

        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
