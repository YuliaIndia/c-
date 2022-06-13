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