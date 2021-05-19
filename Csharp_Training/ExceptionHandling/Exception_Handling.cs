using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training.ExceptionHandling
{
    class Exception_Handling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 Number");
            try
            {
                int a, b, c;
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("The Division of  {0} / {1} = {2}", a, b, c);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Program From Maxvel....");
            }
        }
    }
}
