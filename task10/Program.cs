Console.Write("Введите целое трёхзначное число: ");

int number = int.Parse(Console.ReadLine() ?? "");

int num2 = (number / 10) % 10 ;
Console.WriteLine($"{number} -> {num2}");