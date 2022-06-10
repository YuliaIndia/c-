/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5,   782 -> 8,   918 -> 1 */
/* //Решение
int CutMiddleNumber (int abc)
{
    int ab = abc / 10;
    int b = ab % 10;
    return b;
}
int num;
Console.Write("Введите трехзначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if ((Math.Abs(num) <100) | (Math.Abs(num) >999)) Console.Write("Ваше число не трехзначное");
else Console.Write(" -> средняя цифра " + CutMiddleNumber(num));
*/

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.  645 -> 5,   78 -> третьей цифры нет,    32679 -> 6
*/
//Решение
/* //гуглила и тестила подсчет символов в числе
int a=123456;
int digitCount = (int)Math.Log10(a) + 1;
Console.WriteLine(digitCount);
*/
// тестила деление исходного числа в зависимости от числа знаков - передумала, решила искать, как выделить три левых символа
/* // тест отрезания левых знаков - так и не поняла, почему не пошло...
int a=123456;
string A = Convert.ToString(a);
int startIndex = 0;
int length = 3;
string B = A.SubString(startIndex, length);
//int b = Convert.ToInt32(B);
Console.WriteLine(B); 
*/

// возвращаемся к тесту деления исходного числа в зависимости от числа знаков
int a=1284567;
int digitCount = (int)Math.Log10(a) + 1;
double razrLishnie = digitCount - 3;
double Base = 10;
double delitel = Math.Pow(Base, razrLishnie);
int Delitel = Convert.ToInt32(delitel);
int LevSimv = a / Delitel;
Console.WriteLine(LevSimv % 10);

/* из гугла 
String value = "This is a string.";
int startIndex = 5;
int length = 2;
String substring = value.Substring(startIndex, length);
Console.WriteLine(substring);
*/

/*
 string ThirdDigit (int abcd)
{
    if (Math.Abs(abcd)<100) return "третьей цифры нет";
    else 
    {
    int digitCount = (int)Math.Log10(abcd) + 1;
    int bcd = Math.Abs(abcd) % 1000;
    int b = bcd % 10;
    return $"третья цифра {b}";
    }
}
int num;
Console.Write("Введите ваше число: ");
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ThirdDigit(num));
*/

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
//Решение
