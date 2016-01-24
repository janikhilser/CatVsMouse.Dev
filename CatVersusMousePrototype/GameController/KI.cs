using System;
using GameController.Models.GameObjects.BaseModels;

namespace GameController
{
    public static class Ki
    {
        public static Direction GetDirectionToPoint(IGameObject targetObject, IMoveableGameObject moveObject)
        {
            var xDif = moveObject.X - targetObject.X;
            var yDif = moveObject.Y - targetObject.Y;

            var xDifWithoutMinus = xDif;
            var yDifWithoutMinus = yDif;

            if (xDif.ToString().Contains("-"))
                xDifWithoutMinus = Int32.Parse(xDif.ToString().Remove(xDif.ToString().IndexOf("-"), 1));

            if (yDif.ToString().Contains("-"))
                yDifWithoutMinus = Int32.Parse(yDif.ToString().Remove(yDif.ToString().IndexOf("-"), 1));

            if (xDifWithoutMinus <= yDifWithoutMinus)
            {
                if (yDif.ToString().Contains("-"))
                    return Direction.Down;
                return Direction.Up;
            }
            if (xDifWithoutMinus >= yDifWithoutMinus)
            {
                if (yDif.ToString().Contains("-"))
                    return Direction.Right;
                return Direction.Left;
            }

            return Direction.Right;

        }
    }
}