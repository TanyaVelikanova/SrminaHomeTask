// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите два числа");
int numberFirst = Convert.ToInt32(Console.ReadLine());
int numberSecond = Convert.ToInt32(Console.ReadLine());

int GetDegree(int numberOne, int numberTwo)
{
    int result = 1;
    for (int i = 1; i <=numberTwo; i++)
    {
        result = result*numberOne;
    }
    return result;
}   

Console.WriteLine($"Результат равен {GetDegree(numberFirst, numberSecond)}");

//Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int GetSum(int number)
{
    int sum = 0;
    int digit;

    while (number > 0)
    {
        digit = number % 10;
        number = number/10; 
        sum = sum + digit;
    }
    return sum;
} 

Console.WriteLine($"Сумма цифр в числе равна {GetSum(number)}");


//Задача 3. Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
//Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

Random rmd = new Random();

int[] array = new int[8];

int[] CreateArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rmd.Next(0, 100);
    }
    return array;
}

 void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

int[] arrayNew = CreateArray();
PrintArray(arrayNew);
