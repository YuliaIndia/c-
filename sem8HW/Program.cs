int[,] CreateRandomTwoDimArray (int a, int b, int min, int max)     // создать двумерный int массив
{
    int[,] newMatrix = new int[a,b]; // выделение памяти
    for (int i = 0; i < a; i++)     // по строкам
        for (int j = 0; j < b; j++) // по столбцам
            newMatrix[i,j] = new Random().Next(min,max+1);
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

/* // Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8  */

/* // Решение
int[,] SortRowsInTwoDimArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int k = 0; k < array.GetLength(1)-1-j; k++)
            {
                int temp = 0;
                if(array[i,k] > array[i,k+1])
                {
                    temp = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = temp;
                }
            }
        }
    }
    return array;
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
ShowTwoDimArray(SortRowsInTwoDimArray(myArray));
*/

/* // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка    */

/* // Решение
int FindRawWithMaxSum (int[,] array)
{
    int sum = 0;
    int[] rawSum = new int[array.GetLength(0)];  
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        rawSum[i] = sum;
        sum = 0;
    }
    int indexOfMaxRawSum = 0;
    for(int i = 1; i < rawSum.Length; i++)
    {
        if(rawSum[i]>rawSum[indexOfMaxRawSum]) indexOfMaxRawSum = i;
    }
    return indexOfMaxRawSum;
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
Console.WriteLine("The raw with the maximum sum of digits is " + (FindRawWithMaxSum(myArray)+1));
*/

/* // Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7   */

// Решение - ОТВРАТИТЕЛЬНОЕ. Не понимаю, как зациклить, кроме как прописывая каждую линию... Но понимаю, что точно можно. Бесит. 
// Давайте разберем на семинаре?
int [,] Spiral (int rows, int columns, int startNumber)
{
    int number = 0;
    number = startNumber;
    int i = 0;
    int j = 0;
    int maxNumber = rows*columns;
    int[,] array = new int[rows,columns];
// ниже начинаем 1й круг заполнения - заполнение 4х линий периметра. 
// Если бы понимала как, то хотя бы это завела в метод и внутрь вложила как рекурсию
    while (j < columns)
    {
        array [i,j] = number;
        number++;
        j++;
    }
    number = startNumber + columns;
    i++;
    j=columns-1;
    while (i<rows)
    {
        array[i,j] = number;
        i++;
        number++;
    }
    number = number + (columns-1-1);
    i=rows-1;
    j=0;
    while (j < columns-1)
    {
        array [i,j] = number;
        number--;
        j++;
    }
    number = columns+rows+(columns-1);
    j=0;
    i=rows-1-1;
    while (i>0)
    {
        array [i,j] = number;
        number++;
        i--;
    }
    i = 1;
    j = 1;
    while (j < columns - 1)
    {
        array [i,j] = number;
        number++;
        j++;
    }
    i++;
    j--;
    while (i<rows-1)
    {
        array[i,j] = number;
        i++;
        number++;
    }
    i--;
    j--;
    while (j>0)
    {
        array[i,j] = number;
        j--;
        number++;
    }
    return array;
}
int r, c, start;
Console.Write("Enter number of rows in your array: ");
r = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns in your array: ");
c = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter start value to fill your array: ");
start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Let's see, what we've got: ");
ShowTwoDimArray(Spiral(r,c,start));


/* Решение нагугленное, но я все равно не поняла, как оно работает. Думаю, мы не проходили int**, поэтому...
// #include <bits/stdc++.h>
 
void spiral(int** a, int n, int m, int d = 0, int k = 0) 
{
    int i, j;
    i = d; 
    for (int j = d; j < m - d; j++) a[i][j] = ++k;
        if (k == n * m) return;
    j = m - 1 - d;  
    for (int i = 1 + d; i < n - d; i++) a[i][j] = ++k;
        if (k == n * m) return;
    i = n - 1 - d;
    for (int j = m - 2 - d; j >= d; j--) a[i][j] = ++k;
        if (k == n * m) return;
    j = d;
    for (int i = n - 2 - d; i >= 1 + d; i--) a[i][j] = ++k;
        if (k == n * m) return;
            if (k < n * m) spiral(a, n, m, d + 1, k); 
}
 
//    using namespace std;
 
int main() 
{
    int n, m;
    cout << "Enter a matrix size:\n";
    cout << "n = ";
    cin >> n;
    cout << "m = ";
    cin >> m;
    int** a = new int* [n];
    for (int i = 0; i < n; i++) {
        a[i] = new int[m];
    }
    spiral(a, n, m);
    cout << "Target matrix:\n";
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {   
            cout.width(4);
            cout << a[i][j] << " ";
        }
        cout << "\n";
    }
    for (int i = 0; i < n; i++) {
        delete [] a[i];
    }
    delete [] a;
    system("pause");
    return 0;
}
*/