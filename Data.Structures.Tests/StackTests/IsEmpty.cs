namespace Data.Structures.Tests.StackTests
{
    using Xunit;
    using static Xunit.Assert;

    public class IsEmpty
    {
        [Fact]
        public void WhenNoItemsStoredStackIsEmpty()
        {
            // Arrange
            var t = new System.Collections.Stack();
            var stack = new Stack<int>();

            // Act
            var result = stack.IsEmpty;

            // Assert
            True(result);
        }

        [Fact]
        public void WhenStackHasItemsItIsNotEmpty()
        {
            // Arrange
            var stack = new Stack<int>();
            stack.Push(10);

            // Act
            var result = stack.IsEmpty;

            // Assert
            False(result);
        }
    }
}
