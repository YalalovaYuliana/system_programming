using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndexerClass indexer = new IndexerClass();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(indexer[i]);
            }
            foreach (string item in Enum.GetNames(typeof(Numbers)))
            {
                Console.WriteLine(indexer[item]);
            }

            Student[] students = {
                new Student() {
                    FirstName ="John",
                    LastName ="Miller",
                    BirthDate =new DateTime(2005,3,12),
                    StudentCard =new StudentCard()
                    {
                        Number=189356,
                        Series="AB"
                    }
                },
                new Student() {
                    FirstName ="Candice",
                    LastName ="Leman",
                    BirthDate =new DateTime(2006,7,22),
                    StudentCard = new StudentCard() 
                    {
                        Number=345185,
                        Series="XA" 
                    }
                }
            };  
            
            Group group = new Group(students);
            group.Sort();
            group.Sort(new DateComparer());
            Console.WriteLine("\n++++++++++ student list ++++++++++\n");
            foreach (Student student in group)
            {
                Console.WriteLine(student);
            }

            Student student1 = new Student
            {
                FirstName = "Greg",
                LastName = "Carter",         
                BirthDate = new DateTime(2006, 12, 5),
                StudentCard = new StudentCard
                {
                    Number = 784523,
                    Series = "MM"
                }
            };
            Student student2 = (Student)student1.Clone();
            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine("\n++++++++++ изменение +++++++++++++\n");
            student2.FirstName = "Leon";
            student2.StudentCard.Number = 817423;
            student2.StudentCard.Series = "КК";
            Console.WriteLine(student1);
            Console.WriteLine(student2);


            Child child1 = new Child
            {
                Name = "Arthur",
                Age = 12
            };
            Child child2 = (Child)child1.Clone();

            Console.WriteLine(child1);
            Console.WriteLine(child2);

            child2.Age = 14;


            Console.WriteLine(child1);
            Console.WriteLine(child2);
        }
    }
}
