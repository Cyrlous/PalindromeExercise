using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("bob", true)]
        [InlineData("create", false)]
        [InlineData("civic", true)]
        [InlineData("geometry", false)]
        public void IsAPalindrome(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();
            
            //Act
            var actual = wordSmith.IsAPalindrome(word);
            
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
