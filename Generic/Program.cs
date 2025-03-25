using System;
using Managers;

class Program
{
    static void Main()
    {
        StudentManager studentManager = new StudentManager();

        while (true)
        {
            Console.WriteLine("\n=== He Thong Quan Ly Sinh Vien ===");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Danh sach sinh vien");
            Console.WriteLine("3. Cap nhat sinh vien");
            Console.WriteLine("4. Xoa sinh vien");
            Console.WriteLine("5. Thoat");
            Console.Write("Chon mot tuy chon: ");


            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    studentManager.AddStudent();
                    break;
                case 2:
                    studentManager.ListStudents();
                    break;
                case 3:
                    studentManager.UpdateStudent();
                    break;
                case 4:
                    studentManager.DeleteStudent();
                    break;
                case 5:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
