using System;
using System.Collections.Generic;
using System.Windows.Input;
using CatVersusMousePrototype.ViewModels;
using CatVersusMousePrototype.ViewModels.Implementation;

namespace CatVersusMousePrototype.Framework.UI
{
    public class ViewModelHandler : ViewModelBase, IViewModelHandler
    {
        private List<IViewModelBase> _viewModelList;
        private IViewModelBase _selectedViewModel;

        public ViewModelHandler()
        {
            ViewModelList = new List<IViewModelBase>();
            //Handle KeyDown for ViewModels
            KeyDownCommand = new RelayCommand(x => SelectedViewModel.KeyDownCommand?.Execute(x));

            var startViewModel = new StartViewModel(new ViewModelMetadata(ChangeViewModel));
            ViewModelList.Add(startViewModel);
            SelectedViewModel = startViewModel;
        }

        //List with ViewModels
        public List<IViewModelBase> ViewModelList
        {
            get { return _viewModelList; }
            set { _viewModelList = value; OnPropertyChanged(); }
        }

        //Reference of SelectedViewModel from ViewModelsList
        public IViewModelBase SelectedViewModel
        {
            get { return _selectedViewModel; }
            set { _selectedViewModel = value; OnPropertyChanged(); }
        }

        //Create new ViewModel or select ViewModel from ViewModelList to SelectedViewModel  
        private void ChangeViewModel(Type viewModelType)
        {
            foreach (var viewModel in ViewModelList)
            {
                if (viewModelType != viewModel.GetType()) continue;
                SelectedViewModel = viewModel;              
                return;
            }
            var newViewModel = (ViewModelBase) Activator.CreateInstance(viewModelType, new ViewModelMetadata(ChangeViewModel));
            ViewModelList.Add(newViewModel);
            SelectedViewModel = newViewModel;
        }
    }
}