using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manioc.Models
{
    internal class Planet : Celestial
    {
        public double DistanceFromSun { get; set; }
        public Sun? Sun { get; set; }
        public double Angle { get; set; }
        public Brush Brush { get; set; }

        public Planet(string name, double diameter, double distanceFromSun, Sun? sun, double angle)
        {
            Name = name;
            Diameter = diameter;
            DistanceFromSun = distanceFromSun;
            Sun = sun;
            Angle = angle;

            //Random RGB color
            Random random = new();
            Brush = new SolidBrush(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));

            if(Sun != null)
            {
                Sun.AddPlanet(this);
            }
        }

        public void UpdatePosition()
        {
            if(Sun != null)
            {
                X = Sun.X + DistanceFromSun * Math.Cos(Angle);
                Y = Sun.Y + DistanceFromSun * Math.Sin(Angle);
                Angle += 0.01;
            }
        }
    }
}
