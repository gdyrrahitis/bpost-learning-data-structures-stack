namespace Brace.Matching.Kata
{
    using Data.Structures;

    public static class Analyzer
    {
        public static bool HasValidOpeningClosingBrackets(string input)
        {
            var stack = new Stack<char>(input.Length);
            foreach (var character in input)
            {
                switch (character)
                {
                    case '{':
                    case '[':
                    case '(':
                        stack.Push(character);
                        break;

                    case '}':
                    case ']':
                    case ')':
                        var stored = stack.Pop();
                        if (stored == '{' && character != '}' ||
                            stored == '[' && character != ']' ||
                            stored == '(' && character != ')')
                        {
                            return false;
                        }
                        break;
                    default:
                        break;
                }
            }

            return true;
        }
    }
}
