using System.Timers;
using Microsoft.Win32;

namespace GameController.Models.GameObjects.Interfaces
{
    public interface IMoveableGameObject : IGameObject
    {
        ObjectTypeEnum ObjectType { get; set; }

        IGameModel GameModel { get; set; }

        Direction Direction { get; set; }

        void Move(object sender, ElapsedEventArgs e);
    }
}