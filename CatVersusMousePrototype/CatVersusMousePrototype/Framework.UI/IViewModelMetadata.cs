using System;

namespace CatVersusMousePrototype.Framework.UI
{
    public interface IViewModelMetadata
    {
        Action<Type> ChangeViewModel { get; set; }
    }
}