namespace Command.Pattern.Kata.Shapes
{
    public abstract class Shape
    {
        protected Shape(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; }
        public int Height { get; }
    }
}
