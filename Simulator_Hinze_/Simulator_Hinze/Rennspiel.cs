using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Simulator_Hinze;

namespace Simulator_Hinze
{
    public partial class Rennspiel : Form
    {

        private Controller controller;
        public Rennspiel()
        {
            InitializeComponent();
        }

        private void tickTrack(object sender, EventArgs e)
        {
            controller.render();
        }

        private void load(object sender, EventArgs e)
        {
            controller = new Controller(this);
            controller.createStrecken();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

            timer.Interval = 33;
            timer.Tick += new EventHandler(tickTrack);
            timer.Start();
        }

        public PictureBox getFlaeche()
        {
            return flaeche;
        }
    }
}