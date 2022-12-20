// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

/*int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    } 
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

int rows = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество столбцов:");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);*/

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

/*int[,] InitArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите размер m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размер n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = InitArray(m, n);
PrintArray(array);*/

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

/* Console.WriteLine("Задайте двумерный массив размером m x n");
Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix [i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j]+ " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            matrix[i, j] = Math.Pow(matrix[i,j], 2);
        }

        Console.Write(matrix[i, j]+ " ");
    }
    Console.WriteLine();
}*/

// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


/* Console.Clear();
 Console.Write("Введите количество строк: ");
 int rowCount = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите количество столбцов: ");
 int columnCount = Convert.ToInt32(Console.ReadLine());
 int[,] array = FillArray(rowCount, columnCount, 1, 10);
 Console.WriteLine("Начальный массив: ");
 PrintArr(array);
 int summaDiagonali = 0;


 int[,] FillArray(int rows, int columns, int min, int max)
 {
     int[,] filledArray = new int[rows, columns];
     for (int i = 0; i < rows; i++)
     {
         for (int j = 0; j < columns; j++)
         {
             filledArray[i, j] = new Random().Next(min, max + 1);
         }
     }
     return filledArray;
 };

 void PrintArr(int[,] inputArray)
 {
     for (int i = 0; i < inputArray.GetLength(0); i++)
     {
         for (int j = 0; j < inputArray.GetLength(1); j++)
         {
             Console.Write(" " + inputArray[i, j]);
         }
         Console.WriteLine();
     }
 };
 for (int i = 0; i < rowCount; i++)
 {
     for (int j = 0; j < columnCount; j++)
     {
         if (i == j) summaDiagonali = summaDiagonali + array[i, j];
     }
 };
 Console.WriteLine("Сумма диагональных элементов = " + summaDiagonali);*/
 