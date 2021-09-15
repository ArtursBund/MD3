using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_3
{
    // Uzd 2
    public class Car
    {
        public string Brand { get; set; }
        public string NumberPlate { get; set; }
        public double Speed { get; private set; }
        public void StartDriving(double v)
        {
            Speed = v;
        }
        public void IncreaseSpeed(double vPluss)
        {
            Speed = Speed + vPluss;
        }
        public void DecreaseSpeed(double vMinuss)
        {
            Speed = Speed - vMinuss;
        }
        public void StopDriving()
        {
            Speed = 0;
        }
        public void Signal()
        {
           Console.WriteLine("Beep beep");
        }
    }
}
