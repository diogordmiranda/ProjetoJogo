using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(string Name, string Description, int XCoordinate, int YCoordinate)
        {
            Location location = new Location();
            location.Name = Name;
            location.Description = Description;
            location.XCoordinate = XCoordinate;
            location.YCoordinate = YCoordinate;
            _locations.Add(location);
        }

        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location loc in _locations)
            {
                if (loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }
            return null;
        }

    }
}
