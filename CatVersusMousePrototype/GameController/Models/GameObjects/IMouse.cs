using System.Windows.Media;

namespace GameController.Models.GameObjects
{
    public interface IMouse : IGameObject
    {
        Brush Color { get; set; }
        Direction Direction { get; set; }
    }
}