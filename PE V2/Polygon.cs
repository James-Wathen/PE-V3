using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PE_V2
{
    internal class Polygon : Entity//this is used as where the data for each polygon object is stored
    {
        public PointF[] drawnPoints;// https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/polygons-in-gdi?view=netframeworkdesktop-4.8
        private float[,] vertexVectors;//stores vectors towards points
        private float angularVelocity;
        private float angularAcceleration;
        private float elasticity;
        public Polygon(float vx, float vy, float ax, float ay, float px, float py, Pen Colour, float[,] vertexVectors, float angularVelocity, float angularAcceleration, float elasticity, float mass) : base(vx, vy, ax, ay, px, py, Colour, mass)
        {
            velocity = new float[] { vx, vy };
            acceleration = new float[] { ax, ay };
            position = new float[] { px, py };
            this.Colour = Colour;
            this.vertexVectors = vertexVectors;// shows where vertices are in reference to the position/centre of mass
            this.angularVelocity = angularVelocity;
            this.angularAcceleration = angularAcceleration;
            this.elasticity = elasticity;
            this.mass = mass;
            setPosition();
            //due to center of mass, the vertex vectors must be adjusted
        }
        public void setPosition()// uses the centre to find the new position that is seperate to the inputted position into polygon.
        {
            drawnPoints = new PointF[vertexVectors.GetLength(0)];
            for (int i = 0; i < vertexVectors.GetLength(0); i++)// makes an array of each vertex in the polygon
            {
                drawnPoints[i].X = vertexVectors[i, 0] + position[0];
                drawnPoints[i].Y = vertexVectors[i, 1] + position[1];
            }
            float[] center = centre();
            for (int i = 0; i < vertexVectors.GetLength(0); i++)
            {
                vertexVectors[i, 0] = drawnPoints[i].X - center[0];
                vertexVectors[i, 1] = drawnPoints[i].Y - center[1];//finds new vertex vectors depending on the new position and therefore the new points of where the vertices are
            }
            //due to center of mass, the vertex vectors must be adjusted
        }
        public override void updatePosition()
        {
            base.updatePosition();//runs entity.updatePosition, found this code from https://www.geeksforgeeks.org/c-sharp-method-overriding/
            float CosVelocity = (float)Math.Cos(angularVelocity * frameRate);
            float SinVelocity = (float)Math.Sin(angularVelocity * frameRate);
            for (int i = 0; i < vertexVectors.GetLength(0); i++)//https://www.youtube.com/watch?v=fH5MJT3HI58&t=593s
            {
                float Xvector = vertexVectors[i, 0];
                float Yvector = vertexVectors[i, 1];// must be made variable to prevent cross calculation error
                vertexVectors[i, 0] = Xvector * CosVelocity - Yvector * SinVelocity;
                vertexVectors[i, 1] = Xvector * SinVelocity + Yvector * CosVelocity;
            }
            // positive angular velocity causes clockwise motion
            for (int i = 0; i < drawnPoints.Length; i++)// makes each drawn point which is a precise way of knowing where each vertex actually is
            {
                drawnPoints[i].X = vertexVectors[i, 0] + position[0];
                drawnPoints[i].Y = vertexVectors[i, 1] + position[1];
            }
        }
        public override void updateVelocity()
        {
            base.updateVelocity();
            angularVelocity = angularVelocity + angularAcceleration * frameRate;// finds new angular velocity
        }
        public float[] centre()//this shows the maths behind finding the centre of a polygon, https://lexrent.eu/wp-content/uploads/torza/artikel_groep_sub_2_docs/BYZ_3_Polygon-Area-and-Centroid.pdf?utm_source
        {
            float area = 0;
            float Cx = 0;
            float Cy = 0;//values used to find the resultant centre coordinates
            int NoVerticies = drawnPoints.GetLength(0);
            for (int i = 0; i < NoVerticies; i++)
            {
                int plus = i + 1;
                if (i + 1 > NoVerticies - 1)
                    plus = 0;
                float XVertex = drawnPoints[i].X;
                float YVertex = drawnPoints[i].Y;
                float NextXVertex = drawnPoints[plus].X;
                float NextYVertex = drawnPoints[plus].Y;
                float thatPart = XVertex * NextYVertex - NextXVertex * YVertex;

                area = area + (thatPart);
                Cx = Cx + (XVertex + NextXVertex) * (thatPart);
                Cy = Cy + (YVertex + NextYVertex) * (thatPart);
            }

            area = 0.5f * area;
            return new float[] { Cx / (6 * area), Cy / (6 * area) };
        }
        public float getMomentOfInertia()//some pretty annoying maths, https://physics.stackexchange.com/questions/493736/moment-of-inertia-for-an-arbitrary-polygon
        {
            //https://www.khanacademy.org/science/in-in-class11th-physics/in-in-system-of-particles-and-rotational-motion/in-in-rotational-inertia-and-angular-second-law/a/rotational-inertia
            float sumTerm = 0;
            float area = 0;
            int n = vertexVectors.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                int plus = i + 1;
                if (plus >= n)//plus is set to 0 when it exceeds or is equal to n to prevent out of range error
                    plus = 0;
                float xi = vertexVectors[i, 0];
                float yi = vertexVectors[i, 1];
                float xPLus = vertexVectors[plus, 0];
                float yPLus = vertexVectors[plus, 1];

                float cross = xi * xPLus - xPLus * yi;
                area += cross;
                sumTerm += cross * (xi * xi + xi * xPLus + xPLus * xPLus + yi * yi + yi * xPLus + xPLus * xPLus);
            }

            area = Math.Abs(area) * 0.5f;
            if (area < 1e-7f) return float.PositiveInfinity; // to not divide by 0

            return (mass / (12 * area)) * sumTerm;
        }
        // below methods to find data of the polygon
        public float getAngularVelocity()
        {
            return angularVelocity;
        }
        public float getElasticity()
        {
            return elasticity;
        }
        public float getMass()
        {
            return mass;
        }
        public void changeVelocity(float[] newVelocity)
        {
            velocity = newVelocity;
        }
        public void changeAngular(float newAngular)
        {
            angularVelocity = newAngular;
        }

    }
}
