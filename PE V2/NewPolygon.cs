using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_V2
{
    public partial class NewPolygon : Form//this is where the data for the add button is processed
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
        public PolyForm polyform;

        public bool PolygonAdd = false;
        public bool GravityAdd = false;//used in finding what is to be added in poly form

        public float[] Velocity = new float[] { 0, -100 };
        public float[] Acceleration = new float[] { 0, 0 };
        public float[] Position = new float[] { 500, 500 };
        public float AngularVelocity = 0.5f;
        public float AngularAcceleration = 0;
        public float Mass = 1;
        public float Elasticity = 0.5f;
        public Pen Colour;
        public float[,] VertexVectors = { { 25, 25 }, { 25, -25 }, { -25, -25 }, { -25, 25 } };//these are all preset values

        public float GravMagnitude = 10000 * (float)Math.Pow(10, 10);// same reason as in circle editor, the inputted mass is increased to make the gravitational force appropiately large
        public float[] GravLocation = { 500, 400 };
        public float UniGravMag = 100;// close to natural gravity

        public List<TextBox> Values = new List<TextBox>();// for error checking on whether the values are appropriate
        public NewPolygon(PolyForm polyForm)
        {
            this.polyform = polyForm;// links the classes
            Colour = black;
            InitializeComponent();
        }

        private void ColourBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = ColourBox.SelectedItem.ToString();

            if (selected == "Black")
            {
                Colour = black;
            }
            if (selected == "Blue")
            {
                Colour = blue;
            }
            if (selected == "Red")
            {
                Colour = Red;
            }
            if (selected == "Green")
            {
                Colour = green;
            }
            if (selected == "Yellow")
            {
                Colour = yellow;
            }
            if (selected == "Purple")
            {
                Colour = purple;
            }
            if (selected == "Turquoise")
            {
                Colour = turquoise;
            }
            if (selected == "Magenta")
            {
                Colour = magenta;
            }
            if (selected == "Pink")
            {
                Colour = pink;
            }
            if (selected == "Orange")
            {
                Colour = orange;
            }
            if (selected == "Brown")
            {
                Colour = brown;
            }
        }
        public void finalCheck(ref bool Add)// final test for when a new object is added or the values are saved
        {
            bool x = false;
            foreach (TextBox box in Values)
            {
                if (!EnterValidCheck(box.Text, true))
                {
                    x = true;
                }
                else if (!EnterValidCheck(box.Text, false))//if the input is a char
                {
                    x = true;
                }
            }
            if (x)
            {
                MessageBox.Show("All values must be numbers (direction must be a single char)");// error message
            }
            else if (!x)
            {
                Add = true;
                this.Close();
            }
        }
        private void AddPolyButton_Click(object sender, EventArgs e)
        {
            finalCheck(ref PolygonAdd);
        }
        private void AddForceButton_Click(object sender, EventArgs e)
        {
            finalCheck(ref GravityAdd);
        }
        public bool EnterValidCheck(string String, bool Int)//check for whether the data should be changed or not without making an error
        {
            if (Int)
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
            else
            {
                try
                {
                    Convert.ToChar(String);
                }
                catch
                {
                    return false;
                }
                return true;
            }

        }
        //the following classes go through the same pattern of testing whether the value is valid and then changing the newPolygon's value to that new inputted value
        private void MassBox_TextChanged(object sender, EventArgs e)
        {
            string strMass = MassBox.Text;
            if (EnterValidCheck(strMass, true))//checks validity
            {
                Mass = Convert.ToInt32(strMass);
            }
            if (!Values.Contains(MassBox))//prevents duplicates
            {
                Values.Add(MassBox);
            }
        }

        private void VelocityXBox_TextChanged(object sender, EventArgs e)
        {
            string String = VelocityXBox.Text;
            if (EnterValidCheck(String, true))
            {
                Velocity[0] = Convert.ToInt32(String);
            }
            if (!Values.Contains(VelocityXBox))
            {
                Values.Add(VelocityXBox);
            }
        }

        private void VelocityYBox_TextChanged(object sender, EventArgs e)
        {
            string String = VelocityYBox.Text;
            if (EnterValidCheck(String, true))
            {
                Velocity[1] = Convert.ToInt32(String);
            }
            if (!Values.Contains(VelocityYBox))
            {
                Values.Add(VelocityYBox);
            }
        }

        private void AccelerationXBox_TextChanged(object sender, EventArgs e)
        {
            string String = AccelerationXBox.Text;
            if (EnterValidCheck(String, true))
            {
                Acceleration[0] = Convert.ToInt32(String);
            }
            if (!Values.Contains(AccelerationXBox))
            {
                Values.Add(AccelerationXBox);
            }
            Values.Add(AccelerationXBox);
        }

        private void AccelerationYBox_TextChanged(object sender, EventArgs e)
        {
            string String = AccelerationYBox.Text;
            if (EnterValidCheck(String, true))
            {
                Acceleration[1] = Convert.ToInt32(String);
            }
            if (!Values.Contains(AccelerationYBox))
            {
                Values.Add(AccelerationYBox);
            }
        }

        private void AngularVelBox_TextChanged(object sender, EventArgs e)
        {
            string String = AngularVelBox.Text;
            if (EnterValidCheck(String, true))
            {
                AngularVelocity = Convert.ToInt32(String);
            }
            if (!Values.Contains(AngularVelBox))
            {
                Values.Add(AngularVelBox);
            }
        }

        private void AngularAccelBox_TextChanged(object sender, EventArgs e)
        {
            string String = AngularAccelBox.Text;
            if (EnterValidCheck(String, true))
            {
                AngularAcceleration = Convert.ToInt32(String);
            }
            if (!Values.Contains(AngularAccelBox))
            {
                Values.Add(AngularAccelBox);
            }
        }

        private void ElasticityBox_TextChanged(object sender, EventArgs e)
        {
            string String = ElasticityBox.Text;
            if (EnterValidCheck(String, true))
            {
                Elasticity = Convert.ToInt32(String);
            }
            if (!Values.Contains(ElasticityBox))
            {
                Values.Add(ElasticityBox);
            }
        }

        private void RadialMagnitudeBox_TextChanged(object sender, EventArgs e)
        {
            string String = RadialMagnitudeBox.Text;
            if (EnterValidCheck(String, true))
            {
                GravMagnitude = Convert.ToInt32(String) * (float)Math.Pow(10, 10);
            }
            if (!Values.Contains(RadialMagnitudeBox))
            {
                Values.Add(RadialMagnitudeBox);
            }
        }

        private void PositionXBox_TextChanged(object sender, EventArgs e)
        {
            string String = PositionXBox.Text;
            if (EnterValidCheck(String, true))
            {
                GravLocation[0] = Convert.ToInt32(String);
            }
            if (!Values.Contains(PositionXBox))
            {
                Values.Add(PositionXBox);
            }
        }

        private void PositionYBox_TextChanged(object sender, EventArgs e)
        {
            string String = PositionYBox.Text;
            if (EnterValidCheck(String, true))
            {
                GravLocation[1] = Convert.ToInt32(String);
            }
            if (!Values.Contains(PositionYBox))
            {
                Values.Add(PositionYBox);
            }
        }

        private void UniformMagBox_TextChanged(object sender, EventArgs e)
        {
            string String = UniformMagBox.Text;
            if (EnterValidCheck(String, true))
            {
                UniGravMag = Convert.ToInt32(String);
            }
            if(!Values.Contains(UniformMagBox))
            {
                Values.Add(UniformMagBox);
            }
        }

        private void UniformDirectionBox_TextChanged(object sender, EventArgs e)
        {
            string String = UniformDirectionBox.Text;
            if (EnterValidCheck(String, false))
            {
                polyform.Side = Convert.ToChar(String);
            }
            if (!Values.Contains(UniformDirectionBox))
            {
                Values.Add(UniformDirectionBox);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();//quit button
        }
    }
}