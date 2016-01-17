using System.Windows.Media;

namespace GameController.Models.GameObjects.Interfaces
{

    public interface IField
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