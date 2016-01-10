using System;

namespace GameController
{
    public interface IGameController
    {
        IField[,] Fields { get; set; }
        
        Point MousePosition { get; set; }
        Direction MouseDirection { get; set; }

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
