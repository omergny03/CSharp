using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int number1 = 4;
            int? number2 =fonk(number1);
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            */

            /*
            Hata hata = new Hata();
            hata.HataAyikla();
            Console.ReadLine(); 
            */

            Staff staf1 = new Staff("ahmet", "elektrik", 10000);
            Staff staf2 = new Staff("mehmet", "pc", 20000);
            Staff staf3 = new Staff("ali", "elektrik", 30000);
            Staff staf4 = new Staff("ayşe", "pc", 40000);
            Staff staf5 = new Staff("hüseyin","elektrik",50000);

            ArrayList arrayList = new ArrayList();
            arrayList.Add(staf1);
            arrayList.Add(staf2);
            arrayList.Add(staf3);   
            arrayList.Add(staf4);   
            arrayList.Add(staf5);

            try
            {
                Console.WriteLine("Total: " + SumSalary(arrayList));
            }
            catch (SalaryException e) { 
             Console.WriteLine(e.Message);
            }   
           
            
            Console.ReadLine();
        }

        public static double SumSalary(ArrayList totalStaff)
        {
            double sum = 0;
           
                foreach (Staff staff in totalStaff)
                {
                    if (staff.Salary > 0)
                    {
                        sum += staff.Salary;
                    }
                    else
                    {
                        throw new SalaryException("Salary Hatası Aldınız");
                    }
                }

            return sum;
        }
        public static int? fonk(int nmbr)
        {
            if (nmbr == 4)
            {
                return nmbr;
            }
            else
            {
                return null;
            }
        }
    }
}
