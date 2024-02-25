using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonPrimaryConstructors
{
    internal class Distance
    {
        public double Magnitude { get; }

        public double Direction { get; }

        public Distance(double dx, double dy)
        {
            Magnitude = Math.Sqrt(dx * dx + dy * dy);
            Direction = Math.Atan2(dy, dx);
        }
    }
}
