using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_V2
{
    internal class Entity// this is where the basic calculations for both circle and polygon objects are kept and ran
    {
        public float[] velocity;
        public float[] acceleration;
        public float[] position; // position of top left corner (this is changed in polygon to make it easier to calculate collisions and other things)
        public float mass;
        public Pen Colour;
        public float frameRate = 1f/60f;//this is not the framerate of the simulation, just the one used in calculations which should not change (unless pausing)
        public Entity(float vx, float vy, float ax, float ay, float px, float py, Pen Colour, float mass)
        {
            velocity = new float[] { vx, vy };
            acceleration = new float[] { ax, ay };
            position = new float[] { px, py };
            this.Colour = Colour;
            this.mass = mass;// assign values
        }
        public virtual void updateVelocity()
        {
            velocity[0] = velocity[0] + acceleration[0] * frameRate;//Vx, the time taken is 1 frame (1/fps)
            velocity[1] = velocity[1] + acceleration[1] * frameRate;//Vy
        }
        public virtual void updatePosition()
        {
            position[0] = (position[0] + velocity[0] * frameRate);// position is incremented by the velocity in that direction
            position[1] = (position[1] + velocity[1] * frameRate); // position must always be positive
        }
        public virtual void updateAcceleration(List<Force> forces)// used for finding resultant acceleration from force objects
        {
            float G = 6.67f * (float)Math.Pow(10f, -6f); // gravitational constant, to a lower power for ease of use in the simulation
            float[] finalForce = { 0, 0 };
            float softeningLength = 100;// this stretches the range of the field, found this concept from: https://astronomy.stackexchange.com/questions/50106/what-is-gravitational-softening-length
            for (int i = 0; i < forces.Count; i++)//sums components of different forces to find resultant force on this entity
            {
                // Calculate the distance vector between the particle and the force object
                float[] Distance = { forces[i].Position[0] - position[0], forces[i].Position[1] - position[1] };
                float distanceMagnitude = (float)Math.Sqrt(Distance[0] * Distance[0] + Distance[1] * Distance[1]);

                if (distanceMagnitude < 1)
                    distanceMagnitude = 1;//prevents division by 0
                float softenedDistance = (float)Math.Sqrt(distanceMagnitude * distanceMagnitude + softeningLength * softeningLength);//stretches the range

                float forceMagnitude = (G * forces[i].Mass * mass) / ((float)Math.Pow(softenedDistance, 3));
                float[] forceDirection = { Distance[0] / distanceMagnitude, Distance[1] / distanceMagnitude };//puts gravitational force into vector, https://www.khanacademy.org/computing/computer-programming/programming-natural-simulations/programming-forces/a/gravitational-attraction
                finalForce[0] += forceMagnitude * forceDirection[0];
                finalForce[1] += forceMagnitude * forceDirection[1];
            }
            float[] NewAcceleration = { finalForce[0] / mass, finalForce[1] / mass };// f = ma
            acceleration[0] = NewAcceleration[0];
            acceleration[1] = NewAcceleration[1];//assigns new accelerations
        }
    }
}

