using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_3
{
    // Uzd 1
    public class Phone
    {
        public double Size { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public void Call()
        {
            Console.WriteLine("Calling");   
        }
        public void SMS()
        {
            Console.WriteLine("SMS sent");
        }
    }
}
