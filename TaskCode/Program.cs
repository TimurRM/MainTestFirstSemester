
// МЕТОДЫ:

void GetArray(string[] array) // Метод ввода элементов массива с консоли
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input {i + 1} array element: ");
        array[i] = Console.ReadLine();
    }
}


