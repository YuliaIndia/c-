int[,] CreateRandomTwoDimArray (int a, int b, int min, int max)     // создать двумерный int массив
{
    int[,] newMatrix = new int[a,b]; // выделение памяти
    for (int i = 0; i < a; i++)     // по строкам
        for (int j = 0; j < b; j++) // по столбцам
            newMatrix[i,j] = new Random().Next(min,max+1);
        Console.WriteLine();
    return newMatrix;
}
void ShowTwoDimArray (int[,] array)                                 // вывести двумерный int массив
{
    for (int i = 0; i < array.GetLength(0); i++)     // по строкам
    {   for (int j = 0; j < array.GetLength(1); j++) // по столбцам
            { Console.Write(array[i,j] + " ");}
        Console.WriteLine();
    }
}

/* // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4. 
// 0,5   7   -2   -0,2
//  1   -3,3  8   -9,9
//  8   7,8  -7,1  9            */
/* // Решение
double[,] GenerateRandomRealTwoDimArray (int m, int n, double min, double max)
{
    double[,] array = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i,j] = new Random().NextDouble()* (max - min) + min;
    }
    return array;
}
void ShowTwoDimArray (double[,] array)                                 
{
    for (int i = 0; i < array.GetLength(0); i++)     // по строкам
    {    
        for (int j = 0; j < array.GetLength(1); j++) // по столбцам
        {    Console.Write(array[i,j] + " ");}
        Console.WriteLine();
    }    
}
int mm, nn;
double miin, maax;
Console.Write("Enter number of rows in your array: ");
mm = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns in your array: ");
nn = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter minimum value to fill your array: ");
miin = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter maximum value to fill your array: ");
maax = Convert.ToDouble(Console.ReadLine());
double[,] myArray = GenerateRandomRealTwoDimArray(mm, nn, miin, maax);
ShowTwoDimArray(myArray);   */

/* // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет     */
/* // Решение
void FindNumberInTwoDimArray (int[,] array, int a, int b)
{
    if (a > array.GetLength(0) || b > array.GetLength(1)) Console.WriteLine("this element doesen't exist in this array");
    Console.WriteLine("the number on this position is " + array[a-1,b-1]);
}
int mm, nn, miin, maax, x, y;
Console.WriteLine("Let's start with creating an array");
Console.Write("Enter number of rows in your array: ");
mm = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns in your array: ");
nn = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter minimum value to fill your array: ");
miin = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximum value to fill your array: ");
maax = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandomTwoDimArray(mm, nn, miin, maax);
Console.WriteLine("Let's see, what we've got: ");
ShowTwoDimArray(myArray);
Console.Write("Let's find an element in this array. Enter 1st dimension: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd dimension: ");
y = Convert.ToInt32(Console.ReadLine());
FindNumberInTwoDimArray(myArray, x, y); 
*/

/* // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.        */
/* // Решение
void AverageColInTwoDimArray (int[,] array)
{
    double[] AvCol = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            AvCol[j] += array[i,j];
        }
        AvCol[j] /= array.GetLength(0);
        Console.Write(Math.Round(AvCol[j],2) + " ");
    }
}
int mm, nn, miin, maax;
Console.WriteLine("Let's start with creating an array");
Console.Write("Enter number of rows in your array: ");
mm = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns in your array: ");
nn = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter minimum value to fill your array: ");
miin = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximum value to fill your array: ");
maax = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandomTwoDimArray(mm, nn, miin, maax);
Console.WriteLine("Let's see, what we've got: ");
ShowTwoDimArray(myArray);
Console.WriteLine();
AverageColInTwoDimArray(myArray);
*/