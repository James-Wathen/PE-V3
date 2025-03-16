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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();//shows buttons and items on form
        }

        private void PolySim_Click(object sender, EventArgs e)
        {
            PolyForm form1 = new PolyForm();
            form1.ShowDialog();//open an instance of the polygon simulation
        }

        private void CircleSim_Click(object sender, EventArgs e)
        {
            CircleManager form1 = new CircleManager();
            form1.ShowDialog();//open an instance of the polygon simulation
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();//quits the simulation
        }
    }
}
