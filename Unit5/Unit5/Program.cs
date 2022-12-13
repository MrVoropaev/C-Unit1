/* Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20. */


/* получить размерность массива с консоли
int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите корректное число");
        }
    }
    return result;
}

//получить заполненный массив рандомными числами
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-20, 20);
    }

    return array;
}

//распечатать массив на консоль 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

//найти сумму положительных элементов
int GetPositiveSumm(int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            summ += array[i];
    }

    return summ;
}

//найти сумму отрицательных элементов
int GetNegativeSumm(int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            summ += array[i];
    }

    return summ;
}

/ 1й аргумент - сумма положительных, 2й аргумент - сумма отрицательных
(int, int) GetSumms(int[] array)
{
    int positiveSumm = 0;
    int negativeSumm = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            negativeSumm += array[i];
        else
            positiveSumm += array[i];
    }

    return (positiveSumm, negativeSumm);
}


int dimension = GetNumber("Введите размерность массива:");
int[] array = InitArray(dimension);
PrintArray(array);
int positiveSumm = GetPositiveSumm(array);
int negativeSumm = GetNegativeSumm(array);

(int posSum, int negSum) = GetSumms(array);

Console.WriteLine($"Сумма отрицательных: {negativeSumm}, сумма положительных: {positiveSumm}");
Console.WriteLine($"Сумма отрицательных: {negSum}, сумма положительных: {posSum}"); */

//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/* int[] Invert(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}

int[] RandomIntegers(int min, int max, int size = 10)
{
    int[] array = new int[size];
    Random r = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;
}

int[] numbers = RandomIntegers(min: -10, max: 10, size: 5);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(string.Join(" ", Invert(numbers))); */

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

/* void NumsExists(int [] array, int target)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == target)
        {
            Console.WriteLine($"Число {target} присутствует в массиве.");
            return;
        }
    }
    Console.WriteLine(" Не нашел");
}

NumsExists(array: new int[] {2, 4, 3, 1}, target: 3); */

// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

/* int[] array = new int[123];
int count=0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 1000);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
for (int j = 0; j < array.Length; j++)
{
    if(array[j] >= 10 & array[j] <= 99) 
    {
        count = count + 1;
    }
}

Console.Write($"Количество элементов массива, значения которых лежат в отрезке [10,99], = {count}"); */

// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

/* Console.WriteLine("Введите количество элементов - ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
/*int[] arrayResult = new int[array.Length / 2 + array.Length % 2]; */
/* int[] arrayResult = new int[(array.Length + 1) / 2];
Random rand = new Random();
int number = array.Length;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 10);
}
Console.WriteLine(string.Join(", ", array));

for (int i = 0; i < arrayResult.Length; i++)
{
    arrayResult[i] = array[i] * array[array.Length - 1 - i];
}
if (array.Length % 2 != 0)
{
    arrayResult[arrayResult.Length - 1] = array[array.Length / 2];
}
Console.WriteLine("произведение пар чисел в одномерном массиве ");
Console.WriteLine(string.Join(", ", arrayResult)); */