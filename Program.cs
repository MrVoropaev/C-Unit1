Console.WriteLine("Введите число");
string nstring = Console.ReadLine() ?? "";
int n = Convert.ToInt32(nstring);
if ((n>=100) && (n<=999))
    Console.WriteLine(n % 10);
else
    Console.WriteLine("Введено не верное число");

/*Console.WriteLine(n % 10);

string nstring = Console.ReadLine() ?? "";
Console.WriteLine(nstring[2]);*/



