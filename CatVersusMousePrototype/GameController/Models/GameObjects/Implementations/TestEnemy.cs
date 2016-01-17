using GameController.Models.GameObjects.BaseModels;
using GameController.Models.GameObjects.Interfaces;

namespace GameController.Models.GameObjects.Implementations
{
    public class TestEnemy: Enemy
    {
        public override int X { get; set; }
        public override int Y { get; set; }
        public override ObjectTypeEnum ObjectType { get; set; }

        public TestEnemy(IGameModel gameModel, int x = 1, int y = 1, Direction direction = Direction.Right) : base(gameModel, direction)
        {
            X = x;
            Y = y;
            ObjectType = ObjectTypeEnum.Cat;
        }
    }
}