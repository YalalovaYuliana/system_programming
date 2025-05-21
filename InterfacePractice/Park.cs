using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class LoadCapacityComparer : IComparer<Transport>
    {
        int GetLoadOpacity(Transport transport)
        {
            if (transport is Truck)
            {
                return (transport as Truck).LoadCapacity;
            }
            if (transport is PassengerCar)
            {
                return 200;
            }
            if (transport is Motorcycle)
            {
                return (transport as Motorcycle).IsHasSidecar ? 50 : 0;
            }
            return 0;
        }
        public int Compare(Transport x, Transport y)
        {
            return GetLoadOpacity(x).CompareTo(GetLoadOpacity(y));      
        }
    }
    class Park : IEnumerable
    {
        public Transport[] Transports { get; set; }

        public Park(Transport[] transports)
        {
            Transports = transports;
        }

        public override string ToString()
        {
            return Transports.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            return Transports.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(Transports);
        }
        public void Sort(IComparer<Transport> comparer)
        {
            Array.Sort(Transports, comparer);
        }
    }
    abstract class Transport : IComparable, ICloneable 
    {
        public string Mark {  get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }

        protected Transport(string mark, string number, int speed)
        {
            Mark = mark;
            Number = number;
            Speed = speed;
        }

        public abstract object Clone();
        public int CompareTo(object obj)
        {
            if (obj is Transport)
            {
                return Speed.CompareTo((obj as Transport).Speed);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"[{GetType().Name}] {Mark} ({Number}) {Speed} км/ч";
        }
    }

    class PassengerCar : Transport 
    {
        public PassengerCar(string mark, string number, int speed) : base(mark, number, speed)
        {
        }

        public override object Clone()
        {
            return MemberwiseClone();
        }
    }

    class Truck : Transport
    {
        public int LoadCapacity { get; set; }
        public Truck(string mark, string number, int speed, int loadCapacity) : base(mark, number, speed)
        {
            LoadCapacity = loadCapacity;
        }

        public override object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return base.ToString() + $" {LoadCapacity} кг";
        }
    }

    class Motorcycle : Transport
    {
        public bool IsHasSidecar { get; set; }
        public Motorcycle(string mark, string number, int speed, bool isHasSidecar) : base(mark, number, speed)
        {
            IsHasSidecar = isHasSidecar;
        }

        public override object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            string isHasSidecar = IsHasSidecar ? " с коляской" : " без коляски";
            return base.ToString() + isHasSidecar;
        }
    }
}
