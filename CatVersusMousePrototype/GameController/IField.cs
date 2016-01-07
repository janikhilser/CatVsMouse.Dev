using System.ComponentModel;
using System.Windows.Media;

namespace GameController
{

    public interface IField : INotifyPropertyChanged
    {
        FieldType FieldType { get; set; }
        int Height { get; set; }
        int Width { get; set; }
        Brush Background { get; set; }
        int X { get; set; }
        int Y { get; set; }
    }

    public enum FieldType
    {
        Blank,
        Bacon,
        Cheese,
        Wall
    }
}