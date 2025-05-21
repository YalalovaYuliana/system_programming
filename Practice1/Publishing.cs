using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Publishing
    {
        public Journal[] journals;

        public Journal this[int index]
        {
            get
            {
                if (index >= 0 && index < journals.Length)
                {
                    return journals[index];
                }
                throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < journals.Length)
                {
                    journals[index] = value;
                }
                throw new ArgumentOutOfRangeException();
            }
        }

        public Journal this[string name]
        {
            get
            {
                int index = FindByName(name);
                if (index >= 0)
                {
                    return journals[index];
                }
                throw new Exception("Журнала с таким именем нет");
            }
            set
            {
                int index = FindByName(name);
                if (index >= 0)
                {
                    journals[index] = value;
                }
                throw new Exception("Журнала с таким именем нет");
            }
        }

        int FindByName(string name)
        {
            for (int i = 0; i < journals.Length; i++)
            {
                if (journals[i].Name == name) return i;
            }
            return -1;
        }
    }
}
