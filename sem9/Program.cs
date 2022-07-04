/* Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.   */

/* void ShowNums (int n)
{
    if(n != 1) 
        ShowNums(n-1);
    Console.Write(n + " ");  
}
ShowNums(3);    */

/* Задайте значения M и N (2 - 5). Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N (2,3,4,5).   */
/*void ShowNumsMtoN (int m, int n)
{
    if(n != m-1) 
        ShowNumsMtoN(m, n-1);
    Console.Write(n + " ");  
}
ShowNumsMtoN(3,10); */

/* Напишите программу, которая будет принимать на вход число 
и возвращать сумму его цифр.    */
/* int FindSumOfDigits(int num)
{
    if (num/10 > 0)
    {
        return FindSumOfDigits (num/10) + num%10;
    }
    return num;
}
Console.Write(FindSumOfDigits(123));    */

/* int FindSumOfDigits(int num)
{
    if (num == 0)
    {
        return 0;
    }
    return num%10 + FindSumOfDigits (num/10);
}
Console.Write(FindSumOfDigits(123));
*/

/* Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.    */

int Step (int a, int b)
{
    if(b == 0) 
        return 1;
    return a*Step(a, b-1);  
}
Console.Write(Step(5,3));



