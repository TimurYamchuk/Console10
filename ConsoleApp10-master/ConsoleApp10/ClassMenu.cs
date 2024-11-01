using System;

namespace ConsoleApp10
{
    public class ClassMenu
    {
        private AcademyGroup group = new AcademyGroup();

        public void ShowMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Добавить студента");
                Console.WriteLine("2. Удалить студента");
                Console.WriteLine("3. Показать всех студентов");
                Console.WriteLine("4. Клонировать группу");
                Console.WriteLine("5. Выйти");
                Console.Write("Выберите действие: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        RemoveStudent();
                        break;
                    case "3":
                        ShowStudents();
                        break;
                    case "4":
                        CloneGroup();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                        break;
                }
            }
        }

        private void AddStudent()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите телефон: ");
            string phone = Console.ReadLine();
            Console.Write("Введите средний балл: ");
            double average = double.Parse(Console.ReadLine());
            Console.Write("Введите номер группы: ");
            int numberOfGroup = int.Parse(Console.ReadLine());

            var student = new Student(name, surname, age, phone, average, numberOfGroup);
            group.Add(student);
        }

        private void RemoveStudent()
        {
            Console.Write("Введите фамилию студента для удаления: ");
            string surname = Console.ReadLine();
            group.Remove(surname);
        }

        private void ShowStudents()
        {
            Console.WriteLine("\nСписок студентов:");
            foreach (var student in group)
            {
                student.Print();
            }
        }

        private void CloneGroup()
        {
            var clonedGroup = (AcademyGroup)group.Clone();
            Console.WriteLine("\nКлонированная группа студентов:");
            foreach (var student in clonedGroup)
            {
                student.Print();
            }
        }
    }
}
