using System.ComponentModel;

namespace GameController.Models.GameObjects.Interfaces
{
    public interface IGameObject :INotifyPropertyChanged
    {
        int X { get; set; }
        int Y { get; set; }
    }
}