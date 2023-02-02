Console.Write("Сколько элементов Вы хотите ввести? ");
int size = int.Parse(Console.ReadLine() ?? "0");
    string[] arrayStrings = new string[size];
    int pos = 0;
for (int i = 0; i < size; i++)
    {Console.WriteLine($"Введите {i + 1}-й элемент: ");
        string element = Console.ReadLine() ?? "0";
            if (element.Length <= 3)
            {arrayStrings[pos] = element;
                pos ++;
}
}
Console.WriteLine();
void PrintArray(string[] arr)
{
    Console.WriteLine("[" + arr[0] + " ");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}
PrintArray(arrayStrings);
