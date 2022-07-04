/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

/* // Решение
int SumNumbersMtoN (int m, int n)
{
    if (n==m)
        return m;
    return n + SumNumbersMtoN(m, n-1);
}
int M, N;
Console.Write("Enter 1st number: ");
M=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd number: ");
N=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum of digits between your numbers is: "+SumNumbersMtoN(M,N));
*/

/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.
453 -> 3
45 -> 2 */

// Решение
int CountNumberOfDigits (int m)
{
    if(m==0)
        return 1;
    return 1 + CountNumberOfDigits(m/10);   // я пыталась тут заменить 1 на 0, но тогда вообще в итоге получаю при любом раскладе 1...
}
int M;
Console.Write("Enter few-digit number: ");
M=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of digits in your numbers is: "+ (CountNumberOfDigits(M)-1)); // поэтому пришлось тут вычитать эту единицу. 
                                                                                        // Почему так работает рекурсия - не понимаю...
                                                                                        