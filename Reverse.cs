using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        public static String reverse(char[] arrData)
        {
            int nLen = arrData.Length;
            for (int i = 0; i < nLen / 2; ++i)
            {
                char temp = arrData[i];
                arrData[i] = arrData[nLen - i - 1];
                arrData[nLen - i - 1] = temp;
            }

            return new String(arrData);
        }

        static void Main(string[] args)
        {
            char[] test1 = "1234".ToCharArray();
            Console.WriteLine(reverse(test1).Equals("4321") ? "PASS" : "FAIL");

            char[] test2 = "aBc".ToCharArray();
            Console.WriteLine(reverse(test2).Equals("cBa") ? "PASS" : "FAIL");

            char[] test3 = "z3".ToCharArray();
            Console.WriteLine(reverse(test3).Equals("3z") ? "PASS" : "FAIL");

            char[] test4 = "q".ToCharArray();
            Console.WriteLine(reverse(test4).Equals("q") ? "PASS" : "FAIL");

            char[] test5 = "vtdqj2".ToCharArray();
            Console.WriteLine(reverse(test5).Equals("2jqdtv") ? "PASS" : "FAIL");

            Console.ReadLine();
        }
    }
}
