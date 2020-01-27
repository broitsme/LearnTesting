using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PermissionNameSpace;
using TwoNumbersNameSpace;
namespace LearnTestingNameSpace
{
    public class Program
    {
        public static void Main(String[] args) { }
        public static int AddWithPermission(TwoNumbersClass twoNumbers, Permission Perm)
        {
            if ((bool)Perm.ExternalMethod())
            {
                return twoNumbers.num1 + twoNumbers.num2;
            }
            return 0;
        }
    }
}
