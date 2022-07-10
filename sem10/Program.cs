// 1
string[] CreateStringArray(int size)
{
    string[] words = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} words: ");
        words[i] = Console.ReadLine();
    }
    return words;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine();
}

int NumberOfWords(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length >=5) count++;
    }
    return count;
}
// string[] names = {"Ivan", "Anna", "Max", "Denis"};
/* Console.Write("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] names = CreateStringArray(size);
Console.WriteLine("Number of words longer than 5 charts is " + NumberOfWords(names));
*/

/* 2 - Написать программу, которая принимает на вход два массива строк 
и возвращает массив из попарно объединенных исходных элементов.
*/
string[] MergeTwoStringArrays(string[] array1, string[] array2) // better solution, for arrays of different lengths
{
    int maxsize = array1.Length;
    if (array2.Length > array1.Length) maxsize = array2.Length;
    string[] words = new string[maxsize];
    if (array1.Length < array2.Length) 
    {
        words = array2;
        for (int i = 0; i < array1.Length; i++)
            words[i] = array1[i] + " " + words[i];
    }
    else
    {
        words = array1;
        for (int i = 0; i < array2.Length; i++)
            words[i] = words[i] + " " + array2[i];
    }
    return words;
}
Console.Write("Input length of 1st array: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input length of 2nd array: ");
int size2 = Convert.ToInt32(Console.ReadLine());
string[] myArray1 = CreateStringArray(size1);
string[] myArray2 = CreateStringArray(size2);
Console.WriteLine();
ShowArray(MergeTwoStringArrays(myArray1, myArray2));

/*
string[] MergeTwoStringArrays(int size, string[] array1, string[] array2)
{
    string[] words = new string[size];
    for (int i = 0; i < size; i++)
    {
        words[i] = array1[i]+" "+array2[i];
    }
    return words;
}
Console.Write("Input length of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myArray1 = CreateStringArray(size);
string[] myArray2 = CreateStringArray(size);
ShowArray(MergeTwoStringArrays(size, myArray1, myArray2));
*/

/* 3 - Написать программу, которая считает кол-во слов, 
начинающихся на букву Y или W.
*/
/*
int NumberOfWordsStartingWith(char symbol1, char symbol2, string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if((array[i][0] == symbol1) || (array[i][0] == symbol2)) count++;
    }
    return count;
}
string[] ArrayToLower (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i].ToLower();
    }
    return array;
}
// string[] names = {"Ivan", "Anna", "Max", "Denis"};
Console.Write("Input length of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 1st symbol you're searching: ");
char symb1 = Convert.ToChar(Console.ReadLine());
Console.Write("Input 1st symbol you're searching: ");
char symb2 = Convert.ToChar(Console.ReadLine());
string[] names = CreateStringArray(size);
Console.WriteLine("Number of words starting with your symbols is " + NumberOfWordsStartingWith(symb1,symb2, ArrayToLower(names)));
*/

/*
Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов
 в массиве, начинающихся на гласную букву.
Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

Задача 2: Задайте массив строк. Напишите программу, которая генерирует 
новый массив, объединяя элементы исходного массива попарно.
Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
*/