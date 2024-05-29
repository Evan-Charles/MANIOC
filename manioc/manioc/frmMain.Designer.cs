namespace manioc
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            moveCelestial = new System.Windows.Forms.Timer(components);
            plan = new Panel();
            controls = new Panel();
            planets = new Panel();
            planetsCount = new Label();
            addPlanet = new Button();
            controls.SuspendLayout();
            planets.SuspendLayout();
            SuspendLayout();
            // 
            // moveCelestial
            // 
            moveCelestial.Interval = 30;
            moveCelestial.Tick += moveCelestial_Tick;
            // 
            // plan
            // 
            plan.Dock = DockStyle.Top;
            plan.Location = new Point(0, 0);
            plan.Name = "plan";
            plan.Size = new Size(994, 414);
            plan.TabIndex = 0;
            plan.Paint += plan_Paint;
            // 
            // controls
            // 
            controls.Controls.Add(planets);
            controls.Dock = DockStyle.Bottom;
            controls.Location = new Point(0, 420);
            controls.Name = "controls";
            controls.Size = new Size(994, 173);
            controls.TabIndex = 2;
            // 
            // planets
            // 
            planets.Controls.Add(planetsCount);
            planets.Controls.Add(addPlanet);
            planets.Dock = DockStyle.Right;
            planets.Location = new Point(271, 0);
            planets.Name = "planets";
            planets.Size = new Size(723, 173);
            planets.TabIndex = 2;
            // 
            // planetsCount
            // 
            planetsCount.Dock = DockStyle.Top;
            planetsCount.Font = new Font("Roboto Condensed", 48F, FontStyle.Bold, GraphicsUnit.Point);
            planetsCount.ForeColor = Color.Blue;
            planetsCount.Location = new Point(0, 0);
            planetsCount.Name = "planetsCount";
            planetsCount.Size = new Size(723, 140);
            planetsCount.TabIndex = 3;
            planetsCount.Text = "1";
            planetsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addPlanet
            // 
            addPlanet.BackColor = Color.FromArgb(0, 0, 20);
            addPlanet.Dock = DockStyle.Bottom;
            addPlanet.FlatStyle = FlatStyle.Flat;
            addPlanet.ForeColor = Color.Blue;
            addPlanet.Location = new Point(0, 143);
            addPlanet.Name = "addPlanet";
            addPlanet.Size = new Size(723, 30);
            addPlanet.TabIndex = 1;
            addPlanet.Text = "Add";
            addPlanet.UseVisualStyleBackColor = false;
            addPlanet.Click += addPlanet_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 20);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(994, 593);
            Controls.Add(controls);
            Controls.Add(plan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            controls.ResumeLayout(false);
            planets.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer moveCelestial;
        private Panel plan;
        private Panel controls;
        private Panel planets;
        private Button addPlanet;
        private Label planetsCount;
    }
}