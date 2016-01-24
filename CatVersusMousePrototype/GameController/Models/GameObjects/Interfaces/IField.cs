using System.Windows.Media;
using GameController.Models.GameObjects.BaseModels;

namespace GameController.Models.GameObjects.Interfaces
{

    public interface IField : IGameObject
    {
        FieldType FieldType { get; set; }
        int Height { get; set; }
        int Width { get; set; }
        Brush Background { get; set; }
    }

    public enum FieldType
    {
        Blank,
        Bacon,
        Cheese,
        Wall
    }
}