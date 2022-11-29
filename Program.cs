Console.WriteLine("Введите число");
string numberstr = Console.ReadLine() ?? "";
int number = Convert.ToInt32(numberstr);

int result = number * number;

Console.WriteLine($"Квадрат числа {number} = {result}");
