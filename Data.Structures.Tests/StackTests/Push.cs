namespace Data.Structures.Tests.StackTests
{
    using System;
    using Xunit;
    using static Xunit.Assert;

    public class Push
    {
        [Fact]
        public void WhenStackIsFullThrowsException()
        {
            // Arrange
            var stack = new Stack<int>(5);
            for (var i = 0; i < 5; i++)
            {
                stack.Push(i);
            }

            // Act
            var exception = Throws<Exception>(() => stack.Push(6));

            // Assert
            Equal("Stack is full", exception.Message);
        }

        [Theory]
        [InlineData(new[] { 5 }, 5)]
        [InlineData(new[] { 5, 2, 10 }, 10)]
        public void WhenPushesNewItemItIsStoredOnStackTop(int[] items, int expected)
        {
            // Arrange
            var stack = new Stack<int>();

            // Act
            foreach (var item in items)
            {
                stack.Push(item);
            }

            // Assert
            var result = stack.Peek();
            Equal(expected, result);
        }
    }
}
