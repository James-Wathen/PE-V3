using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PE_V2
{
    internal class PolyManager//this is where the polygon simulation is ran
    {
        private static System.Windows.Forms.Timer Timer;
        public List<Polygon> Objects = new List<Polygon>();
        public List<Force> forces = new List<Force>();
        public Pen black = new Pen(Color.Black, 4);
        public Pen blue = new Pen(Color.Blue, 4);
        public Pen Red = new Pen(Color.Red, 4);
        public Pen green = new Pen(Color.Green, 4);
        public Pen yellow = new Pen(Color.Yellow, 4);
        public Pen purple = new Pen(Color.Purple, 4);
        public Pen turquoise = new Pen(Color.Turquoise, 4);
        public Pen magenta = new Pen(Color.Magenta, 4);
        public Pen pink = new Pen(Color.Pink, 4);
        public Pen orange = new Pen(Color.Orange, 4);
        public Pen brown = new Pen(Color.Brown, 4);
        public Pen[] Pens;
        public PolyForm form;
        public float frameRate = 1f/60f;// frame rate for velocities, position and acceleration changes
        public char side;
        public PolyManager(PolyForm form)// manager is only called once
        {
            this.form = form;// links polyform to this instance of poly manager
            Pens = new Pen[] { black, blue, Red, green, yellow, purple, turquoise, magenta, pink, orange, brown };//makes the pens list

            //data for border object that are made to be on the edge of the simulation
            PointF Point1 = new PointF(10F, 10F);
            PointF Point2 = new PointF(10F, 700F);
            PointF Point3 = new PointF(1025F, 700F);
            PointF Point4 = new PointF(1025F, 10F);
            float[,] Border1 = new float[,] { { 200, 6 }, { 200, -6 }, { -544, -6 }, { -544, 6 } };
            float[,] Border2 = new float[,] { { 100, 10 }, { 100, -10 }, { -100, -10 }, { -100, 10 } };
            float[,] Border3 = new float[,] { { 100, 10 }, { 100, -10 }, { -100, -10 }, { -100, 10 } };
            float[,] Border4 = new float[,] { { 100, 10 }, { 100, -10 }, { -100, -10 }, { -100, 10 } };
            Border BorderA = new Border(556, 6, Border1);
            Border BorderB = new Border(1106, 6, Border2);
            Border BorderC = new Border(544, 344, Border3);
            Border BorderD = new Border(544, 344, Border4);
            
            //data for preset polygons
            float[] Vertex1 = new float[] { 25, 25 };
            float[] Vertex2 = new float[] { -25, 25};
            float[] Vertex3 = new float[] { -25, -25};
            float[] Vertex4 = new float[] { 25, -25};
            float[,] verticies1 = new float[,] { { 25, 25 }, { -25, 25 }, { -25, -25 }, { 25, -25 } };
            float[,] verticies2 = new float[,] { { 25, 25 }, { -25, 25 }, { -25, -25 } };
            Polygon Shape1 = new Polygon(100, 100, 0, 0, 100, 100, black, verticies1, 0, 0, 0.5f, 10);
            Polygon Shape2 = new Polygon(100, -100, 0, 0, 100, 500, brown, verticies2, 0, 0, 0.5f, 10);//these shapes are preset to the simulation
            // the position is where the center of mass is positioned
            Objects.Add(Shape1);
            Objects.Add(Shape2);//adding the two preset polygons to Objects
            setTimer();
            // second push
        }
        private void setTimer()
        {
            Timer = new System.Windows.Forms.Timer();
            Timer.Interval = 1000 / 1000;// frame rate for running the simulation
            Timer.Tick += Timer_Tick;//begins the tick method
            Timer.Start();//starts the timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (form.CollisionCheck.Checked)
            {
                Collision();//only run collisions when the collision box is checked
            }
            if (form.Paused.Checked)
            {
                foreach (Polygon shape in Objects)
                {
                    shape.frameRate = 0;//set framerate for calculation updates to 0 stops all motion
                }
            }
            else if (!form.Paused.Checked)
            {
                foreach (Polygon shape in Objects)
                {
                    shape.frameRate = frameRate;// makes objects move again
                }
            }
            if (form.Gravity.Checked)// for assigning direction to uniform gravity
            {
                side = form.Side;
                if (side == 'r' || side == 'R')
                {
                    ChangeGravity(form.UniGravMag, 0);
                }
                if (side == 'd' || side == 'D')
                {
                    ChangeGravity(0, form.UniGravMag);
                }
                if (side == 'l' || side == 'L')
                {
                    ChangeGravity(-form.UniGravMag, 0);
                }
                if (side == 'u' || side == 'U')
                {
                    ChangeGravity(0, -form.UniGravMag);
                }
            }
            else if (!form.Gravity.Checked)
            {
                ChangeGravity(0, 0);// reset gravity to 0
            }
            form.Invalidate();
        }
        private void ChangeGravity(float X, float Y)// method to change acceleration for all objects
        {
            for (int i = 0; i < Objects.Count; i++)
            {
                Objects[i].acceleration[0] = X;
                Objects[i].acceleration[1] = Y;
            }
        }
        private void Collision()//checks for collision and runs all neccessary algorithms
        {
            Random rand = new Random();
            List<Collision> collisions = new List<Collision>();//list of collisions
            if (Objects.Count > 0)//only runs if there are objects to calculate
            {
                for (int i = 0; i < Objects.Count; i++)
                {
                    for (int j = 0; j < Objects.Count; j++)
                    {
                        Simplex simplex = new Simplex();// simplex for this particular check
                        if (GJK(Objects[i], Objects[j], simplex))//there has been a collision between the current objects if GJK returns true
                        {
                            Objects[i].Colour = Pens[rand.Next(1, 10)];// randomizes colour to show collisions are occuring
                            collisions.Add(new Collision(Objects[i], Objects[j], simplex));//adds to list of collisions
                        }
                    }
                }
                foreach (Collision collision in collisions)
                {
                    Polytope polytope = new Polytope();//stores more points
                    for (int l = 0; l <= collision.simplex.Top(); l++)//iterates through each point in simplex
                    {
                        polytope.push(GetCoords(collision.simplex.vertexes, l));//pushes all simplex points into polytope
                    }
                    float[] normalToCollision = EPA(collision.A, collision.B, polytope);//collision normal
                    resolveCollision(collision.A, collision.B, Normalize(normalToCollision));// finds new velocities and changes the velocities to those depending on the results of the collisions

                }
            }
        }
        public void resolveCollision(Polygon A, Polygon B, float[] normal)//far too long of an equation from, https://medium.com/@www.seymour/coding-a-2d-physics-engine-from-scratch-and-using-it-to-simulate-a-pendulum-clock-964b4ac2107a
        {
            if (DotProduct(normal, VectorXtoY(B.position, A.position)) < 0)//check that values are good for calculations
                normal = Negative(normal);

            //collision point is needed to find the relative velocity
            float[] AFarPoint = SupportPoint(normal, A);
            float[] BFarPoint = SupportPoint(Negative(normal), B);
            float[] collisionPoint = new float[] { (AFarPoint[0] + BFarPoint[0]) / 2f, (AFarPoint[1] + BFarPoint[1]) / 2f };

            float[] CenterToCollisionA = VectorXtoY(A.position, collisionPoint);
            float[] CenterToCollisionB = VectorXtoY(B.position, collisionPoint);

            float[] AVelAngular = { A.velocity[0] + (-CenterToCollisionA[1] * A.getAngularVelocity()), A.velocity[1] + (CenterToCollisionA[0] * A.getAngularVelocity()) };
            float[] BVelAngular = { B.velocity[0] + (-CenterToCollisionB[1] * B.getAngularVelocity()), B.velocity[1] + (CenterToCollisionB[0] * B.getAngularVelocity()) };
            //finds angular velocities
            float[] relVel = { AVelAngular[0] - BVelAngular[0], AVelAngular[1] - BVelAngular[1] };//needed for further calculations

            float velAlongNormal = DotProduct(relVel, normal);
            if (velAlongNormal > 0) return;// since there will be no impulse in this case (though this should not happen)

            float elasticity = Math.Min(A.getElasticity(), B.getElasticity());//elasticity must be minimum between two objects

            float ACTCMultNormal = CenterToCollisionA[0] * normal[1] - CenterToCollisionA[1] * normal[0];
            float BCTCMultNormal = CenterToCollisionB[0] * normal[1] - CenterToCollisionB[1] * normal[0];//values needed for impulse calculation

            float denominator = (1f / A.getMass()) + (1f / B.getMass()) + (float)(Math.Pow(ACTCMultNormal, 2)) / A.getMomentOfInertia() + (float)Math.Pow(BCTCMultNormal, 2) / B.getMomentOfInertia();

            float impulse = -(1 + elasticity) * velAlongNormal / denominator;
            float[] impulseVector = { impulse * normal[0], impulse * normal[1] };//impulse as a vector

            //Update velocities and angular velocities
            A.changeVelocity(new float[] { A.velocity[0] + impulseVector[0] / A.getMass(), A.velocity[1] + impulseVector[1] / A.getMass() });
            B.changeVelocity(new float[] { B.velocity[0] - impulseVector[0] / B.getMass(), B.velocity[1] - impulseVector[1] / B.getMass() });
            A.changeAngular(A.getAngularVelocity() + (CenterToCollisionA[0] * impulseVector[1] - CenterToCollisionA[1] * impulseVector[0]) / A.getMomentOfInertia());
            B.changeAngular(B.getAngularVelocity() - (CenterToCollisionB[0] * impulseVector[1] - CenterToCollisionB[1] * impulseVector[0]) / B.getMomentOfInertia());

            //the following seperates objects if they have ended up inside eachother, though this is not as rigorous as CCD (explained in evaluation)
            float penetration = 0.04f; //limit for penetration, 0,04 is chosen because it seems to work best (rather than 0.03 or 0.05)
            float percent = 0.2f;// code is found from https://code.tutsplus.com/how-to-create-a-custom-2d-physics-engine-the-basics-and-impulse-resolution--gamedev-6331t
            float correction = Math.Max(penetration, 0f) / (1 / A.getMass() + 1 / B.getMass()) * percent;
            float[] correctionVec = { correction * normal[0], correction * normal[1] };// penetration correction algorithm

            A.position[0] += correctionVec[0] / A.getMass();
            A.position[1] += correctionVec[1] / A.getMass();
            B.position[0] -= correctionVec[0] / B.getMass();
            B.position[1] -= correctionVec[1] / B.getMass();//adjusts positions of polygons depending on their mass (inertia) and the correction values
        }

        public float[] EPA(Polygon A, Polygon B, Polytope polytope)// returns the normal to collision
        //https://www.youtube.com/watch?v=6rgiPrzqt9w, https://www.youtube.com/watch?v=0XQ2FSz3EK8, again shows the algorithm but not code
        {
;
            float[] normalD = new float[2];// direction of collision
            int distanceIndex = 0;//point in list of edge which is the furthest from the origin
            float[] AB = new float[2];//vector between two points
            float previousMinDistance = float.MaxValue;// need to store the previous smallest distance
            while (true)
            {
                float minDistance = float.MaxValue;//minimum distance set to max so that we can find the smaller and smaller version of it, https://stackoverflow.com/questions/11857797/maximum-value-for-type-float-in-c-sharp
                for (int i = 0; i < polytope.Top(); i++)//finds the side of polytope closest to the origin
                {
                    // to find the distance to a point using dot products: https://brilliant.org/wiki/dot-product-distance-between-point-and-a-line/#:~:text=The%20distance%20formula%20can%20be,%E2%88%A3%20a%202%20%2B%20b%202%20.
                    float[] ABNormal = PerpendicularVectorToOrigin(GetCoords(polytope.vertexes, i), GetCoords(polytope.vertexes, i + 1));// finds the normal to the line between two points
                    float Distance = DotProduct(GetCoords(polytope.vertexes, i), ABNormal) / (float)Math.Sqrt(Math.Pow(ABNormal[0], 2) + Math.Pow(ABNormal[1], 2));// distance to origin
                    if (Distance < minDistance)//finds closest edge to origin
                    {
                        minDistance = Distance;// set smallest distance
                        normalD = ABNormal;// set new direction 
                        distanceIndex = i;// save the point in vertexes the point should be saved
                        AB = VectorXtoY(GetCoords(polytope.vertexes, i), GetCoords(polytope.vertexes, i + 1));// saves the newest closest edge
                    }
                }
                float[] FarPoint = Support(A, B, normalD);// the minkowski difference point furthest in the direction of the normal to the line closest to the origin
                if (RecursiveCheck(polytope.vertexes, A, B, normalD, FarPoint, polytope) == true || Math.Abs(previousMinDistance - minDistance) < 0.0001f)//point is new
                {
                    return normalD;// this is the end condition for finding the final normal to the collision
                }
                else// then the closest edge is
                {
                    if (distanceIndex + 1 > polytope.Top())
                    {
                        distanceIndex = 0;
                    }
                    polytope.indexPush(FarPoint, distanceIndex + 1);
                }
                previousMinDistance = minDistance;
            }
        }

        public float[] SupportPoint(float[] D, Polygon A)//returns the maximum point of a polygon in direction D
        {
            float[] coords;
            float MaxDP = float.MinValue;//must be minimum since the largest dot product could be negative
            float[] MaxPoint = new float[2];
            foreach (PointF point in A.drawnPoints)// searches through each point of A
            {
                coords = new float[] { point.X, point.Y };
                float DP = DotProduct(coords, D);
                if (DP > MaxDP)//finds the polygon's point with the maximum dot product as that will be the point furthest in direction D
                {
                    MaxDP = DP;
                    MaxPoint = coords;
                }
            }
            return MaxPoint;
        }
        private float[] Support(Polygon A, Polygon B, float[] D)// one point on minkowski difference for direction D (difference of two maximum points)
        {
            float[] NegativeD = new float[] { -D[0], -D[1] };
            float[] AmaxPoint = SupportPoint(D, A);
            float[] BmaxPoint = SupportPoint(NegativeD, B);
            return VectorXtoY(BmaxPoint, AmaxPoint);// max point/vector of A in D - max point/vector of B in -D

        }
        public bool GJK(Polygon A, Polygon B, Simplex simplex)// returns whether A and B colide
        //https://www.youtube.com/watch?v=MDusDn8oTSE gives part of the general algorithm, but not C# code
        {
            float[] D = VectorXtoY(A.position, B.position); ;// should be vector between centers of the polygons
            float[] support = Support(A, B, D);// current vector/point for furthest point on minkowski difference
            
            simplex.push(support);// add initial point to simplex stack
            D = Negative(support);// makes D the vector from support to the origin
            while (true)// loops until origin is found to be in or oustide of minkowski difference
            {
                support = Support(A, B, D);
                if (DotProduct(support, D) <= 0 || RecursiveCheck(simplex.vertexes, A, B, D, support, simplex))//check if point is valid
                {
                    return false;// no collision since furthest point is before the origin
                }
                simplex.push(support);// if point is valid it is added to simplex

                if (SimplexHandler(simplex, ref D))//the algorithm is therefore ran
                    // if simplexhandler returns false then the while loop just repeats
                {
                    return true;// if origin is found to be in simplex
                }
            }
        }
        public bool SimplexHandler(Simplex simplex, ref float[] D)// runs if collision is possible
        {
            float[] X = new float[] { simplex.vertexes[simplex.Top(), 0], simplex.vertexes[simplex.Top(), 1] };// make Top its own point
            float[] XO = Negative(X); // X towards the origin
            if (simplex.Top() == 1)// when the simplex has two points, so is a line
            {
                float[] Y = new float[] { simplex.vertexes[0, 0], simplex.vertexes[0, 1] };// since it is a line, the only other point other than top is at array[0]
                float[] XY = VectorXtoY(X, Y);
                D = PerpendicularVectorToOrigin(XY, XO);// perpendicular vector to the simplex line of the two most recent points from https://www.youtube.com/watch?v=ajv46BSqcK4&t=60s
                //we just have a line so cannot know if origin will be in the simplex
            }
            else//triangle case
            {
                //perpendicular vectors to the lines between the current support and the two other points on the triangle \/
                float[] support1 = PerpendicularVectorToOrigin(GetCoords(simplex.vertexes, simplex.Top()), GetCoords(simplex.vertexes, simplex.Top() - 1));//perp of support and the previous point
                float[] support2 = PerpendicularVectorToOrigin(GetCoords(simplex.vertexes, simplex.Top()), GetCoords(simplex.vertexes, simplex.Top() - 2));//perp of support and two points ago

                if (DotProduct(support1, XO) > 0)//if origin is perpendicular to one side of simplex
                {
                    simplex.deque(0);
                    D = support1;//should find perpendicular vector between top point and 2nd top point in simplex
                }
                else if (DotProduct(support2, XO) > 0)
                {
                    simplex.deque(1);
                    D = support2;
                }
                else
                    return true; //since at this point the origin cannot be outside either side of the triangle
            }
            return false;
        }
        // below are the comonly used methods for vector manipulation
        public bool RecursiveCheck(float[,] vertexes, Polygon A, Polygon B, float[] D, float[] support, Simplex simplex)//checks whether a new support point is already on the stack
        {
            bool x = false;// it is assumed that the new support is not already in the simplex
            for (int i = 0; i < simplex.Top(); i++)//getlength is used to find the amount of points in vertexes https://www.programiz.com/csharp-programming/multidimensional-arrays#:~:text=GetLength(0)%20%2D%20gives%20the,of%20elements%20in%20the%20row
            {
                if (Math.Abs(support[0] - GetCoords(vertexes, i)[0]) < 0.0001f && Math.Abs(support[1] - GetCoords(vertexes, i)[1]) < 0.0001f)// compares support to every simplex point to sheck for repeats
                //0.0001f is used to account for floating point error, i found this technique on https://forums.ni.com/t5/LabVIEW/How-do-you-guys-deal-with-floating-point-errors/td-p/4208871
                {
                    x = true;
                }
            }
            return x;
        }
        public float DotProduct(float[] x, float[] y)// finds dotproduct of two vectors/points
        {
            return x[0] * y[0] + x[1] * y[1];
        }
        public float[] VectorXtoY(float[] x, float[] y)
        {
            return new float[] {y[0] - x[0], y[1] - x[1] };
        }
        public float[] MultVector(float[] x, float[] y)//wrong
        {
            return new float[] { x[0] * y[0], x[1] * y[1] };
        }
        public float[] PerpendicularVectorToOrigin(float[] x, float[] y)//perpendicular vector pointing towards the origin to the vector between points x and y
        {
            float dot = x[0] * y[1] - x[1] * y[0];
            return new float[] { -dot * x[1], dot * x[0] };
        }
        public float[] Negative(float[]x)
        {
            return new float[] { -x[0], -x[1] };
        }
        public float[] GetCoords(float[,] vertexes, int rowIndex)
        {
            float[] Coords = new float[2];
            Coords[0] = vertexes[rowIndex, 0];
            Coords[1] = vertexes[rowIndex, 1];
            return Coords;
        }
        public float[] Normalize(float[] vector)
        {
            float magnitude = (float)Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2));
            vector[0] /= magnitude;
            vector[1] /= magnitude;
            return vector;
        }
        public void RecursiveMergeSort(ref float[] array1d)// sorts a 1d array
        {
            int Len = array1d.Length;
            int Mid = Len / 2;
            float[] rArray = new float[Mid];
            float[] lArray = new float[Len - Mid];
            array1d.CopyTo(lArray, 0);
            array1d.CopyTo(rArray, Mid);
            RecursiveMergeSort(ref lArray);
            RecursiveMergeSort(ref rArray);// ref is used to makesure the final values are changed

        }
        public float[] Array2dTO1d(float[,] array2d)//converts a 2d array of coordinates to a 1d array where each value is a 2 digit number
        {
            float[] arrayCollumnOne = new float[array2d.GetLength(0)];//array length of 2d array
            float[] arrayCollumnTwo = new float[array2d.GetLength(0)];//array width of 2d array
            float[] array1d = new float[array2d.GetLength(0)];
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                arrayCollumnOne[i] = array2d[i, 0];
                arrayCollumnTwo[i] = array2d[i, 1];
                array1d[i] = arrayCollumnOne[i] * 10 + arrayCollumnTwo[i];
            }
            return array1d;
        }
        public int ValueIndex(ref float[] Array, float Value)// recursive bianry search
        {
            int Len = Array.Length;
            int Mid = Len / 2;
            if (Array[Mid] == Value)
                return Mid;
            else if (Array[Mid] < Value)
            {
                float[] nextArray = new float[Mid];
                Array.CopyTo(nextArray, 0);
                return ValueIndex(ref nextArray, Value);
            }
            else if (Array[Mid] > Value)
            {
                float[] nextArray = new float[Len - Mid];
                Array.CopyTo(nextArray, Mid);
                return ValueIndex(ref nextArray, Value);
            }
            else
            {
                return 0;
            }
        }
    }
}
