using BugReproduction.Models;

namespace BugReproduction.Extensions
{
    public static class BuildingExtensions
    {
        public static CarouselImage ToCarouselImage(this Building source)
        {
            return new CarouselImage { ImageSrc = source.ImageSrc, Description = source.Name };
        }
    }
}
