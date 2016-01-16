using System;
using CatVersusMousePrototype.ViewModels;

namespace CatVersusMousePrototype.Framework.UI
{
    public class ViewModelMetadata : IViewModelMetadata
    {
        public ViewModelMetadata(Action<Type> changeViewModel = null)
        {
            ChangeViewModel = changeViewModel;
        }

        public Action<Type> ChangeViewModel { get; set; }
    }
}