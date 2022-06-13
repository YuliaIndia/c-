/* // Задача 19 - Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да, 23432 -> да
void Palindrom (int abcde)
{
    int a, b, c, d, e;
    e = abcde % 10;
    d = (abcde /10) % 10;
    c = (abcde /100) % 10;
    b = (abcde /1000) % 10;
    a = (abcde /10000) % 10;
    if ( a==e && b==d) Console.WriteLine("It's a Palindrom!");
    else Console.WriteLine("It's not a Palindrom =((");
}
int num;
Console.WriteLine("Enter 5-digit number: ");
num = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(num) >= 100000 || Math.Abs(num) <10000 ) Console.WriteLine("Your number isn't 5-digit =(");
else Palindrom (num);
*/

/* // Задача 21 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84;     A (7,-5, 0); B (1,-1,9) -> 11.53
double FindLength(double xA, double yA, double xB, double yB, double zA, double zB)
{
   double length = Math.Sqrt((xB-xA)*(xB-xA) + (yB-yA)*(yB-yA) + (zB-zA)*(zB-zA)); //Math.Pow((yB-yA), 2)
   return length;
}
double xa, xb, ya, yb, za, zb;
Console.Write("Введите координату х точки А: ");
xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у точки А: ");
ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х точки В: ");
za = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z точки В: ");
xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у точки В: ");
yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z точки A: ");
zb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("расстояние между вашими точками равно " + FindLength(xa, ya, xb, yb, za, zb));
*/

/* // Задача 23 - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27;   5 -> 1, 8, 27, 64, 125

void Kub (int n)
{
    int index = 1;
    while (index <= Math.Abs(n))
    {
        Console.Write(index*index*index + " ");
        index++;
    }
}
int num;
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
Kub(num);
*/