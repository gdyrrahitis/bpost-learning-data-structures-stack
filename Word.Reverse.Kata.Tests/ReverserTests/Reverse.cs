namespace Word.Reverse.Kata.Tests.ReverserTests
{
    using Xunit;
    using static Xunit.Assert;

    public class Reverse
    {
        [Theory]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        [InlineData("george", "egroeg")]
        [InlineData("kata", "atak")]
        [InlineData("stack", "kcats")]
        [InlineData("eye", "eye")] // This is a palindrome!
        public void ShouldReverseWordSuccessfully(string input, string expected)
        {
            // Arrange | Act
            var result = Reverser.Reverse(input);

            // Assert
            Equal(expected, result);
        }
    }
}
