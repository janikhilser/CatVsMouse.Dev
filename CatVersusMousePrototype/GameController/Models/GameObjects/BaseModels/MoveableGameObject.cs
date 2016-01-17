using System.Timers;
using System.Windows.Media;
using GameController.Models.GameObjects.Implementations;
using GameController.Models.GameObjects.Interfaces;

namespace GameController.Models.GameObjects.BaseModels
{
    public abstract class MoveableGameObject : GameObject, IMoveableGameObject
    {
        public abstract ObjectTypeEnum ObjectType { get; set; }
        public IGameModel GameModel { get; set; }
        public Direction Direction { get; set; }

        protected MoveableGameObject(IGameModel gameModel, Direction direction)
        {
            GameModel = gameModel;
            Direction = direction;
        }

        public void Move(object sender, ElapsedEventArgs e)
        {
            switch (Direction)
            {
                case Direction.Right:
                    OnMove(0, +1);
                    break;
                case Direction.Left:
                    OnMove(0, -1);
                    break;
                case Direction.Down:
                    OnMove(1, 0);
                    break;
                case Direction.Up:
                    OnMove(-1, 0);
                    break;
            }
        }
        private void OnMove(int y, int x)
        {
            GameModel.Fields[Y, X].Background = Brushes.OrangeRed;

            X = X + x;
            Y = Y + y;

            GameModel.Fields[Y, X].Background = GameModel.Fields[Y, X].FieldType == FieldType.Wall ? Brushes.DeepPink : Brushes.Black;
        }
    }
}