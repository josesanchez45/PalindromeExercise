using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class Wordsmith
    {
        public bool IsAPalindrome(string str)
        {
            if (str =="" || str == null) 
            {
                return false;
            }

            return str.ToLower().SequenceEqual(str.Reverse());
        }
    }
}