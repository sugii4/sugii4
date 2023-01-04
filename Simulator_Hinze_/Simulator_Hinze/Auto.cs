using System;
using System.Drawing;
using System.Windows.Forms;


namespace Simulator_Hinze
{
    internal class Auto
    {
        private int startX;
        private int startY;

        private Fahrer fahrer;

        private Bitmap car;

        private Motor motor;

        public Auto(int startX, int startY, Bitmap car)
        {
            this.startX = startX;
            this.startY = startY;

            this.car = car;

            this.motor = new Motor();
        }

        public void setX(int x)
        {
            this.startX = x;
        }

        public void setY(int y)
        {
            this.startY = y;
        }

        public int getX()
        {
            return this.startX;
        }

        public int getY()
        {
            return this.startY;
        }

        public void setFahrer(Fahrer fahrer)
        {
            this.fahrer = fahrer;
        }

        public Fahrer getFahrer()
        {
            return this.fahrer;
        }

        public void fahren()
        {
            setX(getX() + motor.getMotor());
            this.getFahrer().steuernAuto(motor.getMotor());
        }

        public void setFahrerposition()
        {
            getFahrer().setX(getFahrer().getX() + 22);
            getFahrer().setY(getFahrer().getY() + 20);
        }

        public Bitmap getASprite()
        {
            return this.car;
        }

    }
}
