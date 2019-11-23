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
    public partial class User_Dashboard : Form
    {
        public User_Dashboard()
        {
            InitializeComponent();
        }

        private void User_Dashboard_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.AddXY("Level 1", "100000");
            chart1.Series["Series1"].Points.AddXY("Level 2", "90201");
            chart1.Series["Series1"].Points.AddXY("Level 3", "102010");
            chart1.Series["Series1"].Points.AddXY("Level 4", "222100");
            chart1.Series["Series1"].Points.AddXY("Level 5", "222000");
            chart1.Series["Series1"].Points.AddXY("Level 6", "40000");
            chart1.Series["Series1"].Points.AddXY("Level 7", "30000");
            chart1.Series["Series1"].Points.AddXY("Level 8", "19000");

            chart2.Series["Series1"].Points.AddXY("EMPLOYED", "1900");
            chart2.Series["Series1"].Points.AddXY("UNEMPLOYED", "19000");
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, panel1.Width, panel1.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(0, 70, 151), System.Drawing.Color.FromArgb(48, 145, 255), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, panel1.Width, panel1.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(0, 174, 104), System.Drawing.Color.FromArgb(0, 255, 154), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, panel1.Width, panel1.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(186, 43, 0), System.Drawing.Color.FromArgb(255, 60, 0), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }
        private void panel5_Paint_2(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, panel5.Width, panel5.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(255, 255, 255), System.Drawing.Color.FromArgb(149, 149, 149), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, panel4.Width, panel4.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(255, 255, 255), System.Drawing.Color.FromArgb(149, 149, 149), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, panel6.Width, panel6.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(215, 172, 0), System.Drawing.Color.FromArgb(255, 205, 0), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, panel7.Width, panel7.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(255, 255, 255), System.Drawing.Color.FromArgb(149, 149, 149), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, panel8.Width, panel8.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(255, 255, 255), System.Drawing.Color.FromArgb(149, 149, 149), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

    }
}
