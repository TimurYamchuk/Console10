using System;

namespace ConsoleApp10
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public double Average { get; set; }
        public int NumberOfGroup { get; set; }

        public Student(string name, string surname, int age, string phone, double average, int numberOfGroup)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Phone = phone;
            Average = average;
            NumberOfGroup = numberOfGroup;
        }

        public void Print()
        {
            Console.WriteLine($"Имя: {Name}, Фамилия: {Surname}, Возраст: {Age}, Телефон: {Phone}, Средний балл: {Average}, Номер группы: {NumberOfGroup}");
        }
    }
}
