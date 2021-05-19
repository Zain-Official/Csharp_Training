using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training.DealsWithError
{
    class Main_Method
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 12, 5 };
            try
            {
                a[10] = 66;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
