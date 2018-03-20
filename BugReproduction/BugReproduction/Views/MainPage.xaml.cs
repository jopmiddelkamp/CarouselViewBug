using BugReproduction.ViewModels;
using Xamarin.Forms;

namespace BugReproduction.Views
{
    public partial class MainPage : ContentPage
	{
        private MainPageViewModel ViewModel => BindingContext as MainPageViewModel;

		public MainPage ()
		{
			InitializeComponent();
		}

        protected override void OnSizeAllocated(double width, double height)
        {
            ViewModel.ImageSize = width - WrapperStackLayout.Padding.Left - WrapperStackLayout.Padding.Right;

            base.OnSizeAllocated(width, height);
        }
    }
}