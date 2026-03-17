Console.WriteLine("Lê Anh Quốc MSV: 2415053122234");
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
Console.WriteLine("Danh sach hien tai: " + string.Join(", ", numbers));
numbers.Reverse();
Console.WriteLine(string.Join(", ", numbers)); 