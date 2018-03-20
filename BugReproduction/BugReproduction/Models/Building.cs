using Prism.Mvvm;

namespace BugReproduction.Models
{
    public class Building : BindableBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _imageSrc;
        public string ImageSrc
        {
            get { return _imageSrc; }
            set { SetProperty(ref _imageSrc, value); }
        }
    }
}
