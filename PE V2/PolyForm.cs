using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PE_V2
{
    public partial class PolyForm : Form//this is where the polygon simulation is displayed
    {
        private PolyManager polyManager;
        private BufferedGraphicsContext context;// creates the graphics objects https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bufferedgraphics?view=windowsdesktop-9.0
        private BufferedGraphics buffer;// stores the drawing
        private List<Point> points = new List<Point>();
        private List<float[]> DrawnPoly = new List<float[]>(); 
        private bool AddDrawing = false;
        private NewPolygon newPolygon;
        public float UniGravMag;
        public char Side = 'D';

        public PolyForm()
        {
            InitializeComponent();
            newPolygon = new NewPolygon(this);
            polyManager = new PolyManager(this);// both these ligns link the poly manager and newpolygon form to this one
            context = BufferedGraphicsManager.Current;
            buffer = context.Allocate(this.CreateGraphics(), this.ClientRectangle);// where and how the drawing is allocated
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);//this is for dubble buffering (prevents flickering and improving simulation quality), found from https://stackoverflow.com/questions/76993/how-to-double-buffer-net-controls-on-a-form
        }
        protected override void OnPaint(PaintEventArgs e)// code from https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bufferedgraphics?view=windowsdesktop-9.0
        {
            base.OnPaint(e);
            buffer.Graphics.Clear(Color.White);
            Draw(e);
            buffer.Render(e.Graphics);//double buffered graphics 
        }
        public void Draw(PaintEventArgs e)
        {
            Graphics g = buffer.Graphics;
            for (int i = 0; i < polyManager.Objects.Count; i++)
            {
                if (polyManager.forces.Count > 0)
                {
                    polyManager.Objects[i].updateAcceleration(polyManager.forces);
                }
                polyManager.Objects[i].updateVelocity();
                polyManager.Objects[i].updatePosition();


                buffer.Graphics.DrawPolygon(polyManager.Objects[i].Colour, polyManager.Objects[i].drawnPoints);
            }
            for (int i = 0; i < points.Count; i++)// points are used to show where something is drawn
            {
                buffer.Graphics.DrawEllipse(polyManager.black, points[i].position[0], points[i].position[1], points[i].width, points[i].width);
            }
            for (int i = 0; i < polyManager.forces.Count; i++)//shows locatioin of forces
            {
                buffer.Graphics.DrawEllipse(polyManager.blue, polyManager.forces[i].Position[0], polyManager.forces[i].Position[1], 1, 1);
            }
            if (DrawnPoly.Count > 0)// if there is a point in it
            {
                AddDrawing = true;
            }
            else if (DrawnPoly.Count == 0)//this should not be needed but it will prevent any possible errors relating to the drawnpoly list
                    AddDrawing = false;
            UniGravMag = newPolygon.UniGravMag;//sets to the inputted value
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();// quit
        }

        private void AddPolygon_Click(object sender, EventArgs e)
        {
            if (!AddDrawing)// runs normal code to add new object
            {
                newPolygon.ShowDialog();
                if (newPolygon.PolygonAdd)
                {
                    polyManager.Objects.Add(new Polygon(newPolygon.Velocity[0], newPolygon.Velocity[1], newPolygon.Acceleration[0], newPolygon.Acceleration[1], newPolygon.Position[0], newPolygon.Position[1], newPolygon.Colour, newPolygon.VertexVectors, newPolygon.AngularVelocity, newPolygon.AngularAcceleration, newPolygon.Elasticity, newPolygon.Mass));
                    // new force
                }
                if (newPolygon.GravityAdd)
                {
                    polyManager.forces.Add(new Force(newPolygon.GravMagnitude, newPolygon.GravLocation, true));//new force
                }
                //buffer.Graphics.DrawEllipse(polyManager.black, newPolygon.GravLocation[0], newPolygon.GravLocation[1], 30, 30);

            }
            else if (AddDrawing)// runs code for drawing an object
            {
                if (DrawnPoly.Count == 0)// this should not work as there cannot be a drawing if there are no drawn points, so an error message is here to show if it ever does happen
                {
                    MessageBox.Show("How did u do that");
                }
                else if (DrawnPoly.Count == 1)//if there is just one point, it is made into a force
                {
                    polyManager.forces.Add(new Force(newPolygon.GravMagnitude, new float[] { DrawnPoly[0][0], DrawnPoly[0][1] }, true));//puts force in first point in points
                }
                else if (DrawnPoly.Count == 2)// cannot have a polygon with two points with the current program
                {
                    MessageBox.Show("You have inputted 2 points at once, a new object must have\n 1 point for a force\n 3 or more points for a polygon\n");
                    // tells the user what has to be inputted to draw
                }
                else if (DrawnPoly.Count > 1 && DrawnPoly.Count != 2)// drawn poly has a reasonable amount of points
                {
                    float[,] DrawnPolyArray = new float[DrawnPoly.Count, 2];
                    for (int i = 0; i < DrawnPoly.Count; i++)// assigns the list of drawn points to an array
                    {
                        DrawnPolyArray[i, 0] = DrawnPoly[i][0];
                        DrawnPolyArray[i, 1] = DrawnPoly[i][1];
                    }
                    polyManager.Objects.Add(new Polygon(newPolygon.Velocity[0], newPolygon.Velocity[1], newPolygon.Acceleration[0], newPolygon.Acceleration[1], CentreDepVertices()[0], CentreDepVertices()[1], newPolygon.Colour, DrawnPolyArray, newPolygon.AngularVelocity, newPolygon.AngularAcceleration, newPolygon.Elasticity, newPolygon.Mass));
                }
                DrawnPoly = new List<float[]>();// resets the drawn poly object after use
                points = new List<Point>();// would remove all points
                AddDrawing = false;// reset bool
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            polyManager.forces.Clear();
            polyManager.Objects.Clear();
            points.Clear();
            DrawnPoly.Clear();// clears all lists
        }


        private void PolyForm_MouseClick(object sender, MouseEventArgs e)// from https://stackoverflow.com/questions/6376186/c-sharp-detect-where-user-clicked-on-a-image-bitmap
        // and from https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.mouseeventargs?view=windowsdesktop-9.0
        {
            if (Paused.Checked)
            {
                float[] coords = new float[] { e.X, e.Y };
                DrawnPoly.Add(coords);
                points.Add(new Point(coords, 1));// records mouse point to add a draw point
            }
        }
        public float[] CentreDepVertices()//finds centre based on the vertices of the added polygon https://lexrent.eu/wp-content/uploads/torza/artikel_groep_sub_2_docs/BYZ_3_Polygon-Area-and-Centroid.pdf?utm_source
        {
            float area = 0;
            float Cx = 0;
            float Cy = 0;
            int NoVerticies = DrawnPoly.Count;//amount of vertices
            for (int i = 0; i < NoVerticies; i++)// sum equation
            {
                int plus = i + 1;
                if (i + 1 > NoVerticies - 1)
                    plus = 0;
                float XVertex = DrawnPoly[i][0];
                float YVertex = DrawnPoly[i][1];
                float NextXVertex = DrawnPoly[plus][0];
                float NextYVertex = DrawnPoly[plus][1];
                float thatPart = XVertex * NextYVertex - NextXVertex * YVertex;

                area = area + (thatPart);
                Cx = Cx + (XVertex + NextXVertex) * (thatPart);
                Cy = Cy + (YVertex + NextYVertex) * (thatPart);
            }

            area = 0.5f * area;
            return new float[] { Cx / (6 * area), Cy / (6 * area) };
        }

    }
}
