using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training.ThrowException
{
    class Demo
    {
        public void Check(int n)
        {
            if(n<0)
            {
                throw new DivideByZeroException("Negative No Not Allowed.....");
            }
            else if(n==0)
            {
                throw new IndexOutOfRangeException("Zero is Invalid Value");
            }
            else
            {
                Console.WriteLine("N value is "+n);
            }
        }
    }
}
