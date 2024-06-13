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
    Console.Write("]");
}

string[] ThreeOrLessCharArray(string[] array)
{
    int l = 0; // l == Длинна итогового массива, чтобы избежать пустых ячеек.
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            l++;
        }
    }
    string[] result = new string[l];
    int j = 0;
    for (int i = 0; i < array.Length; i++) //да, цикл повторяется, но сначала пришлось высчитать и задать длинну масива, т.к. в С№ длинна массива не меняется динамически.
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

string[] mainArray = { "1234", "1567", "-2", "computer science" };

PrintArray(mainArray);
string[] result = ThreeOrLessCharArray(mainArray);
Console.Write(" => ");
PrintArray(result);
