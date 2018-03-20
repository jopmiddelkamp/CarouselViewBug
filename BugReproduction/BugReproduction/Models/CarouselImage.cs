using Prism.Mvvm;

namespace BugReproduction.Models
{
    public class CarouselImage : BindableBase
    {
        public string ImageSrc { get; set; }

        public string Description { get; set; }
    }
}
