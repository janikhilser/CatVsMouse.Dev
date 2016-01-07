using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using CatVersusMousePrototype.Annotations;
using CatVersusMousePrototype.ViewModels;

namespace CatVersusMousePrototype.Framework.UI
{
    public class ViewModelBase : IViewModelBase
    {
        public ViewModelBase(ViewModelMetadata viewModelMetadata = null)
        {
            OnChangeViewModel = viewModelMetadata?.ChangeViewModel;
        }

        public Action<Type> OnChangeViewModel { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}