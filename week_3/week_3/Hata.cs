using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    internal class Hata
    {
        public void HataAyikla() {

            
            try
            {
                Console.WriteLine("Sayı giriniz:");
                int sayi = int.Parse(Console.ReadLine());
                double result = 16 / sayi;
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.Message);
                Console.WriteLine("Sayı giriniz:");
            }
        }   
    }
}
