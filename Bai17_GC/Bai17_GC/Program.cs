using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3, 4, 2 };

        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int x in numbers)
        {
            if (counts.ContainsKey(x)) counts[x]++;
            else counts[x] = 1;
        }


        int maxCount = 0;
        int mostCommonValue = 0;

        foreach (var pair in counts)
        {
            if (pair.Value > maxCount)
            {
                maxCount = pair.Value;
                mostCommonValue = pair.Key;
            }
        }


        Console.WriteLine("Danh sach: " + string.Join(", ", numbers));
        Console.WriteLine($"So xuat hien nhieu nhat la: {mostCommonValue} ({maxCount} lan)");
        Console.WriteLine("Lê Anh Quốc MSV: 2415053122234");
    }
}