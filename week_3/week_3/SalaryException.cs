using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    internal class SalaryException:Exception
    {
        public SalaryException(string messaage):base(messaage) {
        
        }

    }
}
