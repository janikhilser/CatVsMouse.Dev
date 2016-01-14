using System.ComponentModel;

namespace GameController.Models.GameObjects
{
    public interface IGameObject :INotifyPropertyChanged
    {
        int X { get; set; }
        int Y { get; set; }
        ObjectTypeEnum ObjectType { get; set; }
    }
}