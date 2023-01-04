using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Simulator_Hinze
{
    internal class Strecke
    {
        private Bitmap strecke;
        private Auto auto;

        int x;
        int y;

        private bool ziellinie;

        public bool getZiellinie()
        {
            return ziellinie;
        }

        public void setZielline(bool zielline)
        {
            this.ziellinie = zielline;
        }

        public Bitmap getStrecke()
        {
            return this.strecke;
        }

        public Auto getAuto()
        {
            return auto;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public void setX(int newX)
        {
            this.x = newX;
        }

        public void setY(int newY)
        {
            this.y = newY;
        }
        public Strecke(Auto car, int startX, int startY)
        {
            this.x = startX;
            this.y = startY;

            this.ziellinie = false;
            this.strecke = new Bitmap(Properties.Resources.strecke1, 1200, 200);
            this.auto = car;
        }
    }
}
