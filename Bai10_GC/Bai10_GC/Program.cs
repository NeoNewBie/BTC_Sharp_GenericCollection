Console.WriteLine("Lê Anh Quốc MSV: 2415053122234");
List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
Console.WriteLine(string.Join(", ", numbers));
int min = numbers.Min();
Console.WriteLine($"Gia tri nho nhat: {min}");