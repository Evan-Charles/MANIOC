using manioc.Models;
using System.Drawing.Text;

namespace manioc
{
    public partial class frmMain : Form
    {
        private Planet planet;
        public frmMain()
        {
            InitializeComponent();

            //Initialize the sun and the planet
            Sun sun = new ("Sun", 50);
            planet = new ("Earth", 20, 200, sun);

            //Position the sun at the center of the panel
            sun.X = plan.Width / 2;
            sun.Y = plan.Height / 2;

            //Timer to move planet
            moveCelestial.Start();

        }

        private void moveCelestial_Tick(object sender, EventArgs e)
        {
            planet.UpdatePosition();
            plan.Invalidate();
        }

        private void plan_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            //Draw the sun
            var sun = planet.Sun;
            if(sun != null)
            {
                g.FillEllipse(Brushes.Yellow, (float)sun.X - (float)sun.Diameter / 2, (float)sun.Y - (float)sun.Diameter / 2, (float)sun.Diameter, (float)sun.Diameter);
            }

            //Draw the planet
            g.FillEllipse(Brushes.Blue, (float)planet.X - (float)planet.Diameter / 2, (float)planet.Y - (float)planet.Diameter / 2, (float)planet.Diameter, (float)planet.Diameter);

        }
    }
}