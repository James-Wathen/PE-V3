using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_V2
{
    public partial class CircleEditor : Form//this is where the data for the circle's add button is processed
    {
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

        public float NewGMass = 50 * (float)Math.Pow(10, 10);// makes mass large enough for force from force object to make an effect on the shapes
        public float[] GravPosition = { 500, 400 };
        public float[] CirclePosition = { 500, 400 };
        public float[] CircleVelocity = { -10, -100 };
        public float[] CircleAcceleration = { 0, 0};
        public float CircleDiameter = 100;
        public float CircleMass = 1;// ubove are the defaults
        public Pen CircleColour;

        public bool circleAdd = false;
        public bool GravityAdd = false;
        public List<TextBox> Values = new List<TextBox>();// for error checking on whether the values are appropriate

        public CircleEditor()
        {
            CircleColour = black;
            InitializeComponent();
        }
        private void finalCheck()// tests for text validity once values are used and shows error message otherwise
        {
            bool x = false;
            foreach (TextBox box in Values)
            {
                if (!EnterValidCheck(box.Text))
                {
                    x = true;
                }
            }
            if (x)
            {
                MessageBox.Show("All values must be numbers");//error message
            }
            else if (!x)
            {
                this.Close();
            }
        }
        private void AddGravObj_Click(object sender, EventArgs e)
        {
            finalCheck();
            GravityAdd = true;
            //CircleManager.forces.Add(new Force(NewGMagnitude, GravPosition, true));
        }
        private void AddCircle_Click(object sender, EventArgs e)
        {
            finalCheck();
            circleAdd = true;
        }
        public bool EnterValidCheck(string String)// checks for validitiy
        {
            try
            {
                Convert.ToInt32(String);
            }
            catch
            {
                return false;
            }
            return true;
        }
        //the following classes go through the same pattern of testing whether the value is valid and then changing the circle editors value to that new inputted value
        private void GravMagnitude_TextChanged(object sender, EventArgs e)
        {
            string GMagnitude = GravMagnitude.Text;
            if (EnterValidCheck(GMagnitude) == true)
            {
                NewGMass = Convert.ToInt32(GMagnitude) * (float)Math.Pow(10, 10);
            }
            Values.Add(GravMagnitude);
        }

        private void GravLocationX_TextChanged(object sender, EventArgs e)
        {
            string GLocationX = GravLocationX.Text;
            if (EnterValidCheck(GLocationX))
            {
                GravPosition[0] = Convert.ToInt32(GLocationX);
            }
            Values.Add(GravLocationX);
        }

        private void GravLocationY_TextChanged(object sender, EventArgs e)
        {
            string GLocationY = GravLocationY.Text;
            if (EnterValidCheck(GLocationY))
            {
                GravPosition[1] = Convert.ToInt32(GLocationY);
            }
            Values.Add(GravLocationY);
        }

        private void CircleDiameterBox_TextChanged(object sender, EventArgs e)
        {
            string String = CircleDiameterBox.Text;
            if (EnterValidCheck(String))
            {
                CircleDiameter = Convert.ToInt32(String);
            }
            Values.Add(CircleDiameterBox);
        }

        private void CircleVelXBox_TextChanged(object sender, EventArgs e)
        {
            string String = CircleVelXBox.Text;
            if (EnterValidCheck(String))
            {
                CircleVelocity[0] = Convert.ToInt32(String);
            }
            Values.Add(CircleVelXBox);
        }

        private void CircleVelYBox_TextChanged(object sender, EventArgs e)
        {
            string String = CircleVelYBox.Text;
            if (EnterValidCheck(String))
            {
                CircleVelocity[1] = Convert.ToInt32(String);
            }
            Values.Add(CircleVelYBox);
        }

        private void CirclePositionXBox_TextChanged(object sender, EventArgs e)
        {
            string String = CirclePositionXBox.Text;
            if (EnterValidCheck(String))
            {
                CirclePosition[0] = Convert.ToInt32(String);
            }
            Values.Add(CirclePositionXBox);
        }

        private void CirclePositionYBox_TextChanged(object sender, EventArgs e)
        {
            string String = CirclePositionYBox.Text;
            if (EnterValidCheck(String))
            {
                CirclePosition[1] = Convert.ToInt32(String);
            }
            Values.Add(CirclePositionYBox);
        }

        private void CircleAccelXBox_TextChanged(object sender, EventArgs e)
        {
            string String = CircleAccelXBox.Text;
            if (EnterValidCheck(String))
            {
                CircleAcceleration[1] = Convert.ToInt32(String);
            }
            Values.Add(CircleAccelXBox);
        }

        private void CircleAccelYBox_TextChanged(object sender, EventArgs e)
        {
            string String = CircleAccelYBox.Text;
            if (EnterValidCheck(String))
            {
                CircleAcceleration[1] = Convert.ToInt32(String);
            }
            Values.Add(CircleAccelYBox);
        }

        private void ColourBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = ColourBox.SelectedItem.ToString();

            if (selected == "Black")
            {
                CircleColour = black;
            }
            if (selected == "Blue")
            {
                CircleColour = blue;
            }
            if (selected == "Red")
            {
                CircleColour = Red;
            }
            if (selected == "Green")
            {
                CircleColour = green;
            }
            if (selected == "Yellow")
            {
                CircleColour = yellow;
            }
            if (selected == "Purple")
            {
                CircleColour = purple;
            }
            if (selected == "Turquoise")
            {
                CircleColour = turquoise;
            }
            if (selected == "Magenta")
            {
                CircleColour = magenta;
            }
            if (selected == "Pink")
            {
                CircleColour = pink;
            }
            if (selected == "Orange")
            {
                CircleColour = orange;
            }
            if (selected == "Brown")
            {
                CircleColour = brown;
            }
        }


        private void MassBox_TextChanged(object sender, EventArgs e)
        {
            string String = MassBox.Text;
            if (EnterValidCheck(String))
            {
                CircleMass = Convert.ToInt32(String);
            }
            Values.Add(MassBox);
        }
    }
}
