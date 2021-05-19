using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training.CustomException
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter Any Two Number");
            a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            Validation_Class vc = new Validation_Class();
            try
            {

                vc.Check(a, b);
    }
            catch (NegativeExeption e)
            {
                Console.WriteLine(e.Message);

            }catch(NumberZeroException d)
            {
                Console.WriteLine(d.Message);
            }

          
        }

    }
}
