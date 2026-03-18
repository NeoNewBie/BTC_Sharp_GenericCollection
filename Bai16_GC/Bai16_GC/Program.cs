using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Nhap mot chuoi: ");
        string input = Console.ReadLine();

        Dictionary<char, int> demKyTu = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (demKyTu.ContainsKey(c))
            {
                demKyTu[c]++;
            }
            else
            {
                demKyTu[c] = 1;
            }
        }

        Console.WriteLine("\nKet qua dem:");
        foreach (var pair in demKyTu)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
        Console.WriteLine("Lê Anh Quốc MSV: 2415053122234");
    }
}