
// 1 - сгенерировать 2-мерн масссив, где пользователь задает 2 числа 
// и диапазон для рандома
int[,] CreateRandomTwoDemArray (int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b]; // выделение памяти
    for (int i = 0; i < a; i++)     // по строкам
        for (int j = 0; j < b; j++) // по столбцам
            newMatrix[i,j] = new Random().Next(min,max+1);
    return newMatrix;
}
void ShowTwoDimArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)     // по строкам
        for (int j = 0; j < array.GetLength(1); j++) // по столбцам
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
}
int[,] myArray = CreateRandomTwoDemArray(4,5,1,9);
ShowTwoDimArray (myArray);


/*
// 2 - Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: 
// Aij = i+j. Выведите полученный массив на экран.
int[,] CreateRandomTwoDemArraySumIndex (int m, int n)
{
    int[,] newMatrix = new int[m,n]; // выделение памяти
    for (int i = 0; i < m; i++)     // по строкам
    {
        for (int j = 0; j < n; j++) // по столбцам
        {
            newMatrix[i,j] = i + j;
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}
int[,] array = CreateRandomTwoDemArraySumIndex(4,5);
*/

/*
// 3 - Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
int[,] CreateRandomTwoDemArrayModifyEven (int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b]; // выделение памяти
    for (int i = 0; i < a; i++)     // по строкам
    {
        for (int j = 0; j < b; j++) // по столбцам
        {
            newMatrix[i,j] = new Random().Next(min,max+1);
            if (i%2 == 0 && j%2 == 0) newMatrix[i,j] = newMatrix[i,j] * newMatrix[i,j];
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}
int[,] array = CreateRandomTwoDemArrayModifyEven(4,5,1,9);
*/

/*
// 4 - Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// важно - только для квадратных матриц!!!
int[,] CreateRandomTwoDemArraySumDiag (int a, int min, int max)
{
    int[,] newMatrix = new int[a,a]; // выделение памяти
    int sumDiag = 0;
    for (int i = 0; i < a; i++)     // по строкам
    {
        for (int j = 0; j < a; j++) // по столбцам
        {
            newMatrix[i,j] = new Random().Next(min,max+1);
            Console.Write(newMatrix[i,j] + " ");
            if (i==j) sumDiag += newMatrix[i,j];
        }
        Console.WriteLine();
    }
    Console.WriteLine("Сумма диагонали вашей матрицы равна " + sumDiag);
    return newMatrix;
}
int[,] array = CreateRandomTwoDemArraySumDiag(4,1,9);
*/


