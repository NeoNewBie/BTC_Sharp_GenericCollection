Console.WriteLine("Lê Anh Quốc MSV: 2415053122234");
List<int> trungLap = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
Console.WriteLine(string.Join(", ", trungLap));
List<int> duyNhat = trungLap.Distinct().ToList();
Console.WriteLine(string.Join(", ", duyNhat));