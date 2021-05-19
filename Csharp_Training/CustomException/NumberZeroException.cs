using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training.CustomException
{
   public class NumberZeroException : ApplicationException
    {
        public NumberZeroException(string error) : base(error)
        {

        }
    }
}
