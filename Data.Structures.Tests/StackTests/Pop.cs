namespace Data.Structures.Tests.StackTests
{
    using System;
    using Xunit;
    using static Xunit.Assert;

    public class Pop
    {
        [Fact]
        public void WhenStackIsEmptyThrowsException()
        {
            // Arrange
            var stack = new Stack<int>();

            // Act
            var exception = Throws<Exception>(() => stack.Pop());

            // Assert
            Equal("Stack is empty", exception.Message);
        }

        [Theory]
        [InlineData(new[] { 5 }, 5)]
        [InlineData(new[] { 5, 2, 10 }, 10)]
        public void WhenStackHasItemsReturnsAndRemovesTopItem(int[] items, int expected)
        {
            // Arrange
            var stack = new Stack<int>(16);
            foreach (var item in items)
            {
                stack.Push(item);
            }

            // Act
            var result = stack.Pop();

            // Assert
            Equal(expected, result);
        }
    }
}
