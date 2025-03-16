namespace PE_V2
{
    partial class Start
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
            this.label1 = new System.Windows.Forms.Label();
            this.PolySim = new System.Windows.Forms.Button();
            this.CircleSim = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a simulation:";
            // 
            // PolySim
            // 
            this.PolySim.Location = new System.Drawing.Point(62, 94);
            this.PolySim.Margin = new System.Windows.Forms.Padding(2);
            this.PolySim.Name = "PolySim";
            this.PolySim.Size = new System.Drawing.Size(95, 56);
            this.PolySim.TabIndex = 1;
            this.PolySim.Text = "Polygon Sim";
            this.PolySim.UseVisualStyleBackColor = true;
            this.PolySim.Click += new System.EventHandler(this.PolySim_Click);
            // 
            // CircleSim
            // 
            this.CircleSim.Location = new System.Drawing.Point(161, 94);
            this.CircleSim.Margin = new System.Windows.Forms.Padding(2);
            this.CircleSim.Name = "CircleSim";
            this.CircleSim.Size = new System.Drawing.Size(95, 56);
            this.CircleSim.TabIndex = 2;
            this.CircleSim.Text = "Circle only sim";
            this.CircleSim.UseVisualStyleBackColor = true;
            this.CircleSim.Click += new System.EventHandler(this.CircleSim_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Quit.Location = new System.Drawing.Point(121, 165);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 241);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.CircleSim);
            this.Controls.Add(this.PolySim);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PolySim;
        private System.Windows.Forms.Button CircleSim;
        private System.Windows.Forms.Button Quit;
    }
}