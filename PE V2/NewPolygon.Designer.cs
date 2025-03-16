namespace PE_V2
{
    partial class NewPolygon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPolygon));
            this.label1 = new System.Windows.Forms.Label();
            this.MassBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VelocityXBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VelocityYBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ElasticityBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AccelerationYBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AccelerationXBox = new System.Windows.Forms.TextBox();
            this.AngularVelBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AngularAccelBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ColourBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AddPolyButton = new System.Windows.Forms.Button();
            this.AddForceButton = new System.Windows.Forms.Button();
            this.PositionYBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.PositionXBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.RadialMagnitudeBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.UniformMagBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.UniformDirectionBox = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the values for the new polygon:\r\n";
            // 
            // MassBox
            // 
            this.MassBox.Location = new System.Drawing.Point(115, 26);
            this.MassBox.Margin = new System.Windows.Forms.Padding(2);
            this.MassBox.Name = "MassBox";
            this.MassBox.Size = new System.Drawing.Size(76, 20);
            this.MassBox.TabIndex = 1;
            this.MassBox.Text = "1";
            this.MassBox.TextChanged += new System.EventHandler(this.MassBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mass:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Velocities:";
            // 
            // VelocityXBox
            // 
            this.VelocityXBox.Location = new System.Drawing.Point(128, 49);
            this.VelocityXBox.Margin = new System.Windows.Forms.Padding(2);
            this.VelocityXBox.Name = "VelocityXBox";
            this.VelocityXBox.Size = new System.Drawing.Size(24, 20);
            this.VelocityXBox.TabIndex = 4;
            this.VelocityXBox.Text = "10";
            this.VelocityXBox.TextChanged += new System.EventHandler(this.VelocityXBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y";
            // 
            // VelocityYBox
            // 
            this.VelocityYBox.Location = new System.Drawing.Point(166, 49);
            this.VelocityYBox.Margin = new System.Windows.Forms.Padding(2);
            this.VelocityYBox.Name = "VelocityYBox";
            this.VelocityYBox.Size = new System.Drawing.Size(25, 20);
            this.VelocityYBox.TabIndex = 7;
            this.VelocityYBox.Text = "-50";
            this.VelocityYBox.TextChanged += new System.EventHandler(this.VelocityYBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Elasticity:";
            // 
            // ElasticityBox
            // 
            this.ElasticityBox.Location = new System.Drawing.Point(115, 141);
            this.ElasticityBox.Margin = new System.Windows.Forms.Padding(2);
            this.ElasticityBox.Name = "ElasticityBox";
            this.ElasticityBox.Size = new System.Drawing.Size(76, 20);
            this.ElasticityBox.TabIndex = 9;
            this.ElasticityBox.Text = "1";
            this.ElasticityBox.TextChanged += new System.EventHandler(this.ElasticityBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Acceleration:";
            // 
            // AccelerationYBox
            // 
            this.AccelerationYBox.Location = new System.Drawing.Point(166, 74);
            this.AccelerationYBox.Margin = new System.Windows.Forms.Padding(2);
            this.AccelerationYBox.Name = "AccelerationYBox";
            this.AccelerationYBox.Size = new System.Drawing.Size(25, 20);
            this.AccelerationYBox.TabIndex = 15;
            this.AccelerationYBox.Text = "0";
            this.AccelerationYBox.TextChanged += new System.EventHandler(this.AccelerationYBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "X";
            // 
            // AccelerationXBox
            // 
            this.AccelerationXBox.Location = new System.Drawing.Point(128, 74);
            this.AccelerationXBox.Margin = new System.Windows.Forms.Padding(2);
            this.AccelerationXBox.Name = "AccelerationXBox";
            this.AccelerationXBox.Size = new System.Drawing.Size(24, 20);
            this.AccelerationXBox.TabIndex = 12;
            this.AccelerationXBox.Text = "0";
            this.AccelerationXBox.TextChanged += new System.EventHandler(this.AccelerationXBox_TextChanged);
            // 
            // AngularVelBox
            // 
            this.AngularVelBox.Location = new System.Drawing.Point(115, 96);
            this.AngularVelBox.Margin = new System.Windows.Forms.Padding(2);
            this.AngularVelBox.Name = "AngularVelBox";
            this.AngularVelBox.Size = new System.Drawing.Size(76, 20);
            this.AngularVelBox.TabIndex = 17;
            this.AngularVelBox.Text = "0";
            this.AngularVelBox.TextChanged += new System.EventHandler(this.AngularVelBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Angular velocity:";
            // 
            // AngularAccelBox
            // 
            this.AngularAccelBox.Location = new System.Drawing.Point(115, 119);
            this.AngularAccelBox.Margin = new System.Windows.Forms.Padding(2);
            this.AngularAccelBox.Name = "AngularAccelBox";
            this.AngularAccelBox.Size = new System.Drawing.Size(76, 20);
            this.AngularAccelBox.TabIndex = 19;
            this.AngularAccelBox.Text = "0";
            this.AngularAccelBox.TextChanged += new System.EventHandler(this.AngularAccelBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 121);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Angular acceleration:";
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
            this.ColourBox.Location = new System.Drawing.Point(115, 164);
            this.ColourBox.Margin = new System.Windows.Forms.Padding(2);
            this.ColourBox.Name = "ColourBox";
            this.ColourBox.Size = new System.Drawing.Size(92, 21);
            this.ColourBox.TabIndex = 20;
            this.ColourBox.SelectedIndexChanged += new System.EventHandler(this.ColourBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 167);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Change Colour:";
            // 
            // AddPolyButton
            // 
            this.AddPolyButton.Location = new System.Drawing.Point(54, 198);
            this.AddPolyButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddPolyButton.Name = "AddPolyButton";
            this.AddPolyButton.Size = new System.Drawing.Size(129, 30);
            this.AddPolyButton.TabIndex = 22;
            this.AddPolyButton.Text = "Add the polygon";
            this.AddPolyButton.UseVisualStyleBackColor = true;
            this.AddPolyButton.Click += new System.EventHandler(this.AddPolyButton_Click);
            // 
            // AddForceButton
            // 
            this.AddForceButton.Location = new System.Drawing.Point(269, 198);
            this.AddForceButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddForceButton.Name = "AddForceButton";
            this.AddForceButton.Size = new System.Drawing.Size(107, 30);
            this.AddForceButton.TabIndex = 43;
            this.AddForceButton.Text = "Add Force object";
            this.AddForceButton.UseVisualStyleBackColor = true;
            this.AddForceButton.Click += new System.EventHandler(this.AddForceButton_Click);
            // 
            // PositionYBox
            // 
            this.PositionYBox.Location = new System.Drawing.Point(368, 49);
            this.PositionYBox.Margin = new System.Windows.Forms.Padding(2);
            this.PositionYBox.Name = "PositionYBox";
            this.PositionYBox.Size = new System.Drawing.Size(25, 20);
            this.PositionYBox.TabIndex = 29;
            this.PositionYBox.Text = "400";
            this.PositionYBox.TextChanged += new System.EventHandler(this.PositionYBox_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(355, 52);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Y";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(317, 52);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "X";
            // 
            // PositionXBox
            // 
            this.PositionXBox.Location = new System.Drawing.Point(331, 49);
            this.PositionXBox.Margin = new System.Windows.Forms.Padding(2);
            this.PositionXBox.Name = "PositionXBox";
            this.PositionXBox.Size = new System.Drawing.Size(38, 20);
            this.PositionXBox.TabIndex = 26;
            this.PositionXBox.Text = "500";
            this.PositionXBox.TextChanged += new System.EventHandler(this.PositionXBox_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(266, 51);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Position:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(255, 28);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Magnitude:";
            // 
            // RadialMagnitudeBox
            // 
            this.RadialMagnitudeBox.Location = new System.Drawing.Point(317, 26);
            this.RadialMagnitudeBox.Margin = new System.Windows.Forms.Padding(2);
            this.RadialMagnitudeBox.Name = "RadialMagnitudeBox";
            this.RadialMagnitudeBox.Size = new System.Drawing.Size(76, 20);
            this.RadialMagnitudeBox.TabIndex = 23;
            this.RadialMagnitudeBox.Text = "10000";
            this.RadialMagnitudeBox.TextChanged += new System.EventHandler(this.RadialMagnitudeBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(228, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 15);
            this.label13.TabIndex = 44;
            this.label13.Text = "Enter values for a new radial force field:\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(260, 99);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 15);
            this.label14.TabIndex = 45;
            this.label14.Text = "Change uniform field:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(255, 119);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "Magnitude:";
            // 
            // UniformMagBox
            // 
            this.UniformMagBox.Location = new System.Drawing.Point(317, 116);
            this.UniformMagBox.Margin = new System.Windows.Forms.Padding(2);
            this.UniformMagBox.Name = "UniformMagBox";
            this.UniformMagBox.Size = new System.Drawing.Size(76, 20);
            this.UniformMagBox.TabIndex = 46;
            this.UniformMagBox.Text = "98";
            this.UniformMagBox.TextChanged += new System.EventHandler(this.UniformMagBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 285);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 17);
            this.label16.TabIndex = 49;
            this.label16.Text = "Information:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 306);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(284, 91);
            this.label17.TabIndex = 50;
            this.label17.Text = resources.GetString("label17.Text");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(252, 144);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 26);
            this.label18.TabIndex = 51;
            this.label18.Text = "Direction:\r\n(U, D, L, R)";
            // 
            // UniformDirectionBox
            // 
            this.UniformDirectionBox.Location = new System.Drawing.Point(317, 144);
            this.UniformDirectionBox.Margin = new System.Windows.Forms.Padding(2);
            this.UniformDirectionBox.Name = "UniformDirectionBox";
            this.UniformDirectionBox.Size = new System.Drawing.Size(76, 20);
            this.UniformDirectionBox.TabIndex = 52;
            this.UniformDirectionBox.Text = "D";
            this.UniformDirectionBox.TextChanged += new System.EventHandler(this.UniformDirectionBox_TextChanged);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Close.Location = new System.Drawing.Point(180, 250);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 53;
            this.Close.Text = "Close/Save";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // NewPolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 419);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.UniformDirectionBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.UniformMagBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AddForceButton);
            this.Controls.Add(this.PositionYBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.PositionXBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.RadialMagnitudeBox);
            this.Controls.Add(this.AddPolyButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ColourBox);
            this.Controls.Add(this.AngularAccelBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AngularVelBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AccelerationYBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AccelerationXBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ElasticityBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VelocityYBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VelocityXBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MassBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewPolygon";
            this.Text = "NewPolygon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MassBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VelocityXBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VelocityYBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ElasticityBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AccelerationYBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AccelerationXBox;
        private System.Windows.Forms.TextBox AngularVelBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AngularAccelBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ColourBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AddPolyButton;
        private System.Windows.Forms.Button AddForceButton;
        private System.Windows.Forms.TextBox PositionYBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox PositionXBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox RadialMagnitudeBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox UniformMagBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox UniformDirectionBox;
        private System.Windows.Forms.Button Close;
    }
}