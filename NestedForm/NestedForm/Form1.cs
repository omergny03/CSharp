using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace NestedForm
{   
    public partial class Form1 : Form
    {
        public string database_name = "name.db";

        public void createDatabase() {

            if (File.Exists(database_name))
            {
                MessageBox.Show("Zaten database mevcut");
                return;
            }
            else
            {
                try
                {
                    
                    using (SQLiteConnection con = new SQLiteConnection("Data Source= "  + database_name))
                    {
                        con.Open();
                        string query = "CREATE TABLE IF NOT EXISTS student(name TEXT)";
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.CommandText = query;
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("database oluşturuldu");
                        con.Close();
                    }

                }catch(SQLiteException e)
                {
                    MessageBox.Show(e.Message);
                }

            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createDatabase();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using(SQLiteConnection con = new SQLiteConnection("Data Source= "+database_name))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = con;
                    cmd.CommandText = $"INSERT INTO student(name) values('{txtData.Text}')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (SQLiteException ex)
            {
                 MessageBox.Show(ex.Message);  
            }
        }
    }
}
