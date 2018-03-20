using BugReproduction.Extensions;
using BugReproduction.Models;
using BugReproduction.Services;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace BugReproduction.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public IBuildingService BuildingService { get; }

        public MainPageViewModel(INavigationService navigationService, IBuildingService buildingService) 
            : base (navigationService)
        {
            BuildingService = buildingService;

            Title = "Main Page";

            BuildingCarouselImages = new ObservableCollection<CarouselImage>(Buildings.Select(b => b.ToCarouselImage()));
        }

        private double _imageSize;
        public double ImageSize
        {
            get { return _imageSize; }
            set { SetProperty(ref _imageSize, value); }
        }

        private IEnumerable<Building> _buildings;
        public IEnumerable<Building> Buildings => _buildings ?? (_buildings = BuildingService.Buildings);

        private ObservableCollection<CarouselImage> _buildingCarouselImages;
        public ObservableCollection<CarouselImage> BuildingCarouselImages
        {
            get { return _buildingCarouselImages; }
            set { SetProperty(ref _buildingCarouselImages, value); }
        }
        
        private int _selectedBuildingIndex;
        public int SelectedBuildingIndex
        {
            get { return _selectedBuildingIndex; }
            set { SetProperty(ref _selectedBuildingIndex, value); }
        }

        private Building SelectedBuilding => Buildings.ElementAt(SelectedBuildingIndex);
        
        private DelegateCommand _selectBuildingCommand;
        public DelegateCommand SelectBuildingCommand => _selectBuildingCommand ?? (_selectBuildingCommand = new DelegateCommand(OnSelectBuildingCommandExecuted));
        
        private async void OnSelectBuildingCommandExecuted()
        {
            try
            {
                await NavigationService.NavigateAsync($"../DetailsPage?{DetailsPageViewModel.BuildingNameParamKey}={SelectedBuilding.Name}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
