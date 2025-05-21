using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadOperationLecture
{
    internal struct Hour
    {

        private int value;
        public Hour(int hours) => value = hours % 24;
        public override string ToString() => value.ToString();

        public static implicit operator int(Hour from) => from.value;

        public static explicit operator Hour(int from) => new Hour(from);

        public static Hour operator +(Hour h1, Hour h2) => new Hour(h1.value + h2.value);
    }
}
