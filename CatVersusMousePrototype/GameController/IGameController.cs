using System;
using GameController.Models;
using GameController.Models.GameObjects;
using GameController.Models.GameObjects.Interfaces;

namespace GameController
{
    public interface IGameController
    {
        IGameModel GameModel { get; set; }
    }

    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }
}
