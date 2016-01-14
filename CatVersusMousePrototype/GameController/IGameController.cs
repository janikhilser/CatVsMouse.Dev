using System;
using GameController.Models;

namespace GameController
{
    public interface IGameController
    {
        IGameModel GameModel { get; set; }
       

        Action<string> OnPropertyChanged { get; set; }

    }

    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }
}
