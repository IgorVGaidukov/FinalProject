// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

int size = 0;

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.WriteLine($"{inArray[i]} ");
    }
}

while (size <= 0)
{
    Console.Write("Введите размер массива: ");
    size = int.Parse(Console.ReadLine());
}

string[] array = new string[size];

for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива {i}: ");
    array[i] = Console.ReadLine();
}

int size2 = 0;

for (int i = 0; i < size; i++)
    if (array[i].Length <= 3) size2++;

if (size2 > 0)
{
    string[] array2 = new string[size2];
    int j = 0;

    for (int i = 0; i < size; i++)
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        }

    Console.WriteLine("Элементы массива длиной <= 3:");
    PrintArray(array2);
}
else
{
    Console.WriteLine("Нет элементов массива длиной <= 3");
}