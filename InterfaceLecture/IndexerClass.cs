using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLecture
{
    public enum Numbers { one,  two, three, four, five };
    interface IIndexer
    {
        string this[int index] { get; set; }
        string this[string index] { get; }
    }

    class IndexerClass : IIndexer
    {
        string[] _names = new string[5];
        public string this[int index]
        {
            get { return _names[index]; }
            set { _names[index] = value; }
        }

        public string this[string index]
        { 
            get
            {
                if (Enum.IsDefined(typeof(Numbers), index))
                {
                    return _names[(int)Enum.Parse(typeof(Numbers), index)];
                }
                else
                {
                    return "";
                }
            }
        }

        public IndexerClass()
        {
            this[0] = "Bob"; this[1] = "Candice"; this[2] = "Jimmy";
            this[3] = "Joye"; this[4] = "Nicole";
        }
    }
}
