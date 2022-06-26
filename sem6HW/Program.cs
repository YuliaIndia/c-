void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
} 

// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2;        1, -7, 567, 89, 223-> 3
/*
int CountPositiveNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) count++;
    }
    return count;
}
int M;
Console.Write("Enter the number of numbers you want to input in your array: ");
M = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[M];
for (int i = 0; i < M; i++)
{
    Console.Write("Enter your "+ (i+1) +" number: ");
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine("You have " + CountPositiveNumbers(myArray) + " positive number(s) in your array");
*/

// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

