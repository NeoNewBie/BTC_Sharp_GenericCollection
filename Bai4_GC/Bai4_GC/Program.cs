
        Console.WriteLine($"Lê Anh Quốc MSV: 2415053122234");
        List<int> danhSach = new List<int>();
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            danhSach.Add(int.Parse(Console.ReadLine()));
        }


        int soLuongChan = danhSach.Count(x => x % 2 == 0);

        Console.WriteLine("----------------------------");
        Console.WriteLine($"Danh sach co {soLuongChan} so chan.");

        // In ra các số chẵn đó nếu cần
        Console.Write("Cac so chan la: ");
        foreach (int so in danhSach)
        {
            if (so % 2 == 0) Console.Write(so + " ");
        }
        Console.WriteLine();
