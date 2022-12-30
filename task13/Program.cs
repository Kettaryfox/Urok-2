Console.Write("Введите целое число: ");

int number = int.Parse(Console.ReadLine() ?? "");

if (number < 100)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else
{
    int num3 = (number /100) % 10;
    Console.WriteLine($"{number} -> {num3}");
}