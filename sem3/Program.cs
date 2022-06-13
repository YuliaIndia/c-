/* //Задача 1

int FindQuart (int x, int y)
{
    if (x>0 && y>0) return 1;
    if (x<0 && y>0) return 2;
    if (x>0 && y<0) return 3;
    if (x<0 && y<0) return 4;
    return -1;
}

int x, y;
Console.Write("Введите число x: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число y: ");
y = Convert.ToInt32(Console.ReadLine());
int result = FindQuart (x, y);
if (result == -1) Console.WriteLine("One of your numbers is 0");
else Console.WriteLine("This dot is in " + result + " Quarter");
*/

/* // Задача 2 - Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
void DefineRange (string chetv)
{
    if(chetv == "1") Console.WriteLine("x>0, y>0");
    if(chetv == "2") Console.WriteLine("x<0, y>0");
    if(chetv == "3") Console.WriteLine("x>0, y<0");
    if(chetv == "4") Console.WriteLine("x<0, y<0");
}
string quat;
Console.Write("Введите четверть (от 1 до 4): ");
quat = Console.ReadLine();
if (quat == "1" || quat == "2" ||quat == "3" ||quat == "4") DefineRange(quat);
else Console.WriteLine("Вы неверно указали четверть");
*/

/* // Задача 3 - Напишите программу, которая принимает на вход число (N) и выдаёт список квадратов чисел от 1 до N включительно
void Square (int n)
{
    int index = 1;
    while (index <= Math.Abs(n))
    {
        Console.Write(index*index + " ");
        index++;
    }
}
int num;
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
Square(num);
*/

/* // Задача 4
double FindLength(double xA, double yA, double xB, double yB)
{
   double length = Math.Sqrt((xB-xA)*(xB-xA) + (yB-yA)*(yB-yA)); //Math.Pow((yB-yA), 2)
   return length;
}
double xa, xb, ya, yb;
Console.Write("Введите координату х точки А: ");
xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у точки А: ");
ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х точки В: ");
xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у точки В: ");
yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("расстояние между вашими точками равно " + FindLength(xa, ya, xb, yb));
*/

