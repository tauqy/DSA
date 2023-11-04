using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfAGivenStringIsSumString
{
    public class SumString
    {
        public bool IsSumString(string str)
        {
            int n = str.Length;

            //Choosing the firt two numbers and checking whether it is a sum-string or not
            for(int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (CheckSumString(str, 0, i, j))
                        return true;
                }
            }

            return false;
        }

        private bool CheckSumString(string str, int index, int start, int end)
        {
            //Finding the two substrings of given lengths and their sum
            string s1 = str.Substring(index, start);
            string s2 = str.Substring(index + start, end);
            string s3 = String_Sum(s1, s2);

            int s3_length = s3.Length;
            if (s3_length > str.Length - start - end - index)
                return false;

            //We got s3 as next number in main string
            if(s3 == str.Substring(index + start + end, s3_length))
            {
                //If we reach at the end of the string
                if (index + start + end + s3_length == str.Length)
                    return true;
                return CheckSumString(str, index + start, end, s3_length);
            }

            return false;
        }

        private String String_Sum(string str1, string str2)
        {
            if(str1.Length < str2.Length)
            {
                String temp = str1;
                str1 = str2;
                str2 = temp;
            }

            int m = str1.Length;
            int n = str2.Length;
            String ans = "";

            //sum the str2 with str1
            int carry = 0;
            for(int i = 0; i < n; i++)
            {
                //Sum of current digits
                int ds = ((str1[m - 1 - i] - '0') + (str2[n - 1 - i] - '0') + carry) % 10;
                carry = ((str1[m - 1 - i] - '0') + (str2[n - 1 - i] - '0') + carry) / 10;
                ans = (char)(ds + '0') + ans;
            }

            for(int i = n; i < m; i++)
            {
                int ds = (str1[m - 1 - i] - '0' + carry) % 10;
                carry = (str1[m - 1 - i] - '0' + carry) / 10;
                ans = (char)(ds + '0') + ans;
            }
            if (carry > 0)
                ans = (char)(carry + '0') + ans;
            return ans;
        }
    }
}
