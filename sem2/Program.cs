// ClassWork
/*
// 1 - написание функции FindMaxNumber
int FindMaxNumber(int num)
{
    int dec, ed;

    if(num >= 10 && num <=99)
    {
        dec = num / 10;
        ed = num % 10;
        if ( dec > ed ) return dec;
        else return ed;
    }
    else return -1;
}

// 2 - в связке с 1 - написание программы с запросом 2-зн числа и выводом макс цифры
Console.Write("введите двузначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindMaxNumber(a);
if (result == -1) Console.Write("Ваше число не двузначное");
else Console.Write("Наибольшая цифра в вашем числе - " + result);
*/

//3 - самост 1я
/*
int RemoveMiddleDigit (int num)
{
    int FirstDigit = num / 100;
    int LastDigit = num % 10;
    int result = FirstDigit * 10 + LastDigit;
    return result;
}
int num1 = new Random().Next(100,1000);
int output = RemoveMiddleDigit (num1);
Console.WriteLine(num1 + " -> " + output);
*/

//4 - самост 2
/*
int Kratno1e2mu (int a, int b)
{
    if(a % b == 0)
    {
        return 1;
    }
    else
    {
        return 2;
    }
}
Console.Write("Введите 1е целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е целое число, меньше первого: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = Kratno1e2mu (num1, num2);
if (result == 1)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно, остаток равен " + num1%num2);
}
*/

//5 - самост 3
/* 
int num;
Console.Write("Введите целое число: ");
num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Ваше число кратно 7 и 23м");
}
else
{
    Console.WriteLine("Ваше число НЕ кратно 7 и 23м");
}
*/

/* та же задача через функцию 
int Kratnost (int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        return 1;
    }
    else
    {
        return 2;
    }
}
int num;
Console.Write("Введите целое число: ");
num = Convert.ToInt32(Console.ReadLine());
int result = Kratnost(num);
if (result == 1)
    {
        Console.WriteLine("Ваше число кратно 7 и 23м");
    }
    else
    {
        Console.WriteLine("Ваше число НЕ кратно 7 и 23м");
    }
*/