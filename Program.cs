Console.WriteLine("Введите число");
string n_first = Console.ReadLine() ?? "";
int n = Convert.ToInt32(n_first);

for (int i = -n; i <= n; i++)
{
    Console.Write(i+ " ");
}