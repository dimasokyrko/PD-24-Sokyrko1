using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна__8._1
{
    class ClassCars
    {
        protected string nameofcar;
        protected string colorofcar;
        protected int carspeed;
        protected int graduationyear;

        public string Namecar
        {
            get
            {
                return nameofcar;
            }
        }

        public string Colorcar
        {
            get
            {
                return colorofcar;
            }
        }

        public int Carspeed
        {
            get
            {
                return carspeed;
            }
        }

        public int Graduationyear
        {
            get
            {
                return graduationyear;
            }
        }

        public ClassCars(string nameofcar, string colorofcar, int carspeed, int graduationyear)
        {
            this.nameofcar = nameofcar;
            this.colorofcar = colorofcar;
            this.carspeed = carspeed;
            this.graduationyear = graduationyear;
        }
    }
}
