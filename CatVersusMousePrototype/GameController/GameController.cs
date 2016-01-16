using System;
using System.Timers;
using System.Windows.Media;
using GameController.Models;
using GameController.Models.GameObjects;
using GameController.Models.GameObjects.Interfaces;


namespace GameController
{
    public class GameController : IGameController
    {

        public GameController(IGameModel gameModel)
        {
            GameModel = gameModel;
            GameModel.Initialize(new GameModelInitModel() {Height = 30, Width = 30});
            //GameModel.FieldHeight = 20;
            //GameModel.FieldWidth = 20;
            //var test = new IField[GameModel.FieldHeight, GameModel.FieldWidth];
            //for (int x = 0; x < 20; x++)
            //{
            //    for (int y = 0; y < 20; y++)
            //    {
            //        if (x == 0 || x == 19 || y == 0 || y == 19)
            //        {
            //            test[y, x] = new Field()
            //            {
            //                Background = Brushes.Yellow,
            //                X = x,
            //                Y = y,
            //                FieldType = FieldType.Wall
            //            };
            //        }

            //        else
            //            test[y, x] = new Field()
            //            {
            //                FieldType = FieldType.Blank,
            //                Background = Brushes.Brown,
            //                X = x,
            //                Y = y
            //            };
            //    }
            //}
            //GameModel.Fields = new IField[GameModel.FieldHeight, GameModel.FieldWidth];
            //GameModel.Fields = test;


            //GameModel.Mouse = new Mouse();
            //GameModel.Mouse.Direction = Direction.Right;
            //Timer moveMouseTimer = new Timer(300);
            //moveMouseTimer.Elapsed += OnMoveMouse;
            //moveMouseTimer.Start();
        }

        //private void OnMoveMouse(object sender, ElapsedEventArgs e)
        //{
        //    switch (GameModel.Mouse.Direction)
        //    {
        //        case Direction.Right:
        //            MoveGameObject(GameModel.Mouse,0, +1);
        //            break;
        //        case Direction.Left:
        //            MoveGameObject(GameModel.Mouse,0, -1);
        //            break;
        //        case Direction.Down:
        //            MoveGameObject(GameModel.Mouse, 1, 0);
        //            break;
        //        case Direction.Up:
        //            MoveGameObject(GameModel.Mouse ,- 1, 0);
        //            break;
        //    }
        //}

        public IGameModel GameModel { get; set; }

        //public void MoveGameObject(IGameObject gameObject, int y, int x)
        //{
        //    if (gameObject != null)
        //        GameModel.Fields[gameObject.Y, gameObject.X].Background = Brushes.OrangeRed;


        //    gameObject.X = gameObject.X + x;
        //    gameObject.Y = gameObject.Y + y;

        //    GameModel.Fields[gameObject.Y, gameObject.X].Background = GameModel.Fields[gameObject.Y, gameObject.X].FieldType == FieldType.Wall ? Brushes.DeepPink : Brushes.Black;
        //}
    }
}
