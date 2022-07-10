void Square (int n) // вывести квадраты чисел от 1 до заданного
{
    int index = 1;
    while (index <= Math.Abs(n))
    {
        Console.Write(index*index + " ");
        index++;
    }
}

int FindQuart (int x, int y)    // в какую четверть попадает точка на плоскости
{
    if (x>0 && y>0) return 1;
    if (x<0 && y>0) return 2;
    if (x>0 && y<0) return 3;
    if (x<0 && y<0) return 4;
    return -1;
}

string ThirdDigit (int abcd)        // выводит третью цифру заданного числа
{
    if (Math.Abs(abcd)<100) return "третьей цифры нет";
    else 
    {
    int digitCount = (int)Math.Log10(Math.Abs(abcd)) + 1;
    double razrLishnie = digitCount - 3;
    double Base = 10;
    double delitel = Math.Pow(Base, razrLishnie);
    int Delitel = Convert.ToInt32(delitel);
    int LevSimv = Math.Abs(abcd) / Delitel;
    return $"третья цифра {LevSimv % 10}";
    }
}

void Kub (int n)        // вывести кубы чисел от 1 до заданного 
{
    int index = 1;
    while (index <= Math.Abs(n))
    {
        Console.Write(index*index*index + " ");
        index++;
    }
}

void Palindrom (int abcde)  // проверка, является ли 5-значное число палиндромом
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

double FindLength(double xA, double yA, double xB, double yB, double zA, double zB)
{
   double length = Math.Sqrt((xB-xA)*(xB-xA) + (yB-yA)*(yB-yA) + (zB-zA)*(zB-zA)); //Math.Pow((yB-yA), 2)
   return length;
}

//выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
int size = 8;       
int[] array = new int [size];
for (int i = 0; i<size; i++) // сгенерир массив
{
    array[i] = new Random().Next(0, 2);
}
for (int i = 0; i<size; i++) // вывести массив
{
    Console.Write(array[i] + " ");
}

int NumOfDigits (int N)     // выдаёт кол-во цифр в числе
{
    int temp = N;
    int result = 0;
    while (temp > 0)
        {
            result ++;
            temp = temp / 10;
        }
        return result;
}

int FindSumOfDigits (int num)       // сумма цифр в числе
{
    int sum = 0;
    while (num>0)
    {
        sum = sum+ num%10; // sum += num %10
        num = num / 10;
    }
    return sum;
}

int FindSum1toN (int N)     // выдаёт сумму чисел от 1 до N
{
    int sum = 0;
    int count = 1;
    while (count <= N)
    {
        sum = sum + count; 
        count ++;
    }
    return sum;
}

int FindMult1toN (int N)        // выдаёт произведение чисел от 1 до N
{
    int mult = 1;
    int count = 1;
    while (count <= N)
    {
        mult = mult * count; 
        count ++;
    }
    return mult;
}

int[] CreateRandomArray (int size, int min, int max)
{
    int[] newArray = new int[size];
    for (int i = 0; i<size; i++)
    {
        newArray[i]=new Random().Next(min, max+1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(int[] array)     // вывести массив
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int FindPositiveSum(int[] array)    // найти сумму положит элементов массива
{
    int sum = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i]>0) sum = sum+array[i]; //sum += array[i]
    }
    return sum;
}

int FindNegativeSum(int[] array)    // найти сумму отриц элементов массива
{
    int sum = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i]<0) sum = sum+array[i];
    }
    return sum;
}

int[] ChangeOpposit(int[] array)        //замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = array[i]*(-1);
    }
    return array;
}

void FindNumber (int[] array, int a)        //присутствует ли заданное число в массиве
{
    int count = 0;
    for(int i = 0; i<array.Length & count==0; i++)
    {
        if(array[i] == a) count++; 
    }
    if(count>0) Console.WriteLine("Your number is in array");
    else Console.WriteLine("Your number is not in array");
}

void CountNumbers (int[] array, int min, int max)       //Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if((array[i] >= min) & (array[i] <=max)) count++; 
    }
    Console.WriteLine("Number of elements in this array within " + min + " and " + max + " is " + count);
}

int CountEven(int[] array)      //количество чётных чисел в массиве
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int SumUnEvenPosNumbers (int[] array)       //сумму элементов, стоящих на нечётных позициях
{
    int sum = 0;
    for(int i = 1; i<array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

// Задача 38: Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.  [3 7 22 2 78] -> 76
double[] CreateRandomDoubleArray (int size, double min, double max)
{
    double[] newDoubleArray = new double[size];
    for (int i = 0; i<size; i++)
    {
        newDoubleArray[i]=new Random().NextDouble()* (max - min) + min;
        Console.Write(newDoubleArray[i] + " ");
    }
    Console.WriteLine();
    return newDoubleArray;
}

double FindMinValue (double[] array) 
{
    int position = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i]<array[position]) position = i;
    }
    return array[position];
}
double FindMaxValue (double[] array)
{
    int position = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i]>array[position]) position = i;
    }
    return array[position];
}

int[] ReverseArray(int[] array) // Разворот массива using FOR
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
int[] ReverseArray(int[] array) // Разворот массива using WHILE
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

int[] RunFibo(int n)        // выведите первые N чисел Фибоначчи
{
    int[] Fibo = new int [n];
    Fibo[0]=0;
    Fibo[1]=1;
    Console.Write(Fibo[0] + " " + Fibo[1] + " ");
        for (int i = 2; i < n; i++)
    {
        Fibo[i]=Fibo[i-1]+Fibo[i-2];
        Console.Write(Fibo[i] + " ");
    }
    return Fibo;
}

string BinaryNumber(int num)        //десятичное число в двоичное
{
    string result = string.Empty;
    while (num>0)
    {
        result = num%2 + result; // неявное преобразование числового num в текстовый string
        num = num/2;
    }
    return result;
}

int[,] CreateRandomTwoDimArray (int a, int b, int min, int max)     // создать двумерный int массив
{
    int[,] newMatrix = new int[a,b]; // выделение памяти
    for (int i = 0; i < a; i++)     // по строкам
        for (int j = 0; j < b; j++) // по столбцам
            newMatrix[i,j] = new Random().Next(min,max+1);
    return newMatrix;
}

void ShowTwoDimArray (int[,] array)                                 // вывести двумерный int массив
{
    for (int i = 0; i < array.GetLength(0); i++)     // по строкам
    {   for (int j = 0; j < array.GetLength(1); j++) // по столбцам
            { Console.Write(array[i,j] + " ");}
        Console.WriteLine();
    }
}

double[,] GenerateRandomRealTwoDimArray (int m, int n, double min, double max)     // создать двумерный double массив
{
    double[,] array = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().NextDouble()* (max - min) + min;
        }
    }
    return array;
}

void ShowTwoDimArray (double[,] array)                                 // вывести двумерный double массив
{
    for (int i = 0; i < array.GetLength(0); i++)     // по строкам
    {    
        for (int j = 0; j < array.GetLength(1); j++) // по столбцам
        {    Console.Write(array[i,j] + " ");}
        Console.WriteLine();
    }    
}

string[] ArrayToLower (string[] array) // смена регистра массива - в мал буквы
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i].ToLower();
    }
    return array;
}