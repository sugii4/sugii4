using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulator_Hinze
{
    internal class Controller
    {
        private Rennspiel spiel;

        Strecke[] fahrbahn;

        public Controller(Rennspiel spiel)
        {
            this.spiel = spiel;
        }

        public void createStrecken()
        {
            fahrbahn = new Strecke[3];

            Auto car1 = new Auto(0, 25, Properties.Resources.car1);
            Fahrer fahrer1 = new Fahrer("Fahrer1", 22, 47, Properties.Resources.fahrer1);
            car1.setFahrer(fahrer1);
            fahrbahn[0] = new Strecke(car1, 0, 0);

            Auto car2 = new Auto(0, 225, Properties.Resources.car2);
            Fahrer fahrer2 = new Fahrer("Fahrer2", 22, 247, Properties.Resources.fahrer2);
            car2.setFahrer(fahrer2);
            fahrbahn[1] = new Strecke(car2, 0, 200);

            Auto car3 = new Auto(0, 425, Properties.Resources.car3);
            Fahrer fahrer3 = new Fahrer("Fahrer3", 22, 447, Properties.Resources.fahrer3);
            car3.setFahrer(fahrer3);
            fahrbahn[2] = new Strecke(car3, 0, 400);
        }

        public void drawObject(int x, int y, Bitmap draw, Bitmap drawOn)
        {
            using (Graphics bild = Graphics.FromImage(drawOn))
            {
                bild.DrawImage(draw, new Point(x, y));
            }
        }

        public void render()
        {
            Bitmap hintergrund = new Bitmap(1200, 600);

            for(int streckeId = 0; streckeId < fahrbahn.Length; streckeId++)
            {
                Strecke strecke = fahrbahn[streckeId];

                drawObject(strecke.getX(), strecke.getY(), strecke.getStrecke(), hintergrund);
                drawObject(strecke.getAuto().getX(), strecke.getAuto().getY(), new Bitmap(strecke.getAuto().getASprite(), 64, 64), hintergrund);
                drawObject(strecke.getAuto().getFahrer().getX(), strecke.getAuto().getFahrer().getY(), new Bitmap(strecke.getAuto().getFahrer().getFSprite(), 20, 20), hintergrund);

                if(!strecke.getZiellinie())
                {
                    strecke.getAuto().fahren();
                    if (strecke.getAuto().getX() >= 1120) strecke.setZielline(true);
                }

                spiel.getFlaeche().Image = hintergrund;
            }
        }
    }
}
