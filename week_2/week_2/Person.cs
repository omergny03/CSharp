using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    internal class Person
    {
        private string name;
        private int age;
        private string surname;
        private int year;

        public Person()
        {
            this.name = string.Empty;
            this.age = 0;
            this.surname = string.Empty;
            this.year = 0;
        }

        public Person(string name, int age, string surname, int year)
        {
            Name = name;
            Age = age;
            Surname= surname;
            Year = year;
        }

        public string FullName    /* Computed Property */
        {
           get { return Name + " " + Surname; }

        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length >= 3)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Yanlış isim ataması");
                   
                }
            }
        }
        
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 0)
                {
                    this.age = value;
                }
            }
        }
        
        public string Surname
        {
            get { return this.surname; }
            set
            {
                if (value.Length > 4)
                {
                    this.surname = value;
                }
            }
        }

        public int Year
        {
            get { return this.year; }
            set
            {
                if (value > 1900)
                {
                    this.year = value;
                }
            }


        }

        public void getInfo()
        {
            Console.WriteLine("Full name: " + FullName + " Age: " + Age + " Year: " + Year);
        }

    }

}
