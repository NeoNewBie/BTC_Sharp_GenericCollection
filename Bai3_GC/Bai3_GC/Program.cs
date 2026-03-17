        Console.WriteLine($"Lê Anh Quốc MSV: 2415053122234");
        List<int> danhSach = new List<int>();

        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            danhSach.Add(int.Parse(Console.ReadLine()));
        }

        if (danhSach.Count > 0)
        {
            int soLonNhat = danhSach.Max();

 
            Console.WriteLine("----------------------------");
            Console.WriteLine($"So lon nhat trong danh sach la: {soLonNhat}");
        }
        else
        {
            Console.WriteLine("Danh sach dang trong!");
        }