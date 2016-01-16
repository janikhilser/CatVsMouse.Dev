using System;
using System.Timers;
using System.Windows.Media;
using GameController.Models.GameObjects;
using GameController.Models.GameObjects.Implementations;
using GameController.Models.GameObjects.Interfaces;

namespace GameController.Models
{
    public class GameModel : IGameModel
    {
        public int FieldHeight { get; set; }

        public int FieldWidth { get; set; }

        public IField[,] Fields { get; set; }

        public IMouse Mouse { get; set; }

        public ITestEnemy TestEnemy { get; set; }

        public void Initialize(GameModelInitModel initModel)
        {
            FieldHeight = initModel.Height;
            FieldWidth = initModel.Width;
            Fields = new IField[FieldHeight, FieldWidth];
            for (int x = 0; x < initModel.Width; x++)
            {
                for (int y = 0; y < initModel.Height; y++)
                {
                    if (x == 0 || x == initModel.Width-1 || y == 0 || y == initModel.Height-1)
                    {
                        Fields[y, x] = new Field()
                        {
                            Background = Brushes.Yellow,
                            X = x,
                            Y = y,
                            FieldType = FieldType.Wall
                        };
                    }

                    else
                        Fields[y, x] = new Field()
                        {
                            FieldType = FieldType.Blank,
                            Background = Brushes.Brown,
                            X = x,
                            Y = y
                        };
                }
            }

            Mouse = new Mouse(this);
            TestEnemy = new TestEnemy(this,y:2);
            Timer moveMouseTimer = new Timer(300);
            //moveMouseTimer.Elapsed += initModel.OnMoveMouse;
            moveMouseTimer.Elapsed += Mouse.Move;
            moveMouseTimer.Elapsed += TestEnemy.Move;
            moveMouseTimer.Start();
        }
    }
}