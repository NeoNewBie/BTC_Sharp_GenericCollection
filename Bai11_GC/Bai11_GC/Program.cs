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

        List<Student> danhSachSV = new List<Student>();


        Student sv1 = new Student(101, "Nguyen Van An");
        danhSachSV.Add(sv1);
        danhSachSV.Add(new Student(102, "Tran Thi Binh"));
        danhSachSV.Add(new Student(103, "Le Van Chi"));


        Console.WriteLine("----- DANH SACH SINH VIEN -----");
        Console.WriteLine("{0,-10} {1,-20}", "ID", "Ho va Ten"); 
        Console.WriteLine("-------------------------------");

        foreach (Student sv in danhSachSV)
        {
            Console.WriteLine("{0,-10} {1,-20}", sv.Id, sv.Name);
        }

        Console.WriteLine("-------------------------------");
        Console.WriteLine("Lê Anh Quốc MSV: 2415053122234");
    }

}