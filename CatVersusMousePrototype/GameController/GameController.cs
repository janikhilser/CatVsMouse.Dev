using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GameController
{
    public class GameController : IGameController
    {
        private IField[,] _fields;

        public GameController(IField[,] fields, Action<string> onPropertyChanged)
        {
            OnPropertyChanged = onPropertyChanged;
            Fields = fields;
            Fields[2, 2].Background = Brushes.Black;
            Fields[3, 3].Background = Brushes.Red;
            Timer timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            //for (int i = 0; i < 20; i++)
            //{
            //    for (int x = 0; x < 20; x++)
            //    {
            //        Fields[i, x] = new Field()
            //        {
            //            FieldType = (FieldType) random.Next(0, 3),
            //            Height = 10,
            //            Width = 10
            //        };
            //    }
            //}

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Random random = new Random();
            Fields[random.Next(19), random.Next(19)].Background = Brushes.Red;
            //Fields[4, 4].Background = Brushes.Red;
        }

        public IField[,] Fields
        {
            get { return _fields; }
            set
            {
                _fields = value;
                OnPropertyChanged("Fields");
            }
        }

        public Action<string> OnPropertyChanged { get; set; }
    }
}
