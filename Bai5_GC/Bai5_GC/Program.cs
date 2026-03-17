        Console.WriteLine("Lê Anh Quốc MSV: 2415053122234");
        List<string> sinhVien = new List<string> { "An", "Binh", "Chi", "Dong" };

        Console.WriteLine("Danh sach hien tai: " + string.Join(", ", sinhVien));
        Console.Write("Nhap ten sinh vien muon xoa: ");
        string tenXoa = Console.ReadLine();

        bool ketQua = sinhVien.Remove(tenXoa);

        if (ketQua)
        {
            Console.WriteLine("Da xoa thanh cong!");
            Console.WriteLine("Danh sach moi: " + string.Join(", ", sinhVien));
        }
        else
        {
            Console.WriteLine("Khong tim thay ten nay trong danh sach.");
        }