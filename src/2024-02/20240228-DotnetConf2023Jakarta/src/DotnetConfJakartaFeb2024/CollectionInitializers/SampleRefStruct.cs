using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpressions
{
    internal ref struct SampleRefStruct
    {

        public SampleRefStruct()
        {
            // Create a span
            Span<char> c = ['a', 'b', 'c', 'd', 'e', 'f', 'h', 'i'];
        }
    }
}
