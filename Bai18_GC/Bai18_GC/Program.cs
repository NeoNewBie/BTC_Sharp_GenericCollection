using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name;
    public double Score;

    public Student(string name, double score)
    {
        Name = name;
        Score = score;
    }
}

class Program
{
    static void Main()
    {
        List<Student> danhSach = new List<Student> {
            new Student("Nguyen Van An", 8.5),
            new Student("Tran Thi Binh", 9.2),
            new Student("Le Van Chi", 7.8),
            new Student("Pham Minh Dong", 9.5),
            new Student("Hoang Thi En", 9.2)
        };

        Console.WriteLine("\n" + new string('=', 40));
        Console.WriteLine("        DANH SACH DIEM SINH VIEN");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine($"{"Ho va Ten",-25} | {"Diem So",-10}");
        Console.WriteLine(new string('-', 40));

        foreach (var sv in danhSach)
        {
            Console.WriteLine($"{sv.Name,-25} | {sv.Score,8}");
        }
        Console.WriteLine(new string('=', 40));

        if (danhSach.Count > 0)
        {
            var thuKhoa = danhSach.OrderByDescending(s => s.Score).First();
            Console.WriteLine($"\n=> Thu khoa cua lop: {thuKhoa.Name.ToUpper()}");
            Console.WriteLine($"=> Diem cao nhat: {thuKhoa.Score}");
            Console.WriteLine("Lê Anh Quốc MSV: 2415053122234");
        }
    }
}