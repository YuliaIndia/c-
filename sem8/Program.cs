// 1 - Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива

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

/*
int[,] ChangeLines (int[,] array, int lineIndex1, int lineIndex2)
{
    int temp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[lineIndex1, j];
        array[lineIndex1, j] = array[lineIndex2,j];
        array[lineIndex2, j] = temp;
    }
    return array;
}
int[,] myArray = CreateRandomTwoDimArray(4,5,1,9);
ShowTwoDimArray(myArray);
Console.WriteLine();
myArray = ChangeLines(myArray, 1, myArray.GetLength(0)-1);
ShowTwoDimArray(myArray);
*/


// 2 - Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя. транспонировать
/* int[,] TranspArray (int[,] array)
{
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
            newArray[i,j] = array[j,i];
    }
    return newArray;
}
int[,] myArray = CreateRandomTwoDimArray(4,3,1,9);
ShowTwoDimArray(myArray);
Console.WriteLine();
myArray = TranspArray(myArray);
ShowTwoDimArray(myArray);
*/

// 3 - Из двумерного массива целых чисел удалить строку и столбец (заменить нулями!), 
// на пересечении которых расположен наименьший элемент.

/* int FindMinInTwoDimArray (int[,] array)
{
    int tempi = 0;
    int tempj = 0;
    int min = array[tempi, tempj];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < min) 
            {
                min = array[i,j];
                tempi = i;
                tempj = j;
            }
        }
    }
    return min, tempi, tempj;
}
*/
int[,] ReplaceZerosInMinInTwoDimArray (int[,] array)
{
    int tempi = 0;
    int tempj = 0;
    int min = array[tempi, tempj];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < min) 
            {
                min = array[i,j];
                tempi = i;
                tempj = j;
            }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == tempi || j == tempj) 
            {
                array[i,j] = 0;
            }
        }
    }
    return array;
}
int[,] myArray = CreateRandomTwoDimArray(4,5,1,9);
ShowTwoDimArray(myArray);
Console.WriteLine();
myArray = ReplaceZerosInMinInTwoDimArray(myArray);
ShowTwoDimArray(myArray);


