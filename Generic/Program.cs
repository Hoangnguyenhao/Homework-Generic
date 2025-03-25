using System;
using Managers;

class Program
{
    static void Main()
    {
        StudentManager studentManager = new StudentManager();
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("===== QUAN LY SINH VIEN =====");
            Console.WriteLine("1 - Them sinh vien");
            Console.WriteLine("2 - Xem danh sach");
            Console.WriteLine("3 - Cap nhat thong tin");
            Console.WriteLine("4 - Xoa sinh vien");
            Console.WriteLine("5 - Thoat");
            Console.Write("\nChon: ");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            choice = keyInfo.KeyChar - '0'; 
            Console.WriteLine();

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
                    Console.WriteLine("\nThoat chuong trinh...");
                    break;
                default:
                    Console.WriteLine("\nLua chon khong hop le! Nhan phim bat ky de thu lai...");
                    Console.ReadKey();
                    break;
            }
        } while (choice != 5);
    }
}
