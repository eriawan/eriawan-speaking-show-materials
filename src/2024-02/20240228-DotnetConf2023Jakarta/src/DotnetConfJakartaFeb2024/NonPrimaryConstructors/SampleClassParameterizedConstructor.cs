using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonPrimaryConstructors
{
    internal class SampleClassParameterizedConstructor
    {
        public int Property1 { get; set; }
        public string? Property2 { get; set; }

        public SampleClassParameterizedConstructor(int property1, string property2)
        {
            Property1 = property1;
            Property2 = property2;
        }
    }
}
