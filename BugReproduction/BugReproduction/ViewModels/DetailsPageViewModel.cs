using Prism.Navigation;

namespace BugReproduction.ViewModels
{
    public class DetailsPageViewModel : ViewModelBase
    {
        public const string BuildingNameParamKey = "buildingName";

        public DetailsPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Details Page";
        }

        private string _buildingName;
        public string BuildingName
        {
            get { return _buildingName; }
            set { SetProperty(ref _buildingName, value); }
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            BuildingName = parameters[BuildingNameParamKey] as string;

            base.OnNavigatedTo(parameters);
        }
    }
}
