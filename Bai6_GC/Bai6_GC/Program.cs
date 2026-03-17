        Console.WriteLine("Lê Anh Quốc MSV: 2415053122234");
        List<string> traiCay = new List<string> { "Tao", "Chuoi", "Cam", "Xoai" };
        Console.WriteLine("Danh sach hien tai: " + string.Join(", ", traiCay));
        Console.Write("Nhap ten trai cay can tim: ");
        string timKiem = Console.ReadLine();

        if (traiCay.Contains(timKiem))
        {
            Console.WriteLine($"{timKiem} co ton tai trong danh sach.");
        }
        else
        {
            Console.WriteLine($"{timKiem} khong co trong danh sach.");
        }