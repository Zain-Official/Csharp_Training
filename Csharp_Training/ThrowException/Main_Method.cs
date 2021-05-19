using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training.ThrowException
{
    class Main_Method
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter N Value");
            n = Convert.ToInt32(Console.ReadLine());
            Demo d = new Demo();

             try
            {
                d.Check(n);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }catch(IndexOutOfRangeException i)
            {
                Console.WriteLine(i.Message);
            }
        }
    }
}
