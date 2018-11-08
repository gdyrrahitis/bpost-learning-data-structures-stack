namespace Command.Pattern.Kata.Commands
{
    using Command.Pattern.Kata.Shapes;
    using System.Collections.Generic;
    using System.Drawing;

    public class DrawRectangleCommand : ICommand
    {
        private readonly Bitmap _bitmap;
        private readonly Point _point;
        private readonly Graphics _graphics;
        private readonly Shape _shape;
        private readonly Color _color = Color.BlueViolet;

        public DrawRectangleCommand(Bitmap bitmap, Shape shape, Point point)
        {
            _bitmap = bitmap;
            _point = point;
            _graphics = Graphics.FromImage(_bitmap);
            _shape = shape;
        }

        private IList<Color> _previousState { get; set; } = new List<Color>();
        private int Width { get => _shape.Width; }
        private int Height { get => _shape.Height; }

        public void Draw()
        {
            SavePreviousState();

            var brush = new SolidBrush(_color);
            var rectangle = new System.Drawing.Rectangle(_point.X, _point.Y, Width, Height);
            _graphics.FillRectangle(brush, rectangle);
        }

        private void SavePreviousState()
        {
            for (int i = _point.X; i < _point.X + Width; i++)
            {
                for (int j = _point.Y; j < _point.Y + Height; j++)
                {
                    _previousState.Add(_bitmap.GetPixel(i, j));
                }
            }
        }

        public void Undo()
        {
            var points = 0;
            for (int i = _point.X; i < _point.X + Width; i++)
                for (int j = _point.Y; j < _point.Y + Height; j++)
                    _bitmap.SetPixel(i, j, _previousState[points++]);
        }
    }
}
