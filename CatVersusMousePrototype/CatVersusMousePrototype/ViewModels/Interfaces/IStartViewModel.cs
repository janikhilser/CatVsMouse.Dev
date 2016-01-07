using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Input;
using CatVersusMousePrototype.Framework.UI;

namespace CatVersusMousePrototype.ViewModels.Interfaces
{
    public interface IStartViewModel : IViewModelBase
    {
        ICommand StartGameCommand { get; set; }

        string StartGameText { get; set; }

    }


}