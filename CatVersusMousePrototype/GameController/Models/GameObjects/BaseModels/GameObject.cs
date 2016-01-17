using System.ComponentModel;
using System.Runtime.CompilerServices;
using GameController.Models.GameObjects.Interfaces;

namespace GameController.Models.GameObjects.BaseModels
{
    public abstract class GameObject : IGameObject
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public abstract int X { get; set; }
        public abstract int Y { get; set; }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}