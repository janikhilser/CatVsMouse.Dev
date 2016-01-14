using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Media;
using CatVersusMousePrototype.Framework.UI;
using GameController;
using GameController.Models;
using GameController.Models.GameObjects;

namespace CatVersusMousePrototype.ViewModels.Interfaces
{
    public interface IGameViewModel : IViewModelBase
    {
        IGameModel GameModel { get; set; }
        
        
        //Commands
        ICommand BackToMainMenuCommand { get; set; }
    }
}