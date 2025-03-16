using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PE_V2
{
    internal class Polytope : Simplex//this is an abstract array that is larger than simplex and allows vectors to be added to a specific point in its array
    {
        public Polytope() : base()
        {
            vertexes = new float[10, 2];//polytope needs to be much larger than simplex while still being an array, but it shouldnt become larger than 10 points
            top = -1;
        }
        public override void push(float[] Point)
        {
            if (top == 10)// so that it does not overflow
            {
                deque(2);
            }
            top++;
            vertexes[top, 0] = Point[0];
            vertexes[top, 1] = Point[1];
        }
        public void indexPush(float[] Point, int k)// puts a coordinate at a specific point in vertexes
        {
            for (int i = 0; i < vertexes.GetLength(0)-1; i++)
            {
                if (i > k)
                {
                    vertexes[i + 1, 0] = vertexes[i, 0];
                    vertexes[i + 1, 1] = vertexes[i, 1];//moves ceach corrdinate up 1 after k
                }
                vertexes[k, 0] = Point[0];
                vertexes[k, 1] = Point[1];//set the value at k
            }
        }
    }
}
