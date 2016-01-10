using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Media;
using CatVersusMousePrototype.Framework.UI;
using GameController;

namespace CatVersusMousePrototype.ViewModels.Interfaces
{
    public interface IGameViewModel : IViewModelBase
    {
        int FieldHeight { get; set; }
        int FieldWidth { get; set; }
        IField[,] Fields { get; set; }
        
        //Commands
        ICommand BackToMainMenuCommand { get; set; }
    }
}