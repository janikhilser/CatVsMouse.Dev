using System;
using System.Timers;
using System.Windows.Media;
using GameController.Models;
using GameController.Models.GameObjects;


namespace GameController
{
    public class GameController : IGameController
    {

        public GameController(IGameModel gameModel, Action<string> onPropertyChanged)
        {
            //IField[,] fields
            OnPropertyChanged = onPropertyChanged;
            GameModel = gameModel;

            GameModel.FieldHeight = 20;
            GameModel.FieldWidth = 20;
            var test = new IField[GameModel.FieldHeight, GameModel.FieldWidth];
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (x == 0 || x == 19 || y == 0 || y == 19)
                    {
                        test[y, x] = new Field()
                        {
                            Background = Brushes.Yellow,
                            X = x,
                            Y = y,
                            FieldType = FieldType.Wall
                        };
                    }

                    else
                        test[y, x] = new Field()
                        {
                            FieldType = FieldType.Blank,
                            Background = Brushes.Brown,
                            X = x,
                            Y = y
                        };
                }
            }
            GameModel.Fields = new IField[GameModel.FieldHeight, GameModel.FieldWidth];
            GameModel.Fields = test;


            GameModel.Mouse = new Mouse();
            GameModel.Mouse.Direction = Direction.Right;
            Timer moveMouseTimer = new Timer(300);
            moveMouseTimer.Elapsed += OnMoveMouse;
            moveMouseTimer.Start();
        }

        private void OnMoveMouse(object sender, ElapsedEventArgs e)
        {
            MoveMouse();
        }

        private void MoveMouse()
        {
            switch (GameModel.Mouse.Direction)
            {
                case Direction.Right:
                    if (GameModel.Mouse != null)
                        GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.OrangeRed;


                    GameModel.Mouse.X = GameModel.Mouse.X + 1;
                    GameModel.Mouse.Y = GameModel.Mouse.Y;

                    if (GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].FieldType == FieldType.Wall)
                        GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.DeepPink;
                    else
                        GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.Black;

                    break;
                case Direction.Left:
                    if (GameModel.Mouse != null)
                        GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.OrangeRed;

                    GameModel.Mouse.X = GameModel.Mouse.X - 1;
                    GameModel.Mouse.Y = GameModel.Mouse.Y;

                    if (GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].FieldType == FieldType.Wall)
                        GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.DeepPink;
                    else
                        GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.Black;
                    break;
                case Direction.Down:
                    if (GameModel.Mouse != null)
                        GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.OrangeRed;

                    GameModel.Mouse.X = GameModel.Mouse.X;
                    GameModel.Mouse.Y = GameModel.Mouse.Y + 1;

                    if (GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].FieldType == FieldType.Wall)
                        GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.DeepPink;
                    else
                        GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.Black;
                    break;
                case Direction.Up:
                    if (GameModel.Mouse != null)
                        GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.OrangeRed;

                    GameModel.Mouse.X = GameModel.Mouse.X;
                    GameModel.Mouse.Y = GameModel.Mouse.Y - 1;

                    if (GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].FieldType == FieldType.Wall)
                        GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.DeepPink;
                    else
                        GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.Black;
                    break;
            }
        }

        //public IField[,] Fields
        //{
        //    get { return _fields; }
        //    set
        //    {
        //        _fields = value;
        //        OnPropertyChanged("Fields");
        //    }
        //}

        public IGameModel GameModel { get; set; }


        public Action<string> OnPropertyChanged { get; set; }
    }
}
