namespace Word.Reverse.Kata
{
    using Data.Structures;
    using System.Text;

    public static class Reverser
    {
        public static string Reverse(string word)
        {
            var stack = new Stack<char>();
            foreach (var character in word)
            {
                stack.Push(character);
            }

            var builder = new StringBuilder();
            while (!stack.IsEmpty)
            {
                builder.Append(stack.Pop());
            }

            return builder.ToString();
        }
    }
}
