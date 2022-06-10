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
int RemoveMiddleDigit () // int num в скобках писать не надо для рандомного примера
{
    int num = new Random().Next(100,1000); // тогда перенесем сюда эту рандомную ф-ю
    Console.WriteLine(num); // добавляем, чтобы в консоль вывести число, которое мы сгенерили
    int FirstDigit = num / 100;
    int LastDigit = num % 10;
    int result = FirstDigit * 10 + LastDigit;
    return result;
}
Console.WriteLine(" -> " + RemoveMiddleDigit ()); // поскольку мы в ф-ии писали случайное число
*/

//4 - самост 2
/*
string Kratno1e2mu (int a, int b) // для разнообразия заменили инт на стринг
{
    if(a % b == 0)
    {
        return "кратно";
    }
    else
    {
        return "не кратно, остаток " + (a%b);
    }
}
Console.Write("Введите 1е целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е целое число, меньше первого: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Kratno1e2mu (num1, num2));
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

// та же задача через функцию   // буллеву!!!
bool Kratnost (int a)
{
    if (a % 7 == 0 && a % 23 == 0) return true;
    else return false;
}
int num;
Console.Write("Введите целое число: ");
num = Convert.ToInt32(Console.ReadLine());
bool result = Kratnost(num);
if (result == true) Console.WriteLine("Ваше число кратно 7 и 23м");
else Console.WriteLine("Ваше число НЕ кратно 7 и 23м");
