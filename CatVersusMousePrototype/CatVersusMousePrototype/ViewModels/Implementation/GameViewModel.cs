using System;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using CatVersusMousePrototype.Framework.UI;
using CatVersusMousePrototype.ViewModels.Interfaces;
using GameController;
using GameController.Models;
using GameController.Models.GameObjects;

namespace CatVersusMousePrototype.ViewModels.Implementation
{
    public class GameViewModel : ViewModelBase, IGameViewModel
    {
        private IGameModel _gameModel;
        private ICommand _backToMainMenuCommand;
        private Direction _direction;
        public IGameController GameController { get; set; }

        public GameViewModel(ViewModelMetadata viewModelMetadata) : base(viewModelMetadata)
        {
            BackToMainMenuCommand = new RelayCommand(x => OnChangeViewModel(typeof(StartViewModel)));
            KeyDownCommand = new RelayCommand(HandleKeyDownCommand);

            GameModel = new GameModel();


            GameController = new GameController.GameController(GameModel);
        }

        public ICommand BackToMainMenuCommand
        {
            get { return _backToMainMenuCommand; }
            set { _backToMainMenuCommand = value; OnPropertyChanged(); }
        }

        public IGameModel GameModel
        {
            get { return _gameModel; }
            set { _gameModel = value; OnPropertyChanged(); }
        }

        #region KeyDown methods and members
        //KeyDown Methods and Members
        private void HandleKeyDownCommand(object parameter)
        {
            var keyType = (Key)parameter;
            switch (keyType)
            {
                case Key.Right:
                    Direction = Direction.Right;
                    break;
                case Key.Left:
                    Direction = Direction.Left;
                    break;
                case Key.Up:
                    Direction = Direction.Up;
                    break;
                case Key.Down:
                    Direction = Direction.Down;
                    break;
            }
        }

        private Direction Direction
        {
            get { return _direction; }
            set
            {
                GameController.GameModel.Mouse.Direction = value;
                _direction = value;
            }
        }

        #endregion KeyDown methods and members
    }
}