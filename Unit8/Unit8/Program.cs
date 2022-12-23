// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

/*void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(String.Format("{0,2:0.#}", arr[i, j]));
        Console.WriteLine();
    }
}

int[,] arr =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 },
    { 5, 2, 6, 7 }
};

int[] line0 = new int[arr.GetLength(1)];
int[] line1 = new int[arr.GetLength(1)];

for (int i = 0; i < line0.Length; i++)
    line0[i] = arr[0, i];

for (int i = 0; i < line0.Length; i++)
    line1[i] = arr[arr.GetLength(0)-1, i];

PrintArray(arr);

for (int i = 0; i < line0.Length; i++)
    arr[0, i] = line1[i];
for (int i = 0; i < line0.Length; i++)
    arr[arr.GetLength(0) - 1, i] = line0[i];

Console.WriteLine();
Console.WriteLine();
PrintArray(arr);*/

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


/* void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GenerateRandomMatrix(int min, int max, int m, int n)
{
    int[,] mtrx = new int[m, n];
    Random r = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mtrx[i, j] = r.Next(min, max + 1);
        }
    }
    return mtrx;
}

int[,] Transpose(int[,] mtrx)
{
    int m = mtrx.GetLength(0);
    int n = mtrx.GetLength(1);
    int[,] result = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = mtrx[j, i];
        }
    }
    return result;
}

int[,] randMatrix = GenerateRandomMatrix(0, 9, 4, 6);
PrintMatrix(randMatrix);
PrintMatrix(Transpose(randMatrix));*/

// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

/*void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GenerateRandomMatrix(int min, int max, int m, int n)
{
    int[,] mtrx = new int[m, n];
    Random r = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mtrx[i, j] = r.Next(min, max + 1);
        }
    }
    return mtrx;
}

void CalculateNumbers (int[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    int numberOfElements = m * n;
    int number = 0;
    int count = 0;
    int total = 0;

    while (total != numberOfElements)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(matrix[i, j] == number)
                {
                    count++;
                }
            }
        }
        if(count>0)
            System.Console.WriteLine($"Число {number} встречается {count} раз;");
        total+= count;
        count = 0;
        number++;
    }
}

int[,] randMatrix = GenerateRandomMatrix(0, 100, 4, 6);
PrintMatrix(randMatrix);
CalculateNumbers(randMatrix);*/

// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.


/*Console.Clear();
Console.WriteLine($"Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.");
Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int[,] positionSmallElement = new int[1,2];
positionSmallElement = FindPositionSmallElement(array, positionSmallElement);
Console.Write($"Позиция элемента: \n");
WriteArray(positionSmallElement);

int[,] arrayWithoutLines = new int[array.GetLength(0)-1, array.GetLength(1)-1];
DeleteLines(array, positionSmallElement, arrayWithoutLines);
Console.WriteLine($"\nПолучившийся массив:");
WriteArray(arrayWithoutLines);


int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] FindPositionSmallElement(int[,] array, int[,] position)
{
  int temp = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if(array[i,j] <= temp)
      {
        position[0,0] = i;
        position[0,1] = j;
        temp = array[i,j];
      }
    }
  }
  Console.WriteLine($"\nMинимальный элемент: {temp}");
  return position;
}

void DeleteLines(int[,] array, int[,] positionSmallElement, int[,] arrayWithoutLines)
{
  int k = 0, l = 0;
for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (positionSmallElement[0,0] != i && positionSmallElement[0,1] != j)
      {
        arrayWithoutLines[k,l] = array[i,j];
        l++;
      }
    }
    l = 0;
    if (positionSmallElement[0,0] != i) 
    {
      k++;
    }
  }
}
*/
