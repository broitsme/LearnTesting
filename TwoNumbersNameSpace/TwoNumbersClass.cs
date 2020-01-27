using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TwoNumbersNameSpace
{
    public class TwoNumbersClass 
    {
        public static void Main(String[] args) { }

        public int num1, num2;
        public TwoNumbersClass()
        {
            PutValues();
        }
        virtual public void PutValues()
        {
            Random random = new Random();
            num1 = random.Next(-1000, -500);
            num2 = random.Next(-499, 0);
        }
    }
}