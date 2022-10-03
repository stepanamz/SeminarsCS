// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
/*
Console.Clear();
Console.WriteLine("Введите число : ");
int num = int.Parse(Console.ReadLine()!);
int itog = num * num;
Console.WriteLine($"Квадрат числа {num} = {itog}");*/

// Ветвление
/*
если (на улице дождь) // условаие
    (то возьми зонтик)  // действие 1
иначе
    (иди в сандалях) // действие 2 
*/
/*
int rain = 1; // 0 - не идет дождь ,  1 - есть дожь
if (rain == 1)
{
    System.Console.WriteLine("Возьми зонт");
}
else
{
    System.Console.WriteLine("Иди в сандалях");
}
*/

// Циклы while
// пока время ранее, можно смотреть мультики
/*
int time = 11;
while (time < 22)
{
    System.Console.WriteLine($"Еще можно смотреть мультки т.к время: {time}");
    time++;
}
System.Console.WriteLine($"Пора спать т.к время: {time}");
*/





// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

void Task1()
{
    Console.Clear();
    Console.WriteLine("Введите первое число : ");
    int A = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите второе число : ");
    int B = int.Parse(Console.ReadLine()!);

    if ((A * A) == B)
    {
        System.Console.WriteLine($"A = {A}; B = {B} -> Да");
    }
    else
    {
        System.Console.WriteLine($"A = {A}; B = {B} -> Нет");    
    }
}

// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

void Task3()
{
    Console.Clear();
    Console.WriteLine("Введите День недели : ");
    int num = int.Parse(Console.ReadLine()!);

    switch (num)  
    {
        case 1:
            System.Console.WriteLine("Понедельник");
            break;
        case 2:
            System.Console.WriteLine("Вторник");
            break;
        case 3:
            System.Console.WriteLine("Среда");
            break;
        case 4:
            System.Console.WriteLine("Четверг");
            break;
        case 5:
            System.Console.WriteLine("Пятница");
            break;
        case 6:
            System.Console.WriteLine("Суббота");
            break;
        case 7:
            System.Console.WriteLine("Воскресенье");
            break;
        default:
            System.Console.WriteLine("Неккоректное число, попробуй еще раз");
            break;
    }
}

// Функции 
//5. Напишите программу вычисления значения функции возведения числа в квадрат. // f(x)=x^2  ->  f(7)=49

void Task5(){
    Console.Clear();
    Console.WriteLine("Введите число которое необходимо возвести в квадрат : ");
    int number = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Квадрат числа {number} будет = {Power(number)}");

    int Power(int x)
    {
        return x*x;
    }
}

//6. Напишите программу, которая на вход принимает одно число (N),
//а на выходе показывает все целые числа в промежутке от -N до N.
void Task6(){
    Console.Write("Введите число : ");
    int num = int.Parse(Console.ReadLine()!); // 5
    int num2 = -num;  // -5
    while (num2 <= num)  // -5 < 5 ? да, значит заходим в цикл
    {
        Console.Write($"{num2} "); // выводит -5,-4,-3 ....
        num2++; // к -5 + 1 = -4. -4 + 1 = -3...
    }
}