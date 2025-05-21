using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class Park : IEnumerable
    {
        public Transport[] Transports { get; set; }

        public IEnumerator GetEnumerator()
        {
            return Transports.GetEnumerator();
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
        public abstract int CompareTo(object obj);
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

        public override int CompareTo(object obj)
        {
            throw new NotImplementedException();
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

        public override int CompareTo(object obj)
        {
            throw new NotImplementedException();
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

        public override int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
