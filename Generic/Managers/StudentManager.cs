using System;
using System.Linq;
using Generic.Properties.Models.Models;
using Generic.Properties.Models;

namespace Managers
{
    public class StudentManager : GenericManager<Student>
    {
        private int _idCounter = 1;

        public void AddStudent()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid age input.");
                return;
            }

            Student student = new Student { Id = _idCounter++, Name = name, Age = age };
            Add(student);
            Console.WriteLine("Student added successfully.");
        }

        public void ListStudents()
        {
            var students = GetAll();
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }
            students.ForEach(Console.WriteLine);
        }

        public void UpdateStudent()
        {
            Console.Write("Enter student ID to update: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            var student = items.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.Write("Enter new name: ");
            student.Name = Console.ReadLine();
            Console.Write("Enter new age: ");
            if (!int.TryParse(Console.ReadLine(), out int newAge))
            {
                Console.WriteLine("Invalid age input.");
                return;
            }

            student.Age = newAge;
            Console.WriteLine("Student updated successfully.");
        }

        public void DeleteStudent()
        {
            Console.Write("Enter student ID to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            var student = items.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Remove(student);
            Console.WriteLine("Student deleted successfully.");
        }
    }
}
