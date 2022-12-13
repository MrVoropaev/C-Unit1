int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 * number1 == number2)
{
    Console.WriteLine("Первое число является квадратом второго ");
}
else if (number2 * number2 == number1)
{
    Console.WriteLine("Второе число является квадратом первого ");
}
else
{
    Console.WriteLine("Числа не являются квадратми друг относительно друга");
}