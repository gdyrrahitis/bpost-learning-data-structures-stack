namespace Command.Pattern.WForm
{
    using Command.Pattern.Kata.Commands;
    using Command.Pattern.Kata.Shapes;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Rect = Kata.Shapes.Rectangle;

    public partial class MainForm : Form
    {
        private Type _activeShape;
        private Stack<ICommand> _commands = new Stack<ICommand>();
        private Bitmap _bitmap;
        private Graphics _graphics;

        public MainForm()
        {
            InitializeComponent();

            _bitmap = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            canvas.Image = _bitmap;
            _graphics = Graphics.FromImage(canvas.Image);

            RefreshWindow();
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            _activeShape = typeof(Square);
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            _activeShape = typeof(Rect);
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            _activeShape = typeof(Triangle);
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (_commands.Any())
            {
                var command = _commands.Pop();
                command.Undo();
            }

            RefreshWindow();
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            var command = GetCommand(e.X, e.Y);
            command.Draw();

            _commands.Push(command);

            RefreshWindow();
        }

        private void RefreshWindow()
        {
            canvas.Refresh();
            undoButton.Enabled = _commands.Any();
        }

        private ICommand GetCommand(int x, int y)
        {
            switch (_activeShape)
            {
                case var square when square == typeof(Square):
                    return new DrawSquareCommand(_bitmap, new Square(100, 100), new Point(x, y));
                case var rectangle when rectangle == typeof(Rect):
                    return new DrawRectangleCommand(_bitmap, new Rect(100, 50), new Point(x, y));
                case var triangle when triangle == typeof(Triangle):
                    return new DrawTriangleCommand(_bitmap, new Triangle(70, 35), new Point(x, y));
                default:
                    throw new ArgumentOutOfRangeException("Cannot recognize shape.");
            }
        }
    }
}
