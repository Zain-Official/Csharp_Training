using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training.CustomException
{
    class Validation_Class : ApplicationException
    {

       

        public void Check(int a,int b)
        {
            if(a < 0 || b <0)
            {
                throw new NegativeExeption("Negative Number Not Allow.....!");
            }
            else if(a ==0 || b==0)
            {
                throw new NumberZeroException("Zero Number Not Allowed......!");

            }
            else
            {
                int c = a + b;
                Console.WriteLine("The Sum Of {0} + {1} = {2}",a,b,c);
            }
        }
    }
}
