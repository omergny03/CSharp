using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    internal class Student : Person2
    {
        protected int studentNumber;
         public Student(string name, int birthYear,int studentNumber) :base(name,birthYear) { 
           StudentNumber = studentNumber;
        }
    
         public int StudentNumber
        {
            get { return this.studentNumber; }
            set { this.studentNumber = value; }
        }

         public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine(" Student Number: "+StudentNumber);
        }
        public override string ToString()
        {
            return "Name: " + Name + " Age: " + age;
        }
    }
}
