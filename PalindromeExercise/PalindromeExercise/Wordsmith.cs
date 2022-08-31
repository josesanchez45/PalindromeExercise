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
            return str.SequenceEqual(str.Reverse());
        }
    }
}