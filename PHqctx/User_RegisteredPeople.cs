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
    public partial class User_RegisteredPeople : Form
    {
        public User_RegisteredPeople()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, panel1.Width, panel1.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, System.Drawing.Color.FromArgb(0, 70, 151), System.Drawing.Color.FromArgb(255, 0,0), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            User_RegisteredPeopleModuleViewRegistered UR = new User_RegisteredPeopleModuleViewRegistered();
            UR.MdiParent = this.MdiParent;
            UR.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            User_RegisteredPeopleModuleViewArchived URA = new User_RegisteredPeopleModuleViewArchived();
            URA.MdiParent = this.MdiParent;
            URA.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            User_RegisteredPeopleModuleRegister URMR = new User_RegisteredPeopleModuleRegister();
            URMR.MdiParent = this.MdiParent;
            URMR.Show();
            this.Hide();
        }
    }
}
