
// МЕТОДЫ:

void GetArray(string[] array) // Метод ввода элементов массива с консоли
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input {i + 1} array element: ");
        array[i] = Console.ReadLine();
    }
}

void ShowArray(string[] array) // Метод вывода элементов массива в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
        Console.Write("['" + array[i] + "', '");
        }
        else if (i < array.Length - 1)
        {
        Console.Write(array[i] + "', '");   
        }
        else
        {
        Console.Write(array[i] + "']");  
        }
        
    }
}


int SortArray(string[] array) // Метод отсортировки строк в массиве длинной более 3 символов
{
    int n = 3;
    int count = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length > n)
        {
        count--;
        }
        
    }
    return count;
}


Console.Write("Input quantity of array elements: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());


