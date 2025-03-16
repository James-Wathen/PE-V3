using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_V2
{
    internal class Border : Polygon// this is to be used as an easy way to make immovable polygons
    {
        public Border(float Px, float Py, float[,] vertexVectors) : base(0, 0, 0, 0, Px, Py, new Pen(Color.Blue, 4), vertexVectors, 0, 0, 0, float.PositiveInfinity)
        {
            this.position[0] = Px;
            this.position[1] = Py;
            setPosition();//find its centre of mass
        }
    }
}
