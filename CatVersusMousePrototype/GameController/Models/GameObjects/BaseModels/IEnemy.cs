using GameController.Models.GameObjects.Interfaces;

namespace GameController.Models.GameObjects.BaseModels
{
    public interface IEnemy
    {
        Direction GetDirection();
    }
}