// 1 Разворот массива
/* int[] ReverseArray(int[] array) // using FOR
{
    int temp;
    int j = array.Length-1;
    for(int i = 0; i < array.Length/2; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}
*/ 

/*
int[] ReverseArray(int[] array) // using WHILE
{
    int temp;
    int j = array.Length-1, i = 0;
    while(i<j)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        i++;
        j--;
    }
    return array;
}
int[] myArray = {2,3,4,5,6};
myArray = ReverseArray(myArray);
for (int i =0; i<myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
*/

/* // 2. Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины. 
// Сумма любых 2х сторон больше 3ей
bool checkTriangle (int a, int b, int c)
{
    if ((a+b)>c && (b+c)>a && (a+c)>b) return true;
    return false;
}
int a, b, c;
Console.Write("Enter length of side A of triangle: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter length of side B of triangle: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter length of side C of triangle: ");
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(checkTriangle(a,b,c));
*/

// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
int[] RunFibo(int n)
{
    int[] Fibo = new int [n];
    Fibo[0]=0;
    Fibo[1]=1;
    Console.Write(Fibo[0] + " ");
    Console.Write(Fibo[1] + " ");
    for (int i =2; i<n; i++)
    {
        Fibo[i]=Fibo[i-1]+Fibo[i-2];
        Console.Write(Fibo[i] + " ");
    }
    return Fibo;
}
int N;
Console.Write("Enter N numbers of Fibonacci: ");
N = Convert.ToInt32(Console.ReadLine());
RunFibo(N);

// 4. 

