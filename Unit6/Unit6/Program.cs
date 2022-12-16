// апишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)

/* int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

int[] InitArray(int dimension)
{
    Random rnd = new Random();
    int[] array = new int[dimension];

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(1,10);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] ReverseArray(int [] array)
{
    int [] result = new int[array.Length];
    int count = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[count] = array[i];
        count++;
    }
    return result;
}

int dimension = GetNumber("Введите размерность массива");
int[] array = InitArray(dimension);
PrintArray(array);

int[]result = ReverseArray(array);
PrintArray(result);

Array.Reverse(result); */


// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

/* Console.WriteLine ("Введите 3и стороны треугольника");
int A=Convert.ToInt16(Console.ReadLine());
int B=Convert.ToInt16(Console.ReadLine());
int C=Convert.ToInt16(Console.ReadLine());

if ((A<(B+C))&&(B<(A+C))&&(C<(A+B)))
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
} */

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


/* string GetBinaryFromDecimal(int decimalNumber)
{
    // 11 % 2 = 5.5 = 1
    // 5 % 2 = 2.5 = 1
    // 2 % 2 = 1 = 0
    // 1 % 2 = 0.5 = 1
    int number = decimalNumber;
    int ostatok = 0;
    string result = String.Empty;

    while (number >= 1)
    {
        ostatok = number % 2;
        number /= 2;
        if (ostatok != 0)
        {
            result += "1";
        }
        else
        {
            result += "0";
        }
    }

    return new string (result.Reverse().ToArray());
}

Console.WriteLine(GetBinaryFromDecimal(11));
Console.WriteLine(GetBinaryFromDecimal(158)); */

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

/* Console.WriteLine("Введите число n");
int N = Convert.ToInt32(Console.ReadLine());
int n1 = 0;
int n2 = 1;
Console.Write(n1 + " ");
Console.Write(n2 + " ");
int n;
for (int i = 2; i < N; i++)
{
    n = n1 + n2;
    Console.Write(n + " ");
    n1 = n2;
    n2 = n;
} */

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

