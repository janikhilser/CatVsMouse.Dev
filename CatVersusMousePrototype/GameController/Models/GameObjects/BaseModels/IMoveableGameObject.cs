using System.Timers;
using GameController.Models.GameObjects.Interfaces;

namespace GameController.Models.GameObjects.BaseModels
{
    public interface IMoveableGameObject : IGameObject
    {
        ObjectTypeEnum ObjectType { get; set; }

        IGameModel GameModel { get; set; }

        Direction Direction { get; set; }

        void Move(object sender, ElapsedEventArgs e);
    }
}