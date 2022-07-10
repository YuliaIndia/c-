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
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
string[] ArrayToLower (string[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i].ToLower();
    }
    return array;
}
/* Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов
 в массиве, начинающихся на гласную букву.
Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1   */
/* int NumberOfWordsStartingWithVowels (string[] array)
{
    int count = 0;  // A, E, I, O, U, Y
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i][0] == 'a' ||  array[i][0] == 'e' || array[i][0] == 'i' || 
        array[i][0] == 'o' ||  array[i][0] == 'u' || array[i][0] == 'y') count++;
    }
    return count;
}
Console.Write("Input length of string array: ");
int size1 = Convert.ToInt32(Console.ReadLine());
string[] myArray1 = CreateStringArray(size1);
Console.WriteLine("The number of words in your array starting with vowels is " + 
NumberOfWordsStartingWithVowels(ArrayToLower(myArray1)));
*/

/* Задача 2: Задайте массив строк. Напишите программу, которая генерирует 
новый массив, объединяя элементы исходного массива попарно.
Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> 
        { "qwewer", "ertrty", "tyuyui"}     */
string[] PairCombine (string[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size = size+1;
    string[] newArray = new string [size];
    if (array.Length % 2 == 1) newArray[size-1] = array[array.Length-1];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i*2] + array[i*2+1];
    }
    return newArray;
}
Console.Write("Input length of string array: ");
int size1 = Convert.ToInt32(Console.ReadLine());
string[] myArray1 = CreateStringArray(size1);
Console.WriteLine();
Console.WriteLine("Paired combined array is: ");
ShowArray(PairCombine(myArray1));
