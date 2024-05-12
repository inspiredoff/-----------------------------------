// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System.Globalization;

Console.WriteLine("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

string[] InputRandomArray(int size)
{
    Random rnd = new Random();
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        int arrSize = rnd.Next(1, 15);
        string temp = string.Empty;
        for (int j = 0; j < arrSize; j++)
        {
            if (rnd.Next(1, 3) == 1)
            {
                char temps = (char)rnd.Next(32, 126);
                temp += temps;
            }
            else
            {
                int temps = rnd.Next(1, 9);
                temp += temps;
            }
        }
        array[i] = temp;
    }
    return array;
}

string[] ReformatArrayAccordingToLengthElements(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            size += 1;
        }
    }
    int j = 0;
    string [] ResArray = new string[size];
    if (size!=0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length < 4)
            {
                ResArray[j] = array[i];
                j += 1;
            }
        }    
    }
    
    return ResArray;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.Write("'" + arr[i] + "'");
        }
        else
        {
            Console.Write("'" + arr[i] + "'" + ", ");
        }
        
    }
    Console.WriteLine("]");
}

string[] InputArray = InputRandomArray(size);
Console.Write("Заданный Массив - ");
PrintArray(InputArray);
string[] OutputArray = ReformatArrayAccordingToLengthElements(InputArray);

Console.Write("Заданный Массив - ");
PrintArray(OutputArray);
