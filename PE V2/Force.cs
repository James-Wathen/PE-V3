using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_V2
{
    internal class Force// force just stores data for updateAcceleration in entity, and for it to be drawn in polyform
    {
        public float Mass;
        public float[] Position;
        public bool Radial;
        public Force(float Magnitude, float[] Position, bool Radial)
        {
            this.Mass = Magnitude;
            this.Position = Position;
            this.Radial = Radial;
        }
    }
}
