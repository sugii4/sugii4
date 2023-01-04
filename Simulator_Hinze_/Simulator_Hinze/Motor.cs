using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_Hinze
{
    internal class Motor
    {
        private int motor;
        public static Random random = new Random();

        public Motor()
        {
            this.motor = random.Next(10) + 1;
        }


        public int getMotor()
        {
            return motor;
        }
    }
}
