using System.Windows.Media;
using GameController.Models.GameObjects.Interfaces;

namespace GameController.Models.GameObjects.Implementations
{
    public class Field : GameObject, IField
    {
        private Brush _background;
        public FieldType FieldType { get; set; } = FieldType.Blank;
        public int Height { get; set; }
        public int Width { get; set; }

        public Brush Background
        {
            get { return _background; }
            set { _background = value; OnPropertyChanged(); }
        }
        public override int X { get; set; }
        public override int Y { get; set; }
        
    }
}