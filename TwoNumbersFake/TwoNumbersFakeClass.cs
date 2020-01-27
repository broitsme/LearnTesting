using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoNumbersNameSpace;

namespace TwoNumbersFakeNameSpace
{
    public class TwoNumbersFakeClass : TwoNumbersClass
    {
       
        public override void PutValues()
        {
            Random random = new Random();
            num1 = random.Next(1, 500);
            num2 = random.Next(501, 1000);
        }
    }
}
