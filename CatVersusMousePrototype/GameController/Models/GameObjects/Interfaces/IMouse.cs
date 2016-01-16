using System.Windows.Media;

namespace GameController.Models.GameObjects.Interfaces
{
    public interface IMouse : IMoveableGameObject
    {
        Brush Color { get; set; }
    }
}