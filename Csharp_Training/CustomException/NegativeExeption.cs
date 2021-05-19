using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Training.CustomException
{
    public class NegativeExeption : ApplicationException
    {
        public NegativeExeption(string error) : base(error)
        {

        }
    }

}
