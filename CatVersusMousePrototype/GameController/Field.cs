using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace GameController
{
    public class Field : IField
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

        public int X { get; set; }
        public int Y { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}