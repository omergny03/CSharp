using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    internal class Staff
    {
        private string name;
        private string department;
        private int salary;

        public Staff(string name,string department,int salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }

        }

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
    }
}
