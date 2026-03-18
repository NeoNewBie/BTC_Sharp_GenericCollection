using System;
using System.Collections.Generic; 
class Program
{
    static void Main()
    {
        Dictionary<string, string> tuDien = new Dictionary<string, string>();

        tuDien.Add("hello", "xin chao");
        tuDien.Add("apple", "qua tao");
        tuDien.Add("computer", "may tinh");
        tuDien.Add("program", "chuong trinh");
        tuDien.Add("student", "sinh vien");

        Console.WriteLine("----- TU DIEN ANH - VIET -----");
        Console.Write("Nhap tu tieng Anh can tra nghia: ");

        string tuCanTra = Console.ReadLine().Trim().ToLower();

        if (tuDien.ContainsKey(tuCanTra))
        {
            string nghiaTiengViet = tuDien[tuCanTra];
            Console.WriteLine($"==> Nghia cua '{tuCanTra}' la: {nghiaTiengViet}");
        }
        else
        {
            Console.WriteLine("Rat tiec, tu nay chua co trong tu dien.");
        }
        Console.WriteLine("Lê Anh Quốc MSV: 2415053122234");
    }
}