using System.Windows.Media;
using GameController.Models.GameObjects.Interfaces;

namespace GameController.Models.GameObjects.Implementations
{
    public sealed class Mouse : MoveableGameObject,IMouse
    {
        public Mouse(IGameModel gameModel, int x = 1, int y = 1, Direction direction = Direction.Right): base(gameModel, direction)
        {          
            X = x;
            Y = y;
            ObjectType = ObjectTypeEnum.Mouse;
        }
        
        public override ObjectTypeEnum ObjectType { get; set; }
        public Brush Color { get; set; }
        public override int X { get; set; }
        public override int Y { get; set; }
    }
}