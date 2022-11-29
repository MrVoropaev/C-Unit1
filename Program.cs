Console.WriteLine("Введите число");
string n_first = Console.ReadLine() ?? "";
int n = Convert.ToInt32(n_first);
n = Math.Abs(n);
for (int i = -n; i <= n; i++)
{
    Console.Write(i+ " ");
}