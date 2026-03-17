        Console.WriteLine("Lê Anh Quốc MSV: 2415053122234");
        List<int> numbers = new List<int>();
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap so thu {i + 1}: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }


        numbers.Sort();

        Console.WriteLine("----------------------------");
        Console.WriteLine("Danh sach sau khi sap xep tang dan:");
        foreach (int x in numbers)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();

   