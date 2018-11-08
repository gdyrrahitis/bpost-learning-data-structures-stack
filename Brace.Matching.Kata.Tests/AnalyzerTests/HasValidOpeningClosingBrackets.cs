namespace Brace.Matching.Kata.Tests.AnalyzerTests
{
    using Xunit;
    using static Xunit.Assert;

    public class HasValidOpeningClosingBrackets
    {
        [Theory]
        [InlineData("hi", true)]
        [InlineData("{}", true)]
        [InlineData("[}", false)]
        [InlineData("{hi(george)}", true)]
        [InlineData("{hi(george]}", false)]
        [InlineData("[{hi(george]})", false)]
        [InlineData("([{[}}])", false)]
        public void ReturnsExpectedOutputForStringWithBrackets(string input, bool expected)
        {
            // Arrange | Act
            var result = Analyzer.HasValidOpeningClosingBrackets(input);

            // Assert
            Equal(expected, result);
        }
    }
}
