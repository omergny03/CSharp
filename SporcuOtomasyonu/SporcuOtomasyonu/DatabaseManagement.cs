using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using MindFusion.Charting.WinForms;
using MindFusion.Charting;

namespace SporcuOtomasyonu
{
    class DatabaseManagement
    {
        public int count = 1;
        private string db_name { get; set; }
        public string connectionTag;


        public DatabaseManagement(string database_name)
        {

            this.db_name = database_name;
            this.connectionTag = $"Data Source = {db_name};Journal Mode=WAL;";
            createDatabase();
        }

        public void createDatabase()
        {
            if (!File.Exists(this.db_name))
            {
                try
                {
                    SQLiteConnection.CreateFile(db_name);
                    using (SQLiteConnection con = new SQLiteConnection(connectionTag))
                    {
                        con.Open();
                        string query = "CREATE TABLE IF NOT EXISTS members(no INTEGER NOT NULL,kullanici_adi TEXT NOT NULL,email TEXT NOT NULL,sifre TEXT NOT NULL,ad TEXT NOT NULL,soyad TEXT NOT NULL)";
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.CommandText = query;
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("database başarıyla oluşturuldu");
                        con.Close();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Database oluşurken bir hata oluştu : " + ex.Message);
                }
            }
            else
            {
               // MessageBox.Show("Database zaten mevcut");
            }



        }

        public void addUserToDatabase(string username, string email, string password, string name, string surname)
        {

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionTag))
                {

                    con.Open();
                    string query = "INSERT INTO members(no,kullanici_adi,email,sifre,ad,soyad) VALUES(@no,@username,@email,@password,@name,@surname)";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@no", count);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.ExecuteNonQuery();
                    count += 1;
                    MessageBox.Show("başarıyla kaydedildi");
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı eklerken bir hata oluştu : " + ex.Message);
            }
        }

        public void login(string username, string password)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionTag))
                {
                    con.Open();
                    //string query = "SELECT * FROM members  ";
                    string query = $"SELECT * FROM members WHERE kullanici_adi = '{username}' ";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("username ya da şifre hatalı");
                        reader.Close();
                        
                    }
                    else
                    {

                        while (reader.Read())
                        {
                            User user = new User(reader);
                            if ((user.username == username) && (user.password == password))
                            {
                                FormDetail childForm = new FormDetail();
                                childForm.user = user;

                                childForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("username ya da şifre hatalı");
                            }
                        }
                         
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Login işleminde hata oldu : " + ex.Message);
            }
        }

        public async Task createTableAsync(string tableName)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionTag))
                {
                    await con.OpenAsync();
                    string query = $"CREATE TABLE IF NOT EXISTS {tableName}(karbonhidrat TEXT, protein TEXT, yag TEXT, kcal TEXT)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
               // MessageBox.Show(tableName + " tablosu başarıyla oluşturuldu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(tableName + " tablosunu oluştururken hata oluştu: " + ex.Message);
            }
        }

        public void addDataToTable(string tableName, string karbonhidrat, string protein, string yag, string kcal)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionTag))
                {
                    con.Open();
                    string query = $"INSERT INTO {tableName}(karbonhidrat,protein,yag,kcal) VALUES(@karbonhidrat,@protein,@yag,@kcal)";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@karbonhidrat", karbonhidrat);
                    cmd.Parameters.AddWithValue("@protein", protein);
                    cmd.Parameters.AddWithValue("@yag", yag);
                    cmd.Parameters.AddWithValue("@kcal", kcal);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Veriler başarıyla eklendi", "Visual Programming", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(tableName + " tablosuna veri kaydederken hata oluştu " + ex.Message);
            }
        }

        public void getEatsData(string table_name,ListView listView)
        {
            try
            {
                listView.Items.Clear();
                Eat.day = 1;
                using (SQLiteConnection con = new SQLiteConnection(connectionTag))
                {
                    con.Open();
                    string query = $" select * from {table_name}";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show(table_name+" tablosunda veri yok!");
                        reader.Close();
                        con.Close();
                        return;
                    }
                    while (reader.Read())
                    {   
                        Eat eat = new Eat(reader);
                        ListViewItem item = eat.convertToItem();
                        listView.Items.Add(item);

                    }
                    reader.Close();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(table_name+" tablosunda veri alırken bir hata oluştu");

            }
        }

        public void getChartdata(string table_name,BarChart barChart)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionTag))
                {
                    con.Open();
                    string query = $"select kcal from {table_name}";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        con.Close();
                        return;
                    }
                    List<double> list = new List<double>();
                    List<string> listLabel = new List<string>();
                    int count = 1;
                    while (reader.Read())
                    {
                        string kcalValue = reader.GetString(0);
                        if (double.TryParse(kcalValue, out double kcalDouble))
                        {
                            list.Add(kcalDouble);
                        }
                        else
                        {
                            MessageBox.Show("Invalid type ");
                        }
                        listLabel.Add(count.ToString());
                        count++;    
                       // MessageBox.Show(reader.GetString(0));
                    }
                    SimpleSeries series1 = new SimpleSeries(list,listLabel);
                    barChart.Series.Add(series1);
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(table_name + " tablosunda chart için veri alırken bir hata oluştu");
            }
        }
    }
}
