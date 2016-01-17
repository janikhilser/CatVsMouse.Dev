using GameController.Models.GameObjects;
using GameController.Models.GameObjects.Implementations;
using GameController.Models.GameObjects.Interfaces;

namespace GameController.Models
{
    public interface IGameModel
    {
        int FieldHeight { get; set; }
        int FieldWidth { get; set; }
        IField[,] Fields { get; set; }
        Mouse Mouse { get; set; }
        void Initialize(GameModelInitModel initModel);
    }
}