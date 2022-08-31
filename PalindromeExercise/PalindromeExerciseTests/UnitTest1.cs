using System;
using Xunit;
using PalindromeExerciseTests;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData("civic", true)]
        [InlineData("dog", false)]
        [InlineData("madam", true)]

        public void PalindromTest(string str, bool expected)
        {
            var palindrome1 = new Wordsmith();

            var actual = palindrome1.IsAPalindrome(str);

            Assert.Equal(expected, actual);

        }


    }
}
