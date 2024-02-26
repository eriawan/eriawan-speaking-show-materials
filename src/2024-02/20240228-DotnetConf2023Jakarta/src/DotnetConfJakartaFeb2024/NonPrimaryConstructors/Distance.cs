using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonPrimaryConstructors
{
    public readonly struct Distance
    {
        public readonly double Magnitude { get; }

        public readonly double Direction { get; }

        public Distance(double dx, double dy)
        {
            Magnitude = Math.Sqrt(dx * dx + dy * dy);
            Direction = Math.Atan2(dy, dx);
        }
    }
}
