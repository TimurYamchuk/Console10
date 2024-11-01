using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp10
{
    public class AcademyGroup : ICloneable, IEnumerable<Student>
    {
        private List<Student> students = new List<Student>();

        public void Add(Student student)
        {
            students.Add(student);
            Console.WriteLine($"Студент {student.Name} {student.Surname} добавлен.");
        }

        public void Remove(string studentSurname)
        {
            var student = students.Find(s => s.Surname.Equals(studentSurname, StringComparison.OrdinalIgnoreCase));
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine($"Студент {studentSurname} удалён из группы.");
            }
            else
            {
                Console.WriteLine($"Студент {studentSurname} не найден в группе.");
            }
        }

        public object Clone()
        {
            AcademyGroup clonedGroup = new AcademyGroup();
            foreach (var student in students)
            {
                clonedGroup.Add(new Student(student.Name, student.Surname, student.Age, student.Phone, student.Average, student.NumberOfGroup));
            }
            return clonedGroup;
        }

        public void Print()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Нет студентов в группе.");
            }
            else
            {
                foreach (var student in students)
                {
                    student.Print();
                    Console.WriteLine();
                }
            }
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return students.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
