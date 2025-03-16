using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_V2
{
    internal class CircleManager : Form//this is where the circle simulation is displayed and ran
    {

        private static System.Windows.Forms.Timer timer;
        private Button AddBall;
        private Button Clear;
        public List<CircleEntity> Objects = new List<CircleEntity>(); // list of entities
        public static List<Force> forces = new List<Force>();
        Pen black = new Pen(Color.Black, 4);// make a pen
        Pen blue = new Pen(Color.Blue, 4);
        Pen Red = new Pen(Color.Red, 4);
        Pen green = new Pen(Color.Green, 4);
        Pen yellow = new Pen(Color.Yellow, 4);
        Pen purple = new Pen(Color.Purple, 4);
        Pen turquoise = new Pen(Color.Turquoise, 4);
        Pen magenta = new Pen(Color.Magenta, 4);
        Pen pink = new Pen(Color.Pink, 4);
        Pen orange = new Pen(Color.Orange, 4);
        Pen brown = new Pen(Color.Brown, 4);
        Rectangle area = new Rectangle(0, 0, 1050, 703);
        private Button Quit;
        private Label label1;
        private CheckBox CollisionBox;
        private Button AddSpecifics;
        private CheckBox PausedBox;
        public List<Pen> Pens = new List<Pen>();


        public CircleManager()
        {
            InitializeComponent(); // initializes all windows forms elements before velocities are calculated
            this.KeyPress += new KeyPressEventHandler(KeyPressEvent);// when a key is pressed 'KeyPressEvent' is called
            this.DoubleBuffered = true;//makes it run timer tick before rendering
            this.Size = new Size(1050, 850);//size of window
            this.Paint += new PaintEventHandler(draw);

            Pens.Add(black);
            Pens.Add(blue);
            Pens.Add(Red);
            Pens.Add(green);
            Pens.Add(yellow);
            Pens.Add(purple);
            Pens.Add(turquoise);
            Pens.Add(magenta);
            Pens.Add(pink);
            Pens.Add(orange);
            Pens.Add(brown);// all pen colours must be added to the list

            setTimer();

        }
        private void setTimer()// from https://www.youtube.com/watch?v=GNyeojGBqmQ&t=322s and https://learn.microsoft.com/en-us/dotnet/api/system.timers.timer?view=net-8.0
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = (1000 / 120);// assigns the frame rate
            timer.Tick += Timer_Tick;//makes the timer tick method
            timer.Start();//starts
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Objects.Count; i++)
            {
                WallColl(i);//checks for all collisions with walls seperately
            }
            if (CollisionBox.Checked)
            {
                Collision();//checks for all collisions between circles
            }
            if (PausedBox.Checked)// the framerates for objects is different to the ones for the simulation as a whole
            {
                foreach (CircleEntity circle in Objects)
                {
                    circle.frameRate = 0;//makes all circles stop while pausedBox is checked
                }
            }
            else if (!PausedBox.Checked)
            {
                foreach (CircleEntity circle in Objects)
                {
                    circle.frameRate = 1f / 60f;//when it isnt checked the framerate gets reset
                }
            }
            this.Invalidate(area); // should redraw the form in the specified area
        }
        public void draw(object sender, PaintEventArgs e)// code learnt from https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-create-graphics-objects-for-drawing?view=netframeworkdesktop-4.8
        {//runs every time the form is invalidated in the timer
            Graphics g = e.Graphics;// obtaining graphics object
            Random rand = new Random();
            lock (Objects)//makes code run with thread error prevention
            {
                for (int i = 0; i < Objects.Count; i++)
                {
                    Objects[i].updateAcceleration(forces);
                    Objects[i].updateVelocity();
                    Objects[i].updatePosition();

                    if (Objects[i].position[0] + Objects[i].Diameter <= this.Width && Objects[i].position[1] + Objects[i].Diameter <= this.Height)
                    {
                        e.Graphics.DrawEllipse(Objects[i].Colour, Objects[i].position[0], Objects[i].position[1], Objects[i].Diameter, Objects[i].Diameter);// pen, x of top left, y of top left, diameter across, diameter up
                    }
                    // makes sure that the objects are within the form before drawing them to prevent overflow error while drawing
                }

            }
            g.DrawLine(Red, 10, 10, 10, 700);
            g.DrawLine(black, 1025, 700, 10, 700);
            g.DrawLine(green, 1025, 700, 1025, 10);
            g.DrawLine(blue, 10, 10, 1025, 10);
        }
        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                AddBall.PerformClick();// Trigger the button's Click event
            }
        }
        private void AddBall_Click(object sender, EventArgs e)// adds a ball with random properties
        {
            Random rand = new Random();
            CircleEntity Ball = new CircleEntity(rand.Next(-300, 300), rand.Next(-400, -100), 0, 400, 500, 500, 150, Pens[rand.Next(1, 10)], true, 4);
            lock (Objects)// lock prevents error by making this only occur in a single thread https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/lock
            {
                Objects.Add(Ball);
            }
        }
        public void Collision()
        {
            Random rand = new Random();
            lock (Objects)// previously sourced
            {
                for (int i = 0; i < Objects.Count; i++)// checks for every ball
                {
                    if (Objects.Count >= 2)
                    {
                        for (int n = 0; n < Objects.Count; n++)//detects whether each ball collides with every other ball
                        {
                            // to find distance between Object i and Object n
                            float Distance = (float)Math.Sqrt((Math.Pow(((Objects[i].position[0] + Objects[i].Diameter / 2) - (Objects[n].position[0] + Objects[n].Diameter / 2)), 2) + Math.Pow(((Objects[i].position[1] + Objects[i].Diameter / 2) - (Objects[n].position[1] + Objects[n].Diameter / 2)), 2)));
                            if ((Distance <= (Objects[i].Diameter / 2 + Objects[n].Diameter / 2)) && n != i)// compares distances and sum of radii to determine whether a collision has occured
                            {
                                double M1 = -((Objects[i].position[1] - Objects[n].position[1]) / (Objects[i].position[0] - Objects[n].position[0]));// gradient of normal to ball's collision
                                Objects[i].Colour = Pens[rand.Next(1, 10)];// randomizes colour to show that a collision has occured

                                SetVelocityComponents(i, n, M1);
                                SetVelocityComponents(n, i, M1);// finds the new velocities for each ball and sets them
                            }
                        }
                    }
                }
            }
        }
        private void WallColl(int i)
        {
            float DX10 = Objects[i].position[0] + (Objects[i].Diameter / 2) - 10; // distance from left
            float DX1025 = 1025 - Objects[i].position[0] - (Objects[i].Diameter / 2); // distance right
            float DY10 = Objects[i].position[1] + (Objects[i].Diameter / 2) - 10; // distance from top 
            float DY700 = 700 - Objects[i].position[1] - (Objects[i].Diameter / 2);// distance from bottom
                                                                                   //numbers used in finding distance for readability

            //double RD = Math.Sqrt(Math.Pow(Math.Sqrt(Math.Pow(DX10, 2) + Math.Pow(DY10, 2)), 2) - Math.Pow(DY10, 2));// distance from Red line
            //double BKD = Math.Sqrt(Math.Pow(Math.Sqrt(Math.Pow(DX10, 2) + Math.Pow(DY700, 2)), 2) - Math.Pow(DX10, 2));// distance from Black line
            //double GD = Math.Sqrt(Math.Pow(Math.Sqrt(Math.Pow(DX1025, 2) + Math.Pow(DY700, 2)), 2) - Math.Pow(DY700, 2));// distance from green line
            //double BLD = Math.Sqrt(Math.Pow(Math.Sqrt(Math.Pow(DX10, 2) + Math.Pow(DY10, 2)), 2) - Math.Pow(DX10, 2));// distance from blue line
            // the code ubove has been kept for further additions to the simulation, however it is not needed for the simple simulation in circle manager
            if (DX10 <= (Objects[i].Diameter / 2) || DX1025 <= (Objects[i].Diameter / 2))// checks for the ball coming close to the lines on x axis
            {
                Objects[i].velocity[0] = -Objects[i].velocity[0]; // flips velocity in x direction

            }
            if (DY10 <= (Objects[i].Diameter / 2) || DY700 <= (Objects[i].Diameter / 2))// checks for the ball coming close to the lines on y axis
            {
                Objects[i].velocity[1] = -Objects[i].velocity[1]; // flips velocity in y direction
            }
        }

        private void SetVelocityComponents(int i, int n, double M1)// finds and sets new velocities after a collision
        {
            double M2 = Objects[i].velocity[1] / Objects[i].velocity[0];// gradient of ball i's velocity

            double M3 = ((2 * M1) + (M2 * Math.Pow(M1, 2)) - M2) / (2 * M1 * M2 - Math.Pow(M1, 2) + 1); // gradient of reflected M2 over M1
            double Vo = Objects[i].findVelocity();
            double newVx = Vo / (1 + M3);
            double newVy = Math.Sqrt(Math.Pow(Vo, 2) - Math.Pow(newVx, 2));// finds new velocity values, from https://stackoverflow.com/questions/17395860/how-to-reflect-a-line-over-another-line

            Objects[i].velocity[0] = float.IsNaN((float)newVx) ? 0 : (float)newVx;
            Objects[i].velocity[1] = float.IsNaN((float)newVy) ? 0 : (float)newVy;
            //checks whether nexV is a real value is NaN, then makes it 0 or itself if it isnt, from: https://how.dev/answers/how-to-check-if-a-value-is-not-a-number-nan-in-c-sharp
        }
        private void OutBoundsCheck()
        {
            for (int i = 0; i < Objects.Count; i++)
            {
                float center = Objects[i].position[0] - Objects[i].Diameter / 2;
                if (Objects[i].findDistance('T') < 0 || Objects[i].findDistance('B') < 0 || Objects[i].findDistance('L') < 0 || Objects[i].findDistance('R') < 0)
                {// if out of bounds:
                    float M3 = 1;
                    double Vo = Objects[i].findVelocity();
                    double newVx = Vo / (1 + M3);
                    double newVy = Math.Sqrt(Math.Pow(Vo, 2) - Math.Pow(newVx, 2));// flips velocities
                }
            }


        }



        private void InitializeComponent()
        {
            this.AddBall = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CollisionBox = new System.Windows.Forms.CheckBox();
            this.AddSpecifics = new System.Windows.Forms.Button();
            this.PausedBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AddBall
            // 
            this.AddBall.Location = new System.Drawing.Point(469, 750);
            this.AddBall.Name = "AddBall";
            this.AddBall.Size = new System.Drawing.Size(75, 23);
            this.AddBall.TabIndex = 0;
            this.AddBall.Text = "Add Ball";
            this.AddBall.UseVisualStyleBackColor = true;
            this.AddBall.Click += new System.EventHandler(this.AddBall_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(12, 747);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Quit.Location = new System.Drawing.Point(945, 750);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 731);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Press Space";
            // 
            // CollisionBox
            // 
            this.CollisionBox.AutoSize = true;
            this.CollisionBox.Checked = true;
            this.CollisionBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CollisionBox.Location = new System.Drawing.Point(637, 747);
            this.CollisionBox.Name = "CollisionBox";
            this.CollisionBox.Size = new System.Drawing.Size(64, 17);
            this.CollisionBox.TabIndex = 5;
            this.CollisionBox.Text = "Collision";
            this.CollisionBox.UseVisualStyleBackColor = true;
            // 
            // AddSpecifics
            // 
            this.AddSpecifics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddSpecifics.Location = new System.Drawing.Point(229, 745);
            this.AddSpecifics.Name = "AddSpecifics";
            this.AddSpecifics.Size = new System.Drawing.Size(128, 23);
            this.AddSpecifics.TabIndex = 6;
            this.AddSpecifics.Text = "Add specifics";
            this.AddSpecifics.UseVisualStyleBackColor = false;
            this.AddSpecifics.Click += new System.EventHandler(this.AddSpecifics_Click);
            // 
            // PausedBox
            // 
            this.PausedBox.AutoSize = true;
            this.PausedBox.Location = new System.Drawing.Point(707, 747);
            this.PausedBox.Name = "PausedBox";
            this.PausedBox.Size = new System.Drawing.Size(62, 17);
            this.PausedBox.TabIndex = 7;
            this.PausedBox.Text = "Paused";
            this.PausedBox.UseVisualStyleBackColor = true;
            // 
            // CircleManager
            // 
            this.ClientSize = new System.Drawing.Size(1050, 850);
            this.Controls.Add(this.PausedBox);
            this.Controls.Add(this.AddSpecifics);
            this.Controls.Add(this.CollisionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.AddBall);
            this.Name = "CircleManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Objects.Clear();
            forces.Clear();// clears both lists
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();// quit button
        }

        private void AddSpecifics_Click(object sender, EventArgs e)
        {
            CircleEditor editor = new CircleEditor();
            editor.ShowDialog();
            if (editor.circleAdd)
            {
                Objects.Add(new CircleEntity(editor.CircleVelocity[0], editor.CircleVelocity[1], editor.CircleAcceleration[0], editor.CircleAcceleration[1], editor.CirclePosition[0], editor.CirclePosition[1], editor.CircleDiameter, editor.CircleColour, true, editor.CircleMass));
            }
            if (editor.GravityAdd)
            {
                forces.Add(new Force(editor.NewGMass, editor.GravPosition, true));
            }
            //changes what is added depending on what button is pressed in circle simulation
        }

    }
}