using System;

namespace InheritanceLecture
{
    internal class Human
    {

        protected string name;
        protected string surname;
        protected DateTime birthday;

        public Human() { }

        public Human(string name, string surname, DateTime birthday)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
        }

        public virtual void Print() // можно будет переопределить
                                    // (заменить или расширить функционал) с помощью override в классах наследниках
        {                           // для реализации механизма позднего связывания
                                    // вызывается по типу объекта
            Console.WriteLine($"Имя: {name} {surname}\nГод рождения: {birthday.Year}");
        }

        public void Say() // вызывается по типу ссылки
        {
            Console.WriteLine("Я человек");
        }

    }
}
