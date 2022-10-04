Console.Clear();
//Task31();
// Task32();
//Task33();
//Task35();
Task37();



// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

void Task31()
{
    int size = 12;
    int[] array = new int[size];
    FillArrayRandom(array, -9, 9);
    PrintArray(array);
    Console.WriteLine(($"Сумма пложительных чисел = {SumPositiveArray(array)}.\nСумма отрицательных чисел = {SumNegativeArray(array)}"));
}

int SumPositiveArray(int[] array)
{
    int sum1 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum1 = sum1 + array[i];
        }

    }
    return sum1;
}

int SumNegativeArray(int[] array)
{
    int sum2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum2 = sum2 + array[i];
        }

    }
    return sum2;
}

void FillArrayRandom(int[] array, int minValue = 0, int maxValue = 100)
{
    maxValue++;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i == array.Length - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}


// Задача 32: Напишите программу замены элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.

void Task32()
{
    int size = 5;
    int[] array = new int[size];
    FillArrayRandom(array, -9, 9);
    PrintArray(array);
    ReverseArray(array);
    PrintArray(array);

}

void ReverseArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }

}



// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

void Task33()
{
    int searchNumber = 4; // Число которое нужно найти
    int size = 12;
    int[] array = new int[size];
    FillArrayRandom(array, -9, 9);
    PrintArray(array);
    FindNumberArray(array, searchNumber);
}

void FindNumberArray(int[] array, int searchNumber)
{
    bool flag = false;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == searchNumber)
        {
            flag = true;
        }

    }

    if (flag == true)
    {
        Console.WriteLine($"Число {searchNumber} - ЕСТЬ в массиве !");
    }
    else
    {
        Console.WriteLine($"Числа {searchNumber} - НЕТУ в массиве !");
    }
}

// Задача 35: Задайте одномерный массив, состоящий из случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

void Task35()
{
    int size = 12;
    int[] array = new int[size];
    FillArrayRandom(array, -100, 200);
    PrintArray(array);
    SearchEllementsArray(array);

}

void SearchEllementsArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 & array[i] < 100)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {count}");
}

//Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
void Task37()
{
    int size = 6;
    int[] array = new int[size];
    FillArrayRandom(array, 1, 10);
    PrintArray(array);
    SummaParNumbersArray(array);
}

void SummaParNumbersArray(int[] array)
{
    int count = 1;
    int firstSum = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {

     firstSum = array[i] * array[array.Length-count];
     Console.WriteLine($"{array[i]} * {array[array.Length-count]} = {firstSum}");
    count++;
    }
    if (array.Length % 2 == 1)
    {
        Console.WriteLine($"= {array[array.Length / 2]}");
    }
        
    }
    
