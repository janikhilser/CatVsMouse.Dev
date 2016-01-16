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
            switch (GameModel.Mouse.Direction)
            {
                case Direction.Right:
                    MoveMouse(0, +1);
                    break;
                case Direction.Left:
                    MoveMouse(0, -1);
                    break;
                case Direction.Down:
                    MoveMouse(1, 0);
                    break;
                case Direction.Up:
                    MoveMouse(-1, 0);
                    break;
            }
        }

        public void MoveMouse(int y, int x)
        {
            if (GameModel.Mouse != null)
                GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.OrangeRed;


            GameModel.Mouse.X = GameModel.Mouse.X + x;
            GameModel.Mouse.Y = GameModel.Mouse.Y + y;

            if (GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].FieldType == FieldType.Wall)
                GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.DeepPink;
            else
                GameModel.Fields[GameModel.Mouse.Y, GameModel.Mouse.X].Background = Brushes.Black;
        }

        public IGameModel GameModel { get; set; }


        public Action<string> OnPropertyChanged { get; set; }
    }
}
