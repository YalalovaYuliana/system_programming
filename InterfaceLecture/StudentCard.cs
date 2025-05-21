using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLecture
{
    internal class StudentCard
    {
        public int Number {  get; set; }
        public string Series { get; set; }
        public override string ToString()
        {
            return $"Student card: {Series} {Number}";
        }
    }

    class Student : IComparable, ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard StudentCard { get; set; }

        public object Clone()
        {
            return new Student()
            {
                FirstName = FirstName,
                LastName = LastName,
                BirthDate = BirthDate,
                StudentCard = new StudentCard()
                {
                    Series = this.StudentCard.Series,
                    Number = this.StudentCard.Number
                }
            };
        }

        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                return LastName.CompareTo((obj as Student).LastName);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
                return $"Имя: {FirstName}, Фамилия: {LastName}, Дата рождения: {BirthDate.ToLongDateString()}\n\t{ StudentCard}"; 
        }
    }

    class Group : IEnumerable
    {
        Student[] _students;
        public Group(params Student[] students)
        { _students = students; }

        public IEnumerator GetEnumerator()
        {
            return _students.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(_students);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(_students, comparer);
        }
    }

    class DateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                return DateTime.Compare((x as Student).BirthDate, (y as Student).BirthDate);
            }
            throw new NotImplementedException();
        }
    }
}
