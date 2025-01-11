using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporcuOtomasyonu
{
    public class Eat
    {
        public static int day = 1;
        public string karbonhidrat;
        public string protein;
        public string yag;
        public string kcal;
    

        public Eat() { }
        
        public Eat(SQLiteDataReader reader)
        {
            try
            {
                this.karbonhidrat = reader.GetString(0);
                this.protein = reader.GetString(1);
                this.yag = reader.GetString(2);
                this.kcal = reader.GetString(3);
        
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Invalid DataReader");
            }
        }
        public ListViewItem convertToItem()
        {
            ListViewItem item = new ListViewItem(day.ToString());
            item.SubItems.Add(karbonhidrat);
            item.SubItems.Add(protein);
            item.SubItems.Add(yag);
            item.SubItems.Add(kcal);
            day++;
            return item;
        }
    }
}
