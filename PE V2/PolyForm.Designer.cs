using System.Drawing;
using System.Windows.Forms;
using System;

namespace PE_V2
{
    partial class PolyForm
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
            this.Quit = new System.Windows.Forms.Button();
            this.AddPolygon = new System.Windows.Forms.Button();
            this.CollisionCheck = new System.Windows.Forms.CheckBox();
            this.Paused = new System.Windows.Forms.CheckBox();
            this.Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Gravity = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Quit.Location = new System.Drawing.Point(722, 662);
            this.Quit.Margin = new System.Windows.Forms.Padding(2);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(56, 19);
            this.Quit.TabIndex = 0;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // AddPolygon
            // 
            this.AddPolygon.Location = new System.Drawing.Point(366, 658);
            this.AddPolygon.Margin = new System.Windows.Forms.Padding(2);
            this.AddPolygon.Name = "AddPolygon";
            this.AddPolygon.Size = new System.Drawing.Size(43, 23);
            this.AddPolygon.TabIndex = 1;
            this.AddPolygon.Text = "Add";
            this.AddPolygon.UseVisualStyleBackColor = true;
            this.AddPolygon.Click += new System.EventHandler(this.AddPolygon_Click);
            // 
            // CollisionCheck
            // 
            this.CollisionCheck.AutoSize = true;
            this.CollisionCheck.Checked = true;
            this.CollisionCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CollisionCheck.Location = new System.Drawing.Point(503, 662);
            this.CollisionCheck.Margin = new System.Windows.Forms.Padding(2);
            this.CollisionCheck.Name = "CollisionCheck";
            this.CollisionCheck.Size = new System.Drawing.Size(64, 17);
            this.CollisionCheck.TabIndex = 2;
            this.CollisionCheck.Text = "Collision";
            this.CollisionCheck.UseVisualStyleBackColor = true;
            // 
            // Paused
            // 
            this.Paused.AutoSize = true;
            this.Paused.Location = new System.Drawing.Point(568, 662);
            this.Paused.Margin = new System.Windows.Forms.Padding(2);
            this.Paused.Name = "Paused";
            this.Paused.Size = new System.Drawing.Size(62, 17);
            this.Paused.TabIndex = 3;
            this.Paused.Text = "Paused";
            this.Paused.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(9, 658);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(56, 19);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 643);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click for details on adding objects:";
            // 
            // Gravity
            // 
            this.Gravity.AutoSize = true;
            this.Gravity.Checked = true;
            this.Gravity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Gravity.Location = new System.Drawing.Point(635, 662);
            this.Gravity.Name = "Gravity";
            this.Gravity.Size = new System.Drawing.Size(59, 17);
            this.Gravity.TabIndex = 7;
            this.Gravity.Text = "Gravity";
            this.Gravity.UseVisualStyleBackColor = true;
            // 
            // PolyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 691);
            this.Controls.Add(this.Gravity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Paused);
            this.Controls.Add(this.CollisionCheck);
            this.Controls.Add(this.AddPolygon);
            this.Controls.Add(this.Quit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PolyForm";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PolyForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Quit;
        private Button AddPolygon;
        public CheckBox CollisionCheck;
        public CheckBox Paused;
        private Button Clear;
        private Label label1;
        public CheckBox Gravity;
    }
}

