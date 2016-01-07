using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Input;
using CatVersusMousePrototype.Framework.UI;
using CatVersusMousePrototype.ViewModels.Interfaces;

namespace CatVersusMousePrototype.ViewModels.Implementation
{
    public sealed class StartViewModel : ViewModelBase, IStartViewModel
    {
        private ICommand _startGameCommand;
        private string _startGameText;

        public StartViewModel(ViewModelMetadata viewModelMetadata): base(viewModelMetadata)
        {
            StartGameCommand = new RelayCommand(x => OnChangeViewModel(typeof(GameViewModel)));

            StartGameText = "Start Game!";
        }

        public ICommand StartGameCommand 
        {
            get { return _startGameCommand; }
            set { _startGameCommand = value; OnPropertyChanged(); }
        }

        public string StartGameText
        {
            get { return _startGameText; }
            set { _startGameText = value; OnPropertyChanged(); }
        }
    }
}