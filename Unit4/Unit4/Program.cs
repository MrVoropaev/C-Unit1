// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
 //7 -> 28
 //4 -> 10
 //8 -> 36

/* Console.Clear();
 Console.WriteLine("Введите число А: ");
 int limit = int.Parse(Console.ReadLine());

 Console.WriteLine($"Результат суммы чисел от 1 до {limit} = {GetSumma(limit)}");


 int GetSumma(int limit){
     int summa =0;
     for (int i=0; i<=limit; i++) {
          summa+=i;
     }
     return summa;
 } */

 //метод, который получает число с консоли
/*int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите число больше 0.");
        }
    }

    return result;
}

//метод, который считает сумму от 1 до n
int GetSumm(int number)
{
    int summ = 0;

    for (int i = 1; i <= number; i++)
    {
        summ += i;
    }

    return summ;
}

int number = GetNumber("Введите число больше 0:");
int summ = GetSumm(number);

Console.WriteLine($"сумма чисел от 1 до {number} = {summ}");*/

// 
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Digits(int num)
 {
     int count = 0;
     while (num > 0)
     {
         num = num / 10;
         count++;
     }
     return count == 0 ? 1 : count;
 }

 if (number < 0) number = -number;
 int result = Digits(number);
 Console.WriteLine($"Количество цифр в числе {number} ---> {result}");*/


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*Console.Write("Введите число: ");
 int num = Convert.ToInt32(Console.ReadLine());

 int sum = 1;
 for (int i = 1; i <= num; i++)
 {
     sum *= i;
 }

 Console.WriteLine(sum);*/

 //Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


/* int[] numbers = new int[8];
Random rnd = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(0, 2);
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
} */

