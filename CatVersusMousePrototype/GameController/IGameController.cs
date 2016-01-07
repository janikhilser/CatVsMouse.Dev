using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameController
{
    public interface IGameController
    {
        IField[,] Fields { get; set; }
        Action<string> OnPropertyChanged { get; set; }
    }
}
