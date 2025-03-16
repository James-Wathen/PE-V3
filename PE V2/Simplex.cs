using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_V2
{
    internal class Simplex//used in GJK as an abstract array, 
    {
        public float[,] vertexes = new float[3,2];
        protected int top;
        public Simplex() 
        {
            top = -1;// so that when we add a value top = 0
        }
        public virtual void push(float[] Point)// sets top of stack to Point
        {
            if (top == 2)//there are already 3 point in simplex
            {
                deque(2);
            }
            top++;
            vertexes[top, 0] = Point[0];
            vertexes[top, 1] = Point[1];
        }
        public void pop()// removes top value by reducing top
        {
            top--;
        }
        public void deque(int k)//k represents the position that is removed
        {

            for (int i = 0; i < 3; i++)// move each point back a point
            {
                if (i > k && i != 0)//so it moves every item in list after k, down 1, while everything before k stays in place
                {
                    vertexes[i - 1, 0] = vertexes[i, 0];
                    vertexes[i - 1, 1] = vertexes[i, 1];//moves coordinate in position i to the position below them
                }
            }
            top--;//array has reduced so top is also decremented
        }
        public int Top()
        {
            return top;
        }
    }
}
