using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_V2
{
    internal class Point//point is just used to store data that is then used to draw the point in the polyform
    {
        public float[] position;
        public float width;
        public Point(float[] coordinates, float width)
        {
            position = coordinates;
            this.width = width;
        }
    }
}
