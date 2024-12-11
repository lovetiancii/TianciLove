using System;
using System.Drawing;
using System.Windows.Forms;

namespace TianciLove
{
    public partial class Heart : Form
    {
        Random rd = new Random();
        public Heart()
        {
            InitializeComponent();
        }

        private void Heart_Load(object sender, EventArgs e)
        {
            int x = rd.Next(1, Screen.PrimaryScreen.WorkingArea.Width);
            int y = rd.Next(1, Screen.PrimaryScreen.WorkingArea.Height);
            this.Location = new Point(x, y);
        }
    }
}