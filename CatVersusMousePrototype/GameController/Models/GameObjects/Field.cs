using System.ComponentModel;
using System.Windows.Media;

namespace GameController.Models.GameObjects
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
        public override ObjectTypeEnum ObjectType { get; set; }
    }
}