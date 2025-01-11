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
using System.CodeDom;

namespace NestedForm
{
    public partial class Form2 : Form
    {
        public string db_name = "school4.db";
        public Form2()
        {
            InitializeComponent();
        }
        public void createDatabase()
        {
            if (!File.Exists(db_name))
            {
                try
                {
                    SQLiteConnection.CreateFile(db_name);
                    using (SQLiteConnection con = new SQLiteConnection("Data Source = " + db_name))
                    {
                        con.Open();
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.Connection = con;
                        cmd.CommandText = $"CREATE TABLE IF NOT EXISTS student(studentId INTEGER NOT NULL PRIMARY KEY,name TEXT,surname TEXT)";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("database oluşturuldu ve student tablosu eklendi");
                        con.Close();   
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Database zaten mevcut");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            createDatabase();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source = "+db_name))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = con;
                    cmd.CommandText = $"INSERT INTO student(studentId,name,surname) values(@studentId,@name,@surname)";
                    cmd.Parameters.AddWithValue("@studentId", txtStudentId.Text);
                    cmd.Parameters.AddWithValue("@name",txtName.Text);
                    cmd.Parameters.AddWithValue("@surname",txtSurname.Text);
                    cmd.ExecuteNonQuery ();
                    txtName.Text = "";
                    txtStudentId.Text = "";
                    txtSurname.Text = "";
                    con.Close();
                }

            }
            catch(SQLiteException ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select an item to delete.");
                    return;
                }
                using (SQLiteConnection con  = new SQLiteConnection("Data Source = "+db_name))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = con;
                    cmd.CommandText = $"DELETE FROM student WHERE studentId = @deleted";
                    int selectedName = int.Parse(listBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@deleted", selectedName);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
            catch (SQLiteException ex) {
              MessageBox.Show(ex.Message);
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
           
            try
            {
                listBox1.Items.Clear();
                using (SQLiteConnection con = new SQLiteConnection($"Data Source = {db_name}"))
                {
                    con.Open ();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = con;
                    cmd.CommandText = $"SELECT * FROM student";
                   SQLiteDataReader dataReader = cmd.ExecuteReader();
                    if (!dataReader.HasRows)
                    {
                        dataReader.Close();
                        con.Close();
                        return;
                    }
                    else
                    {
                        while (dataReader.Read())
                        {   int studentId = dataReader.GetInt32(0);
                            string name = dataReader.GetString(1);
                            string surname = dataReader.GetString(2);
                            listBox1.Items.Add(studentId);
                            listBox1.Items.Add(name);
                            listBox1.Items.Add(surname);
                            listBox1.Items.Add("---------------------");
                        }
                        dataReader.Close();
                        con.Close ();
                    }
                }
            }
            catch (SQLiteException ex) {
              MessageBox.Show (ex.Message); 
            }
        }
    }
}
