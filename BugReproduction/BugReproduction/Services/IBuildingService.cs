using System.Collections.Generic;
using BugReproduction.Models;

namespace BugReproduction.Services
{
    public interface IBuildingService
    {
        IEnumerable<Building> Buildings { get; }
    }
}