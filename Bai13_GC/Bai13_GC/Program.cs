using System;
using System.Collections.Generic;

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
            new Student(3, "Le Van Chi")
        };

        foreach (Student sv in danhSachSV)
        {
            // Sử dụng cấu trúc {biến, -độ_rộng} để căn lề trái
            Console.WriteLine($"{sv.Id,-10} | {sv.Name,-20}");
        }
        // 2. Sử dụng thuộc tính .Count để đếm
        int tongSoSinhVien = danhSachSV.Count;

        // 3. In kết quả
        Console.WriteLine($"==> Tong so sinh vien hien co: {tongSoSinhVien}");
        Console.WriteLine("Lê Anh Quốc MSV: 2415053122234");
    }
}