using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Practice
{
    internal class Pasport : IDisposable
    {
        private string number;
        public string Number
        { 
            get => number; 
            set
            {
                foreach (var item in value)
                {
                    if (!Char.IsDigit(item))
                    {
                        throw new ArgumentException("Номер паспорта должен состоять только из цифр!");
                    }
                }
                number = value;
            } 
        }
        private string name;
        public string Name 
        { 
            get => name; 
            set
            {
                foreach (var item in value)
                {
                    if (!Char.IsLetter(item))
                    {
                        throw new ArgumentException("Имя должо состоять только из букв!");
                    }
                }

                if (value.Length < 2)
                {
                    throw new Exception("Длина имени должна быть больше 2 символов!");
                }

                name = value;
            }
        }
        public DateTime Date { get; set; }

        ~Pasport() 
        {
            Console.WriteLine("Освобождение неуправляемых ресурсов");
        }

        public void Dispose()
        {
            Console.WriteLine("Освобождение управляемых ресурсов");
            GC.SuppressFinalize(this);
        }
    }
}
