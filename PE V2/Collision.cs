using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_V2
{
    internal class Collision//collision is just storage for the data about a collision
    {
        public Polygon A;
        public Polygon B;
        public Simplex simplex = new Simplex();
        public Collision(Polygon A, Polygon B, Simplex simplex)
        {
            this.A = A;
            this.B = B;
            this.simplex = simplex;
        }
    }
}
