using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CatVersusMousePrototype.ViewModels;

namespace CatVersusMousePrototype.Views
{
    public class ContentTemplateSelector: DataTemplateSelector
    {
        public DataTemplate StartView { get; set; }
        public DataTemplate GameView { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var contains = item?.GetType().GetInterfaces().Contains(StartView?.DataType as Type);
            if (contains != null && (bool)contains)
                return StartView;

            contains = item?.GetType().GetInterfaces().Contains(GameView?.DataType as Type);
            if (contains != null && (bool)contains)
                return GameView;

            return null;
        }
    }
}