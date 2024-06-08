// Задача: Написать программу,
// которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System.Globalization;
using System.Reflection;

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write("] => ");
}

string[] ThreeOrLessCharArray(string[] array)
{
    string[] result = new string[array.Length]; //) new string[] {} | System.Array.Empty<string>()
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[i] = array[i];
        }
    }
   
    Console.Write("[");
     for (int i = 0; i < result.Length; i++)
    {
        if (i < result.Length - 1)
            Console.Write($"{result[i]}, ");
        else
            Console.Write($"{result[i]}");
    }
    Console.Write("]");
     return result;
}

string[] mainArray = {"1234", "1567", "-2", "computer science"};

PrintArray(mainArray);
ThreeOrLessCharArray(mainArray);
