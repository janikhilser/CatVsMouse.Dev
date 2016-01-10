using System;
using System.Timers;
using System.Windows.Media;


namespace GameController
{
    public class GameController : IGameController
    {
        private IField[,] _fields;
        private Point _mousePosition;

        public GameController(IField[,] fields, Action<string> onPropertyChanged)
        {
            OnPropertyChanged = onPropertyChanged;
            Fields = fields;


            MouseDirection = Direction.Right;
            MousePosition = new Point(1, 1);
            Timer moveMouseTimer = new Timer(300);
            moveMouseTimer.Elapsed += OnMoveMouse;
            moveMouseTimer.Start();
        }

        private void OnMoveMouse(object sender, ElapsedEventArgs e)
        {
            switch (MouseDirection)
            {
                case Direction.Right:
                    MousePosition = new Point(MousePosition.X + 1, MousePosition.Y);
                    break;
                case Direction.Left:
                    MousePosition = new Point(MousePosition.X - 1, MousePosition.Y );
                    break;
                case Direction.Down:
                    MousePosition = new Point(MousePosition.X, MousePosition.Y + 1);
                    break;
                case Direction.Up:
                    MousePosition = new Point(MousePosition.X, MousePosition.Y - 1);
                    break;
            }
        }

        public IField[,] Fields
        {
            get { return _fields; }
            set
            {
                _fields = value;
                OnPropertyChanged("Fields");
            }
        }

        #region MousePosition and change methods
        public Point MousePosition
        {
            get { return _mousePosition; }
            set
            {
                ResetAndSetPosition(_mousePosition, value);
                _mousePosition = value;
            }
        }

        public Direction MouseDirection { get; set; }

        private void ResetAndSetPosition(Point oldPosition, Point newPosition)
        {
            if (oldPosition != null)
                Fields[oldPosition.Y, oldPosition.X].Background = Brushes.OrangeRed;
            Fields[newPosition.Y, newPosition.X].Background = Brushes.Black;

        }

        #endregion MousePosition and change methods

        public Action<string> OnPropertyChanged { get; set; }
    }
}
