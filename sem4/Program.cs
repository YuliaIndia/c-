/* // #1 - Find Sum Of Digits
int FindSumOfDigits (int num)
{
    int sum = 0;
    while (num>0)
    {
        sum = sum+ num%10; // sum += num %10
        num = num / 10;
    }
    return sum;
}
int num;
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum of digits in your number is " + FindSumOfDigits(num));
*/

/* // #2 - Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
int FindSum1toN (int N)
{
    int sum = 0;
    int count = 1;
    while (count <= N)
    {
        sum = sum + count; 
        count ++;
    }
    return sum;
}
int num;
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum 1 to your number is " + FindSum1toN(num));
*/

/* // #3 - Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
int FindMult1toN (int N)
{
    int mult = 1;
    int count = 1;
    while (count <= N)
    {
        mult = mult * count; 
        count ++;
    }
    return mult;
}
int num;
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Factorial 1 to your number is " + FindMult1toN(num));
*/

/* // #4 - Напишите программу, которая принимает на вход число 
// и выдаёт кол-во цифр в числе.
int NumOfDigits (int N)
{
    int temp = N;
    int result = 0;
    while (temp > 0)
        {
            result ++;
            temp = temp / 10;
        }
        return result;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of digits in your number is " + NumOfDigits(num));
*/

// #5 - Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

// int[] array = {1,2,3};
int size = 8;
int[] array = new int [size];
for (int i = 0; i<size; i++) // сгенерир массив
{
    array[i] = new Random().Next(0, 2);
}

for (int i = 0; i<size; i++) // вывести массив
{
    Console.Write(array[i] + " ");
}