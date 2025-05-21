using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class Increment
    {
        public static string Value = "NameSpace A";
    }
}


namespace B
{
    internal class Increment
    {
        public static string Value = "NameSpace B";
    }
}

namespace C
{
    namespace D
    {
        internal class Increment
        {
            public static string Value = "NameSpace C.D";
        }
    }

    namespace D
    {
        internal class Increment2
        {
            public static string Value = "NameSpace C.D";
        }
    }
}
