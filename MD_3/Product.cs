using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_3
{
    // Uzd 3
    public class Product
    {
        public Product(double h, double w, double m)
        {
            Height = h;
            Width = w;
            Weight = m;
        }
        public double Height { get; }
        public double Width { get; }
        public double Weight { get; }
    }
}
