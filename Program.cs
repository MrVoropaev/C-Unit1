Console.WriteLine("Введите число");
string nstring = Console.ReadLine() ?? "";
int n = Convert.ToInt32(nstring);

Console.WriteLine(n % 10);
