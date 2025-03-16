namespace PE_V2
{
    partial class CircleEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddGravObj = new System.Windows.Forms.Button();
            this.GravMagnitude = new System.Windows.Forms.TextBox();
            this.GravLocationX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GravLocationY = new System.Windows.Forms.TextBox();
            this.AddCircle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CircleDiameterBox = new System.Windows.Forms.TextBox();
            this.CircleVelXBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CircleVelYBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CirclePositionYBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CirclePositionXBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CircleAccelYBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CircleAccelXBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ColourBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MassBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddGravObj
            // 
            this.AddGravObj.Location = new System.Drawing.Point(27, 11);
            this.AddGravObj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddGravObj.Name = "AddGravObj";
            this.AddGravObj.Size = new System.Drawing.Size(95, 19);
            this.AddGravObj.TabIndex = 0;
            this.AddGravObj.Text = "Add Gravity object";
            this.AddGravObj.UseVisualStyleBackColor = true;
            this.AddGravObj.Click += new System.EventHandler(this.AddGravObj_Click);
            // 
            // GravMagnitude
            // 
            this.GravMagnitude.Location = new System.Drawing.Point(128, 35);
            this.GravMagnitude.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GravMagnitude.Name = "GravMagnitude";
            this.GravMagnitude.Size = new System.Drawing.Size(76, 20);
            this.GravMagnitude.TabIndex = 1;
            this.GravMagnitude.Text = "50";
            this.GravMagnitude.TextChanged += new System.EventHandler(this.GravMagnitude_TextChanged);
            // 
            // GravLocationX
            // 
            this.GravLocationX.Location = new System.Drawing.Point(134, 60);
            this.GravLocationX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GravLocationX.Name = "GravLocationX";
            this.GravLocationX.Size = new System.Drawing.Size(25, 20);
            this.GravLocationX.TabIndex = 2;
            this.GravLocationX.Text = "500";
            this.GravLocationX.TextChanged += new System.EventHandler(this.GravLocationX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gravity Mass:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gravity Location:";
            // 
            // GravLocationY
            // 
            this.GravLocationY.Location = new System.Drawing.Point(178, 60);
            this.GravLocationY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GravLocationY.Name = "GravLocationY";
            this.GravLocationY.Size = new System.Drawing.Size(25, 20);
            this.GravLocationY.TabIndex = 5;
            this.GravLocationY.Text = "400";
            this.GravLocationY.TextChanged += new System.EventHandler(this.GravLocationY_TextChanged);
            // 
            // AddCircle
            // 
            this.AddCircle.Location = new System.Drawing.Point(32, 131);
            this.AddCircle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddCircle.Name = "AddCircle";
            this.AddCircle.Size = new System.Drawing.Size(60, 19);
            this.AddCircle.TabIndex = 6;
            this.AddCircle.Text = "Add Circle";
            this.AddCircle.UseVisualStyleBackColor = true;
            this.AddCircle.Click += new System.EventHandler(this.AddCircle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Circle Diameter:";
            // 
            // CircleDiameterBox
            // 
            this.CircleDiameterBox.Location = new System.Drawing.Point(108, 160);
            this.CircleDiameterBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CircleDiameterBox.Name = "CircleDiameterBox";
            this.CircleDiameterBox.Size = new System.Drawing.Size(76, 20);
            this.CircleDiameterBox.TabIndex = 8;
            this.CircleDiameterBox.Text = "100";
            this.CircleDiameterBox.TextChanged += new System.EventHandler(this.CircleDiameterBox_TextChanged);
            // 
            // CircleVelXBox
            // 
            this.CircleVelXBox.Location = new System.Drawing.Point(115, 183);
            this.CircleVelXBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CircleVelXBox.Name = "CircleVelXBox";
            this.CircleVelXBox.Size = new System.Drawing.Size(31, 20);
            this.CircleVelXBox.TabIndex = 10;
            this.CircleVelXBox.Text = "-10";
            this.CircleVelXBox.TextChanged += new System.EventHandler(this.CircleVelXBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Circle Velocity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Y";
            // 
            // CircleVelYBox
            // 
            this.CircleVelYBox.Location = new System.Drawing.Point(160, 183);
            this.CircleVelYBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CircleVelYBox.Name = "CircleVelYBox";
            this.CircleVelYBox.Size = new System.Drawing.Size(31, 20);
            this.CircleVelYBox.TabIndex = 12;
            this.CircleVelYBox.Text = "-100";
            this.CircleVelYBox.TextChanged += new System.EventHandler(this.CircleVelYBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 208);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Y";
            // 
            // CirclePositionYBox
            // 
            this.CirclePositionYBox.Location = new System.Drawing.Point(160, 206);
            this.CirclePositionYBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CirclePositionYBox.Name = "CirclePositionYBox";
            this.CirclePositionYBox.Size = new System.Drawing.Size(31, 20);
            this.CirclePositionYBox.TabIndex = 19;
            this.CirclePositionYBox.Text = "400";
            this.CirclePositionYBox.TextChanged += new System.EventHandler(this.CirclePositionYBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 208);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "X";
            // 
            // CirclePositionXBox
            // 
            this.CirclePositionXBox.Location = new System.Drawing.Point(115, 206);
            this.CirclePositionXBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CirclePositionXBox.Name = "CirclePositionXBox";
            this.CirclePositionXBox.Size = new System.Drawing.Size(31, 20);
            this.CirclePositionXBox.TabIndex = 17;
            this.CirclePositionXBox.Text = "500";
            this.CirclePositionXBox.TextChanged += new System.EventHandler(this.CirclePositionXBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 208);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Circle Position:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 229);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Y";
            // 
            // CircleAccelYBox
            // 
            this.CircleAccelYBox.Location = new System.Drawing.Point(160, 227);
            this.CircleAccelYBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CircleAccelYBox.Name = "CircleAccelYBox";
            this.CircleAccelYBox.Size = new System.Drawing.Size(31, 20);
            this.CircleAccelYBox.TabIndex = 24;
            this.CircleAccelYBox.Text = "0";
            this.CircleAccelYBox.TextChanged += new System.EventHandler(this.CircleAccelYBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(99, 230);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "X";
            // 
            // CircleAccelXBox
            // 
            this.CircleAccelXBox.Location = new System.Drawing.Point(115, 227);
            this.CircleAccelXBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CircleAccelXBox.Name = "CircleAccelXBox";
            this.CircleAccelXBox.Size = new System.Drawing.Size(31, 20);
            this.CircleAccelXBox.TabIndex = 22;
            this.CircleAccelXBox.Text = "0";
            this.CircleAccelXBox.TextChanged += new System.EventHandler(this.CircleAccelXBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 229);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Circle acceleration:";
            // 
            // ColourBox
            // 
            this.ColourBox.FormattingEnabled = true;
            this.ColourBox.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Green",
            "Yellow",
            "Purple",
            "Turquoise",
            "Magenta",
            "Pink",
            "Orange",
            "Brown"});
            this.ColourBox.Location = new System.Drawing.Point(102, 249);
            this.ColourBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ColourBox.Name = "ColourBox";
            this.ColourBox.Size = new System.Drawing.Size(92, 21);
            this.ColourBox.TabIndex = 26;
            this.ColourBox.SelectedIndexChanged += new System.EventHandler(this.ColourBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(64, 252);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Colour:";
            // 
            // MassBox
            // 
            this.MassBox.Location = new System.Drawing.Point(108, 272);
            this.MassBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MassBox.Name = "MassBox";
            this.MassBox.Size = new System.Drawing.Size(76, 20);
            this.MassBox.TabIndex = 29;
            this.MassBox.Text = "1";
            this.MassBox.TextChanged += new System.EventHandler(this.MassBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(69, 275);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Mass:";
            // 
            // CircleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 313);
            this.Controls.Add(this.MassBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ColourBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CircleAccelYBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CircleAccelXBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CirclePositionYBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CirclePositionXBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CircleVelYBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CircleVelXBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CircleDiameterBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddCircle);
            this.Controls.Add(this.GravLocationY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GravLocationX);
            this.Controls.Add(this.GravMagnitude);
            this.Controls.Add(this.AddGravObj);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CircleEditor";
            this.Text = "CircleEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddGravObj;
        private System.Windows.Forms.TextBox GravMagnitude;
        private System.Windows.Forms.TextBox GravLocationX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GravLocationY;
        private System.Windows.Forms.Button AddCircle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CircleDiameterBox;
        private System.Windows.Forms.TextBox CircleVelXBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CircleVelYBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CirclePositionYBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CirclePositionXBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CircleAccelYBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CircleAccelXBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ColourBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox MassBox;
        private System.Windows.Forms.Label label16;
    }
}