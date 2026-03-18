        
        Console.WriteLine($"Lê Anh Quốc MSV: 2415053122234");
        List<int> danhSachSo = new List<int>();

        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            int giaTri = int.Parse(Console.ReadLine());
            danhSachSo.Add(giaTri);
        }

        int tong = danhSachSo.Sum();


        Console.WriteLine("----------------------------");
        Console.WriteLine($"Tong cac phan tu trong danh sach la: {tong}");
Console.WriteLine("Lê Anh Quốc MSV: 2415053122234");