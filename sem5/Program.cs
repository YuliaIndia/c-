//1 Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

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
    for(int i = 0; i<array.Length; i++, j--)
    {
        Console.Write(array[i] + " ");
    }
}
/*
int FindPositiveSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i]>0) sum = sum+array[i]; //sum += array[i]
    }
    return sum;
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i]<0) sum = sum+array[i];
    }
    return sum;
}

int[] myArray = CreateRandomArray(12,-9,9);
int SumPos = FindPositiveSum(myArray);
int SumNeg = FindNegativeSum(myArray);
Console.WriteLine(SumPos +" " + SumNeg);
*/

/* // 2 Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] ChangeOpposit(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = array[i]*(-1);
    }
    return array;
}

int[] myArray = CreateRandomArray(12,-9,9);
int [] myArrayOpposite = ChangeOpposit(myArray);
ShowArray(myArrayOpposite);
*/

// 3 Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
void FindNumber (int[] array, int a)
{
    int count = 0;
    for(int i = 0; i<array.Length & count==0; i++)
    {
        if(array[i] == a) count++; 
    }
    if(count>0) Console.WriteLine("Your number is in array");
    else Console.WriteLine("Your number is not in array");
}
int[] myArray = CreateRandomArray(12,-9,9);
int num = 5;
FindNumber(myArray, num);
*/

// 4 Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
void CountNumbers (int[] array, int min, int max)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if((array[i] >= min) & (array[i] <=max)) count++; 
    }
    Console.WriteLine("Number of elements in this array within " + min + " and " + max + " is " + count);
}
int[] myArray = CreateRandomArray(12,-9,150);
int min = 10;
int max = 99;
CountNumbers(myArray, min, max);