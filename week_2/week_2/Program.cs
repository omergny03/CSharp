using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Person person = new Person("ömerr",21,"asdasdd",2003);
            person.getInfo();
            Person person1 = new Person();
            */
            Person2 person2 = new Person2("Arif",2003);
            person2.Name = "Köse";
            Person2 student = new Student("Ahmet",2002,2546138);
            student.getInfo();  
            Console.ReadLine();
        }
    }
}
