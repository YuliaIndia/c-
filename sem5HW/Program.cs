int[] CreateRandomArray (int size, int min, int max)
{
    int[] newArray = new int[size];
    for (int i = 0; i<size; i++)
    {
        newArray[i]=new Random().Next(min, max+1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

/* // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}
int size, min, max;
Console.Write("Enter the size of your random array: ");
size = Convert.ToInt32(Console.ReadLine());
min = 100;
max = 999;
int[] myArray = CreateRandomArray(size, min, max);
Console.WriteLine("The number of even numbers in your array is " + CountEven(myArray));
*/

/* // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. 
// [3, 7, 23, 12] -> 19;    [-4, -6, 89, 6] -> 0
int SumUnEvenPosNumbers (int[] array)
{
    int sum = 0;
    for(int i = 1; i<array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}
int size, min, max;
Console.Write("Enter desired size of random array: ");
size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter desired minimum value for your random array: ");
min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter desired maximum value for your random array: ");
max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min, max);
Console.WriteLine("Sum of Elements at UnEven positions in your array is " + SumUnEvenPosNumbers(myArray));
*/

// Задача 38: Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.  [3 7 22 2 78] -> 76

double[] CreateRandomDoubleArray (int size, double min, double max)
{
    double[] newDoubleArray = new double[size];
    for (int i = 0; i<size; i++)
    {
        newDoubleArray[i]=new Random().NextDouble()* (max - min) + min;
        Console.Write(newDoubleArray[i] + " ");
    }
    Console.WriteLine();
    return newDoubleArray;
}

double FindMinValue (double[] array) 
{
    int position = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i]<array[position]) position = i;
    }
    return array[position];
}

double FindMaxValue (double[] array)
{
    int position = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i]>array[position]) position = i;
    }
    return array[position];
}

int size;
Console.Write("Enter desired size of random array: ");
size = Convert.ToInt32(Console.ReadLine());
double min, max;
Console.Write("Enter desired minimum real number for your random array: ");
min = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter desired maximum real number for your random array: ");
max = Convert.ToDouble(Console.ReadLine());
double[] myArray = CreateRandomDoubleArray(size, min, max);
Console.WriteLine("Minimum value in the array is " + FindMinValue(myArray));
Console.WriteLine("Maximum value in the array is " + FindMaxValue(myArray));
Console.WriteLine("Difference between Maximum and Minimum values is " + (FindMaxValue(myArray) - FindMinValue(myArray)));
