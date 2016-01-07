using System.Collections.Generic;
using CatVersusMousePrototype.ViewModels;

namespace CatVersusMousePrototype.Framework.UI
{
    public interface IViewModelHandler : IViewModelBase
    {
        List<IViewModelBase> ViewModelList { get; set; }

        IViewModelBase SelectedViewModel { get; set; }
    }
}