// Методы - Есть процедуры(void) и функции(return)
//Task2();
//Task9();
//Task11();
//Task12();
//Task14();
Task16();


void Task2()
{
    // Задача 2. Даны 2 числа показать большие и меньшее число.
    Console.Clear();
    Console.Write("Введите первое число : ");
    int FirstNumber = int.Parse(Console.ReadLine()!);
    Console.Write("Введите второе число : ");
    int SecondNumber = int.Parse(Console.ReadLine()!);

    if (FirstNumber > SecondNumber)
    {
        Console.WriteLine($"Большее число : {FirstNumber}. Меньшее число {SecondNumber}. ");
    }
    else
    {
        Console.WriteLine($"Большее число : {SecondNumber}. Меньшее число {FirstNumber}. ");
    }
}

void Task9()
{
    // Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
    Console.Clear();
    Random rand = new Random();
    int number = rand.Next(10,100);
    Console.WriteLine($"Случайное число в диапазоне [10, 99] = {number}");
    int FirstNumber = number / 10;
    int SecondNumber = number % 10;

     if (FirstNumber > SecondNumber)
    {
        Console.WriteLine($"Большее число : {FirstNumber}. Меньшее число {SecondNumber}. ");
    }
    else
    {
        Console.WriteLine($"Большее число : {SecondNumber}. Меньшее число {FirstNumber}. ");
    }
}

void Task11()
{
    // Задача 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
    Console.Clear();
    Random rand = new Random();
    int number = rand.Next(100,1000);
    Console.WriteLine($"Случайное трехзначное число = {number}");
    int FirstNumber = number / 100;
    int EndNumber = number % 10;
    System.Console.WriteLine($"Было число {number}, и стало {FirstNumber}{EndNumber}");
}

void Task12()
{
    // 12. Напишите программу, которая будет принимать на вход два числа и выводить,
    // является ли второе число кратным первому. Если число 2 не кратно числу1, то программа выводит остаток от деления.
    Console.Clear();
    Console.Write("Введите первое число : ");
    int FirstNumber = int.Parse(Console.ReadLine()!);
    Console.Write("Введите второе число : ");
    int SecondNumber = int.Parse(Console.ReadLine()!);
    if (FirstNumber % SecondNumber == 0)
    {
        Console.Write($"{FirstNumber} и {SecondNumber} -> кратно ");
    }
    else
    {
        Console.Write($"{FirstNumber} и {SecondNumber} -> НЕ кратно. Остаток = {FirstNumber % SecondNumber} ");
    }
}

void Task14()
{
    // Задача 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

    Console.Clear();
    Console.Write("Введите число : ");
    int number = int.Parse(Console.ReadLine()!);
    if ((number % 7 == 0) & (number % 23 == 0))
    {
        Console.Write($"Число {number} -> кратно ");
    }
    else
    {
        Console.Write($"Число {number} -> НЕКРАТНО ");
    }
}

void Task16()
{
    // 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

    Console.Clear();
    Console.Write("Введите первое число : ");
    int FirstNumber = int.Parse(Console.ReadLine()!);
    Console.Write("Введите второе число : ");
    int SecondNumber = int.Parse(Console.ReadLine()!);

    if ((FirstNumber * FirstNumber == SecondNumber) || (SecondNumber * SecondNumber == FirstNumber))
    {
         Console.Write($"{FirstNumber}, {SecondNumber} -> ДА");
    }
    else
    {
        Console.Write($"{FirstNumber}, {SecondNumber} -> НЕТ");
    }
}



