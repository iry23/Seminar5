//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] RandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomArray(size);
ShowArray(myArray);

int evenNumbersArray(int[] array)
{
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            current++;
    }
    return current;
}
int result = evenNumbersArray(myArray);
Console.WriteLine("Number of even numbers is " + result);
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int[] RandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int SumOfOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomArray(size, min, max);
ShowArray(myArray);
int result = SumOfOddPositions(myArray);
Console.WriteLine("Sum of odd-position elements is " + result);
*/
//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] realNumbersArray = new double[size];
for (int i = 0; i < realNumbersArray.Length; i++)
{
    realNumbersArray[i] = new Random().Next(1, 100);
    Console.Write(realNumbersArray[i] + " ");
}

double max = realNumbersArray[0];
double min = realNumbersArray[0];

for (int i = 1; i < realNumbersArray.Length; i++)
{
    if (max < realNumbersArray[i])
    {
        max = realNumbersArray[i];
    }
    if (min > realNumbersArray[i])
    {
        min = realNumbersArray[i];
    }
}
double difference = max - min;
Console.WriteLine();
Console.WriteLine($"Difference between {max} and {min} is {difference}");
*/