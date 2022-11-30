void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    string[] fill = FillArray();
    Console.WriteLine();
    string[] sort = SortArray(fill);
    PrintArray(sort);
    Console.WriteLine();
    Console.WriteLine("End");
}
string[] FillArray()
{
    string[] empty = new string[5];
    int count = empty.Length;

    for (int i = 0; i < empty.Length; i++)
    {
        Console.Write("Введите строку: ");
        empty[i] = Console.ReadLine();
        count--;
        Console.WriteLine($"Вы можете внести в таблицу {count} строк!");
    }
    return empty;
}
string[] SortArray(string[] fill)
{
    int length = 0;
    int count = 0;

    for (int i = 0; i < fill.Length; i++)
    {
        if (fill[i].Length <= 3) length++;
    }

    string[] empty = new string[length];

    for (int i = 0; i < fill.Length; i++)
    {
        if (fill[i].Length <= 3)
        {
            empty[count] = fill[i];
            count++;
        }
    }
    return empty;
}
void PrintArray(string[] sort)
{
    if (sort.Length == 0) Console.WriteLine("В таблице нет строк с символами равными или меньше 3!");
    else
    {
        Console.WriteLine("Отсортированная таблица, где строка равна или меньше 3 символов:");
        Console.WriteLine();
        for (int i = 0; i < sort.Length; i++)
        {
            Console.Write($"{sort[i]} ");
        }
    }
}
Main();