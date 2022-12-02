
int GetRandomNumber()
{
    
    return new Random().Next(100,1000);
}
//Console.WriteLine(GetRandomNumber());

void ShowRandomNumber(int number)
{
    Console.WriteLine($"Число: {number}");
    string str = number.ToString();
    Console.WriteLine($">{str[0]}{str[2]}");
}

