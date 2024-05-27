using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manioc.Models
{
    internal class Sun : Celestial
    {
        public List<Planet>? Planets { get; set; }

        public Sun(string name, double diameter)
        {
            Name = name;
            Diameter = diameter;
            Planets = new List<Planet>();
        }

        public void AddPlanet(Planet planet)
        {
            Planets?.Add(planet);
            planet.Sun = this;
        }

        public void RemovePlanet(Planet planet)
        {
            Planets?.Remove(planet);
            planet.Sun = null;
        }
    }
}
