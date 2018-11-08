namespace Data.Structures.Tests.StackTests
{
    using System;
    using Xunit;
    using static Xunit.Assert;

    public class Peek
    {
        [Fact]
        public void WhenStackIsEmptyThrowsException()
        {
            // Arrange
            var stack = new Stack<int>();

            // Act
            var exception = Throws<Exception>(() => stack.Peek());

            // Assert
            Equal("Stack is empty", exception.Message);
        }

        [Theory]
        [InlineData(new[] { 5 }, 5)]
        [InlineData(new[] { 5, 2, 10 }, 10)]
        public void WhenStackHasItemsReturnsTopItem(int[] items, int expected)
        {
            // Arrange
            var stack = new Stack<int>();
            foreach (var item in items)
            {
                stack.Push(item);
            }

            // Act
            var result = stack.Peek();

            // Assert
            Equal(expected, result);
        }
    }
}
