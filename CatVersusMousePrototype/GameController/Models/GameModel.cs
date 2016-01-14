using GameController.Models.GameObjects;

namespace GameController.Models
{
    public class GameModel : IGameModel
    {
        public int FieldHeight { get; set; }
        public int FieldWidth { get; set; }
        public IField[,] Fields { get; set; }
        public IMouse Mouse { get; set; }
    }
}