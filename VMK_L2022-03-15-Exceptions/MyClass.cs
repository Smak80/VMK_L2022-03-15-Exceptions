using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMK_L2022_03_15_Exceptions
{
    public class MyClass
    {
        private int groupNumber;
        public int GroupNumber
        {
            get => groupNumber;
            set
            {
                if (value < 100 || value > 599)
                    throw new IncorrectGroupNumberException();
                groupNumber = value;
            }
        }

        public MyClass(int gr)
        {
            GroupNumber = gr;
        }
    }

    public class IncorrectGroupNumberException : Exception
    {
    }
}
