using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// A quick look at the ControlPaint class
// This class has some methods to draw standard GUI elements

namespace ControlPaintClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder3D(e.Graphics, panel1.ClientRectangle);
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.Green, ButtonBorderStyle.Outset);
            ControlPaint.DrawGrid(e.Graphics, panel1.ClientRectangle, new Size(20, 20), Color.Red);

            Rectangle rect = this.ClientRectangle;
            rect.Inflate(-50, -50);
            ControlPaint.DrawFocusRectangle(e.Graphics, rect);
            ControlPaint.DrawCheckBox(e.Graphics, panel1.ClientRectangle, ButtonState.Checked);


        }
    }
}
