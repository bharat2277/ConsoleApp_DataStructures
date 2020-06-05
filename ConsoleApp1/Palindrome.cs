using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Palindrome
    {
        /// <summary>
        /// It's a word , which is same when read it from Left to Right & Right to Left
        /// 1. first letter = last letter
        /// 2. inner word also should be palindrome
        ///     str[i,i+1...j-1,j] 
        ///     bool isInnerWordPalindrome= isPailndrome[i+1][j-1] or (j-i <=2) 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetLongestPalindrome(string str)
        {
            int length = str.Length;

            if (length < 2)
            {
                return str;
            }

            bool[,] isPalindrome = new bool[length, length];

            int left = 0;
            int right = 0;

            for (int j = 1; j < length; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    bool isInnerWordPalindrome = isPalindrome[i + 1, j - 1] || j - i <= 2;

                    if (str.Substring(i, 1) == str.Substring(j, 1) && isInnerWordPalindrome)
                    {
                        isPalindrome[i, j] = true;

                        if (j - i > right - left)
                        {
                            left = i;
                            right = j;
                        }
                    }
                }
            }

            return str.Substring(left, right - left + 1);
        }
    }
}
