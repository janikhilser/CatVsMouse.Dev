using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameController.Models.GameObjects
{
    public abstract class GameObject : IGameObject
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public abstract int X { get; set; }
        public abstract int Y { get; set; }
        public abstract ObjectTypeEnum ObjectType { get; set; }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}