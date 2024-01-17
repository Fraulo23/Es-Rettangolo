using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Rettangolo
{
    internal class Rettangolo
    {
        public float L1 { get; set; }
        public float L2 { get; set; }
        public Rettangolo(float l1, float l2)
        {
            L1 = l1;
            L2 = l2;
        }
        public float Area()
        {
            return (L1 * L2);
        }
        public float Perimetro() {
            return (L1 + L2) * 2;
        }

    }
}
