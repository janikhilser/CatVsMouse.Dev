using System;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using CatVersusMousePrototype.Framework.UI;
using CatVersusMousePrototype.ViewModels.Interfaces;
using GameController;

namespace CatVersusMousePrototype.ViewModels.Implementation
{
    public class GameViewModel : ViewModelBase, IGameViewModel
    {
        private IField[,] _fields;
        private ICommand _backToMainMenuCommand;
        private int _fieldHeight;
        private int _fieldWidth;
        private Direction _direction;
        public IGameController GameController { get; set; }

        public GameViewModel(ViewModelMetadata viewModelMetadata) : base(viewModelMetadata)
        {
            BackToMainMenuCommand = new RelayCommand(x => OnChangeViewModel(typeof(StartViewModel)));
            KeyDownCommand = new RelayCommand(HandleKeyDownCommand);

            FieldHeight = 20;
            FieldWidth = 20;

            var test = new IField[FieldHeight, FieldWidth];
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (x == 10)
                        test[y, x] = new Field()
                        {
                            Background = Brushes.Yellow,
                            X = x,
                            Y = y,
                        };
                    else
                        test[y, x] = new Field()
                        {
                            Background = Brushes.Brown,
                            X = x,
                            Y = y
                        };
                }
            }
            Fields = new IField[FieldHeight, FieldWidth];
            Fields = test;
            GameController = new GameController.GameController(Fields, OnPropertyChanged);
        }

        public ICommand BackToMainMenuCommand
        {
            get { return _backToMainMenuCommand; }
            set { _backToMainMenuCommand = value; OnPropertyChanged(); }
        }

        public int FieldHeight
        {
            get { return _fieldHeight; }
            set { _fieldHeight = value; OnPropertyChanged(); }
        }

        public int FieldWidth
        {
            get { return _fieldWidth; }
            set { _fieldWidth = value; OnPropertyChanged(); }
        }

        public IField[,] Fields
        {
            get { return _fields; }
            set { _fields = value; OnPropertyChanged(); }
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
                if (value != _direction)
                    GameController.MouseDirection = value;
                _direction = value;
            }
        }

        #endregion KeyDown methods and members
    }
}