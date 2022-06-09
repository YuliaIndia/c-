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
int num, current;
Console.Write("введите целое число: ");
num = Convert.ToInt32(Console.ReadLine());
current = num * (-1);
while (current <= num) 
{Console.Write(current + " ");
current++; //current = current + 1
}

