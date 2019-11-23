using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHqctx
{
    public partial class User_RegisteredFirms : Form
    {
        public User_RegisteredFirms()
        {
            InitializeComponent();
        }

        private void User_RegisteredFirms_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, panel1.Width, panel1.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(0, 70, 151), System.Drawing.Color.FromArgb(255, 0, 0), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
