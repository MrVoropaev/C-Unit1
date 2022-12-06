int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadNumber("Введи число: ");

for (int i = 1; i <= number; i++)
{
    Console.Write(Math.Pow(i, 2) + " ");
    //Console.Write($"{i*i*i} ");//
}
