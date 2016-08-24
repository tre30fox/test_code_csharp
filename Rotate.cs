using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Rotate
{
    class Rotate
    {
    	/*
    	주어진 data 와 rotated 가 circular rotate(순환 회전) 관계인지 여부 반환
    	즉, 전체 문자열이 좌/우로 이동한 상태, 이동한 문자열이 한쪽 끝에 다다르면 반대편 끝에서 나타남.
    	ex)
    	  data == "abc" and rotated == "cab"  => true
    	  data == "abc" and rotated == "acb"  => false
    	*/
        static bool rotate(String strSrc, String strRotated)
        {

            char[] arrSrc = strSrc.ToCharArray();
            char[] arrRotated = strRotated.ToCharArray();

            if (arrSrc.Length != arrRotated.Length)
            {
                return false;
            }

            int nLen = arrSrc.Length;

            for (int nShift = 0; nShift < nLen; ++nShift)
            {
                bool bResult = true;
                for (int nCol = 0; nCol < nLen; ++nCol)
                {
                    if (arrSrc[nCol] != arrRotated[(nCol + nShift) % nLen])
                    {
                        bResult = false;
                        break;
                    }
                }
                if (bResult)
                    return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(rotate("abc", "cab") == true ? "PASS" : "FAIL");
            Console.WriteLine(rotate("abc", "bca") == true ? "PASS" : "FAIL");
            Console.WriteLine(rotate("abc", "abc") == true ? "PASS" : "FAIL");
            Console.WriteLine(rotate("abc", "bac") == false ? "PASS" : "FAIL");
            Console.WriteLine(rotate("abc", "acb") == false ? "PASS" : "FAIL");

            Console.WriteLine(rotate("1324", "1324") == true ? "PASS" : "FAIL");
            Console.WriteLine(rotate("1324", "4132") == true ? "PASS" : "FAIL");
            Console.WriteLine(rotate("1324", "2413") == true ? "PASS" : "FAIL");
            Console.WriteLine(rotate("1324", "3241") == true ? "PASS" : "FAIL");
            Console.WriteLine(rotate("1324", "1234") == false ? "PASS" : "FAIL");
            Console.WriteLine(rotate("1324", "2314") == false ? "PASS" : "FAIL");

            Console.ReadLine();
        }
    }
}
