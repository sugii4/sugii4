using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Simulator_Hinze
{
    internal class Fahrer
    {
        private Bitmap fSprite;
        private string name;
        private int x;
        private int y;

        public Fahrer(string name, int startX, int startY, Bitmap fSprite)
        {
            this.fSprite = fSprite;
            this.name = name;
            this.x = startX;
            this.y = startY;
        }

        public void steuernAuto(int addX)
        {
            setX(getX() + addX);
        }

        public Bitmap getFSprite()
        {
            return fSprite;
        }

        public void setFSprite(Bitmap driverBitmap)
        {
            this.fSprite = new Bitmap(driverBitmap, 16, 20);
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

    }
}
