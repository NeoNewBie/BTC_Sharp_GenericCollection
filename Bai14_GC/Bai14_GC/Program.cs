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
            new Student(101, "Nguyen Van An"),
            new Student(102, "Tran Thi Binh"),
            new Student(103, "Le Van Chi")
        };
        Console.WriteLine("Danh sach truoc khi xoa:");
        foreach (var sv in danhSachSV) Console.WriteLine($"- ID: {sv.Id}, Ten: {sv.Name}");


        Console.Write("\nNhap ID sinh vien muon xoa: ");
        if (int.TryParse(Console.ReadLine(), out int idXoa))
        {
            int soLuongDaXoa = danhSachSV.RemoveAll(s => s.Id == idXoa);
            if (soLuongDaXoa > 0)
            {
                Console.WriteLine($"==> Da xoa thanh cong sinh vien co ID: {idXoa}");
            }
            else
            {
                Console.WriteLine("==> Khong tim thay sinh vien voi ID nay.");
            }
        }
        Console.WriteLine("\nDanh sach hien tai:");
        foreach (var sv in danhSachSV) Console.WriteLine($"- ID: {sv.Id}, Ten: {sv.Name}");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Lê Anh Quốc MSV: 2415053122234");
    }
}