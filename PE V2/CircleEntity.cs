using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_V2
{
    internal class CircleEntity : Entity//where data for the circle objects is kept
    {
        public float Diameter;
        private float totalVelocity;
        public bool Ball = false;
        public CircleEntity(float vx, float vy, float ax, float ay, float px, float py, float Diameter, Pen Colour, bool ball, float mass) : base( vx, vy, ax, ay, px, py, Colour, mass)
        {
            velocity = new float[] { vx, vy };
            acceleration = new float[] { ax, ay };
            position = new float[] { px, py };
            this.Diameter = Diameter;
            this.Colour = Colour;
            this.mass = mass;
        }
        public double findVelocity()
        {
            velocity[0] = velocity[0] + acceleration[0] * frameRate;//Vx, the time taken is 1 frame (1/fps)
            velocity[1] = velocity[1] + acceleration[1] * frameRate;//Vy
            return totalVelocity = (float)Math.Sqrt(Math.Pow(velocity[0], 2) + Math.Pow(velocity[1], 2));
        }
        public void RecursiveMergeSort(ref float[] Array)
        {
            int Len = Array.Length;
            int Mid = Len / 2;
            float[] rArray = new float[Mid];
            float[] lArray = new float[Len - Mid];
            Array.CopyTo(lArray, 0);
            Array.CopyTo(rArray, Mid);
            RecursiveMergeSort(ref lArray);//recurse
            RecursiveMergeSort(ref rArray);// ref is used to makesure the final values are changed

        }
        public int ValueIndex(ref float[] Array, float Value)// recursive bianry search
        {
            int Len = Array.Length;
            int Mid = Len / 2;//split array
            if (Array[Mid] == Value)
                return Mid;//end condition for finding value
            else if (Array[Mid] < Value)
            {
                float[] nextArray = new float[Mid];
                Array.CopyTo(nextArray, 0);
                return ValueIndex(ref nextArray, Value);//recurse
            }
            else if (Array[Mid] > Value)
            {
                float[] nextArray = new float[Len - Mid];
                Array.CopyTo(nextArray, Mid);
                return ValueIndex(ref nextArray, Value);//recurse
            }
            else
            {
                return 0;//not in list
            }
        }
        public float findDistance(char W)
        {
            if (W == 'L')
            {
                return position[0] + (Diameter / 2) - 10; // distance from left
            }
            else if (W == 'R')
            {
                return 1025 - position[0] - (Diameter / 2); // distance from right
            }
            else if (W == 'T')
            {
                return position[1] + (Diameter / 2) - 10; // distance from top
            }
            else if (W == 'B')
            {
                return 700 - position[1] - (Diameter / 2);// distance from bottom
            }
            else
            {
                return 0;
            }
        }
    }
}