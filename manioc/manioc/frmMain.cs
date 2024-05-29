using manioc.Models;
using System.Drawing.Text;

namespace manioc
{
    public partial class frmMain : Form
    {
        private Sun sun = new("Sun", 50);
        private List<Planet> _planets = new();
        public frmMain()
        {
            InitializeComponent();

            //Position the sun at the center of the panel
            sun.X = plan.Width / 2;
            sun.Y = plan.Height / 2;

            //Timer to move planet
            moveCelestial.Start();
        }

        private void moveCelestial_Tick(object sender, EventArgs e)
        {
            //Update the position of the planet
            foreach (var planet in _planets)
            {
                planet.UpdatePosition();
            }

            plan.Invalidate();
        }

        private void plan_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            //Draw the sun
            if (sun != null)
            {
                g.FillEllipse(Brushes.Yellow, (float)sun.X - (float)sun.Diameter / 2, (float)sun.Y - (float)sun.Diameter / 2, (float)sun.Diameter, (float)sun.Diameter);
            }

            //Draw the planet
            foreach (var planet in _planets)
            {
                g.FillEllipse(planet.Brush, (float)planet.X - (float)planet.Diameter / 2, (float)planet.Y - (float)planet.Diameter / 2, (float)planet.Diameter, (float)planet.Diameter);
            }
        }

        private void addPlanet_Click(object sender, EventArgs e)
        {
            //Random diamaeter and distance from sun
            Random random = new();
            _planets.Add(new Planet("Planet", random.Next(10, 30), random.Next(50, 200), sun, 0));
        }
    }
}