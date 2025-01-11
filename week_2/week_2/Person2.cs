using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    internal class Person2
    {
        protected string name;
        protected int birthYear;

        public Person2()
        {
            this.name = string.Empty;   
            this.birthYear = 0;
        }
        public Person2(string name,int birthYear) {
            Name = name;
            BirthYear = birthYear;
        }    
        
        public string Name
        {
            get { return this.name; }
            set { if (value.Length > 2)
                {
                    this.name = value;
                }
                else { Console.WriteLine("Yanlış isim ataması"); }
            }
        }

        public int BirthYear
        {
            get { return this.birthYear; }
            set { this.birthYear = value; }
        }
        
        public int age
        {
            get {return 2024- BirthYear;}
        }

        public override string ToString()
        {
            return "Name: "+Name+" Age: "+age;
        }
       
        public virtual void getInfo()
        {
            Console.WriteLine("Name: " + Name + " Age: " + age);
        }
    }
}
