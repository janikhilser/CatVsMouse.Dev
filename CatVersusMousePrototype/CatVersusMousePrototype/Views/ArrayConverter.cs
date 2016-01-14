using System;
using System.Collections.Generic;
using System.Windows.Data;
using GameController;
using GameController.Models.GameObjects;

namespace CatVersusMousePrototype.Views
{
    public class ArrayConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var val = value as IField[,];
            if (val == null) return null;
            return ToEnumerable(val);
        }

        private IEnumerable<IEnumerable<IField>> ToEnumerable(IField[,] array)
        {
            var count = array.GetLength(0);

            for (int i = 0; i < array.GetLength(0); ++i)
            {
                yield return GetLine(array, i);
            }
        }

        private IEnumerable<IField> GetLine(IField[,] array, int line)
        {
            var count = array.GetLength(1);
            for (int i = 0; i < count; ++i)
            {
                yield return array[line, i];
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}