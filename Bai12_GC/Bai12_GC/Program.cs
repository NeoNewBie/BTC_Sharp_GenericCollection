using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id;
    public string Name;

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        List<Student> danhSachSV = new List<Student> {
            new Student(1, "Nguyen Van An"),
            new Student(2, "Tran Thi Binh"),
            new Student(3, "Le Van An"), 
            new Student(4, "Pham Minh Hoang")
        };

        Console.Write("Nhap ten sinh vien can tim: ");
        string tenCanTim = Console.ReadLine();

        var ketQua = danhSachSV.Where(s => s.Name.Contains(tenCanTim, StringComparison.OrdinalIgnoreCase)).ToList();


        Console.WriteLine("\n--- KET QUA TIM KIEM ---");
        if (ketQua.Count > 0)
        {
            foreach (var sv in ketQua)
            {
                Console.WriteLine($"ID: {sv.Id} | Ten: {sv.Name}");
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien nao!");
        }
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Lê Anh Quốc MSV 2415053122234");
    }
}