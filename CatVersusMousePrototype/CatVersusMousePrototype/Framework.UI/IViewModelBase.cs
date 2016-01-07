using System;
using System.ComponentModel;
using System.Windows.Input;

namespace CatVersusMousePrototype.Framework.UI
{
    public interface IViewModelBase : INotifyPropertyChanged
    {
        Action<Type> OnChangeViewModel { get; set; }
    }
}