/* // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵);  2, 4 -> 16
int Stepen (int num, int step)
{
    int result = 1;
    for (int count = 1; count <= step; count++) 
    {
        result = result*num;
    }
    return result;
}
int a, b;
Console.Write ("Введите 1е число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите 2е число: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a + " в степени " + b + " = " + Stepen(a,b));
*/

/*
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]
int size = 8;
int[] array = new int [size];
for (int i = 0; i<size; i++) // сгенерир массив
{
    array[i] = new Random().Next(0, 100);
}
Console.Write("[");
for (int i = 0; i<size-1; i++) // вывести массив
{
    Console.Write(array[i] + ", ");
}
Console.Write(array[size-1] + "]");
*/