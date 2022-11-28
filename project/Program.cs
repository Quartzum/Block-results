void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    string[] fill = FillArray();
    Console.WriteLine();
    PrintArray(fill);
    Console.WriteLine();
    Console.WriteLine("End");
}
string[] FillArray()
{
    string[] empty = new string[10];
    int count = empty.Length;

    for (int i = 0; i < empty.Length; i++)
    {
        Console.Write("Введите строку: ");
        empty[i] = Console.ReadLine();
        count--;
        Console.WriteLine($"Вы можете внести в таблицу {count} строк! Нажмите Enter, чтобы продолжить вводить строки.");
        if (Console.ReadKey().Key != ConsoleKey.Enter) return empty;
    }
    return empty;
}
void PrintArray(string[] fill)
{
    int count = 0;
    for (int i = 0; i < fill.Length; i++)
    {
        if (fill[i].Length == 3 || fill[i].Length < 3)
        {
            count++;
            Console.WriteLine($"На позиции {i} есть строка, где количество символов меньше или равно 3 - {fill[i]}.");
            Console.WriteLine();
        }
        else break;
    }
    if (count > 0) return;
    else Console.WriteLine("В таблице нет строк, у которых количество символов меньше или равно 3!");
}
Main();