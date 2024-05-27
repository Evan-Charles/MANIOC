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
            SuspendLayout();
            // 
            // moveCelestial
            // 
            moveCelestial.Tick += moveCelestial_Tick;
            // 
            // plan
            // 
            plan.Location = new Point(112, 79);
            plan.Name = "plan";
            plan.Size = new Size(755, 396);
            plan.TabIndex = 0;
            plan.Paint += plan_Paint;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 20);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(994, 593);
            Controls.Add(plan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer moveCelestial;
        private Panel plan;
    }
}