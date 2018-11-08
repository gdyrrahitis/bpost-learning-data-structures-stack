namespace Command.Pattern.Kata.Commands
{
    using System.Collections.Generic;
    using System.Drawing;
    using Command.Pattern.Kata.Shapes;

    public class DrawTriangleCommand : ICommand
    {
        private readonly Bitmap _bitmap;
        private readonly Point _point;
        private readonly Graphics _graphics;
        private readonly Shape _shape;
        private readonly Color _color = Color.BlueViolet;

        public DrawTriangleCommand(Bitmap bitmap, Shape shape, Point point)
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
            var points = new Point[3];
            points[0].X = _point.X;
            points[0].Y = _point.Y;

            points[1].X = _point.X;
            points[1].Y = _point.Y + Height;

            points[2].X = _point.X + Width;
            points[2].Y = _point.Y;

            _graphics.DrawPolygon(new Pen(brush), points);
            _graphics.FillPolygon(brush, points);
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
            int ix = 0;
            for (int i = _point.X; i < _point.X + Width; i++)
                for (int j = _point.Y; j < _point.Y + Height; j++)
                    _bitmap.SetPixel(i, j, _previousState[ix++]);
        }
    }
}
