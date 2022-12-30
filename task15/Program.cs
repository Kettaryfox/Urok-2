Console.Write("Введите целое число от 1 до 7: ");

int number = int.Parse(Console.ReadLine() ?? "");

if(5 < number)
    Console.WriteLine($"{number} -> да");
else
    Console.WriteLine($"{number} -> нет");