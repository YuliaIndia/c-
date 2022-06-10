// 1
// int A;
// A = 3;
// Console.WriteLine("my number is " + A + " and it's cool");

//2
//int number, result;
//Console.Write("введите целое число: ");
//number = Convert.ToInt32(Console.ReadLine());
//result = number * number;
//Console.WriteLine("Квадрат вашего числа равен " + result);

//2.2
/*
int number;
Console.Write("введите целое число: ");
number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Квадрат вашего числа равен " + (number * number));
*/

//3
/*
int num1, num2;
Console.Write("введите 1е целое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 2е целое число: ");
num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2) 
{Console.WriteLine("Квадрат 2го числа равен первому");}
else 
{Console.WriteLine("Квадрат 2го числа НЕ равен первому");}
*/

//4
/*
int num, current;
Console.Write("введите целое число: ");
num = Convert.ToInt32(Console.ReadLine());
current = num * (-1);
while (current <= num) 
{Console.Write(current + " ");
current++; //current = current + 1
}
*/

// HOMETASK
/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее. a = 5; b = 7 -> max = 7; a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка). 4 -> да; -3 -> нет; 7 -> нет

Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N. 5 -> 2, 4; 8 -> 2, 4, 6, 8
*/

//HW-2
/*
int num1, num2;
Console.Write("введите 1е целое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 2е целое число: ");
num2 = Convert.ToInt32(Console.ReadLine());
if ( num1 > num2 )
{   Console.Write("max = " + num1);}
else
{   Console.Write("max = " + num2);}
*/

//HW-4
/*
int num1, num2, num3, max;
max = 0;
Console.Write("введите 1е целое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 2е целое число: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 3е целое число: ");
num3 = Convert.ToInt32(Console.ReadLine());
if ( num1 > num2 )
{   max = num1;
    if ( max > num3)
    {Console.Write("max = " + max);}
    else 
    {max = num3;
    Console.Write("max = " + max);}
}
else
{  max = num2;
    if ( max > num3)
    {Console.Write("max = " + max);}
    else 
    {max = num3;
    Console.Write("max = " + max);}
}
*/
//HW-6
/*
int num, left;
left = 0;
Console.Write("введите целое число: ");
num = Convert.ToInt32(Console.ReadLine());
left = num % 2;
if (left == 0)
{Console.Write("четное");}
else {Console.Write("нечетное");}
*/

//HW=8
/*
int num, i;
i = 2;
Console.Write("введите целое число больше 1: ");
num = Convert.ToInt32(Console.ReadLine());
if ( num <= 1 )
{Console.Write("вы ввели маленькое число. Пожалуйста, введите целое число БОЛЬШЕ 1: ");
num = Convert.ToInt32(Console.ReadLine());}
else {}
while ( i <= num )
{Console.Write( i + " ");
i = i + 2;
}
*/