using BugReproduction.Models;
using System.Collections.Generic;

namespace BugReproduction.Services
{
    public class BuildingService : IBuildingService
    {
        public IEnumerable<Building> Buildings
        {
            get
            {
                return new List<Building> {
                    new Building { Name = "Building one", ImageSrc = "Building_one.jpg" },
                    new Building { Name = "Building two", ImageSrc = "Building_two.jpg" }
                };
            }
        }
    }
}
