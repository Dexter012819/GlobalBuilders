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
    public partial class User_MainInterface : Form
    {
        public User_MainInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            User_Dashboard UD = new User_Dashboard();
            UD.MdiParent = this;
            UD.Show();
        }

        private void User_MainInterface_Load(object sender, EventArgs e)
        {
            User_Dashboard UD = new User_Dashboard();
            UD.MdiParent = this;
            UD.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            User_RegisteredPeople UP = new User_RegisteredPeople();
            UP.MdiParent = this;
            UP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            User_RegisteredFirms UF = new User_RegisteredFirms();
            UF.MdiParent = this;
            UF.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("logging out");
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
