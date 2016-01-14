using System.Windows.Media;

namespace GameController.Models.GameObjects
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