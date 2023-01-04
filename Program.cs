Console.Clear();
Console.WriteLine("--Итоговая проверочная работа--");
string[] ArrayString = GetArrayRandom(10, 1, 6);
PrintArray(ArrayString);
Console.Write("Введите пороговое значение символов:");
int CountStr = int.Parse(Console.ReadLine()!);
int LengthArrayLimit = ArrayCountLimit(ArrayString, CountStr);
if (LengthArrayLimit > 0)
{
    Console.WriteLine($"Всего элементов удовлетворяющих условию {LengthArrayLimit}");
    string[] ArrayLimit = GetArrayRandomLimit(ArrayString, CountStr,LengthArrayLimit);
    PrintArray(ArrayLimit);
}
else Console.Write("Нет данных удовлетворяющих условию");

string[] GetArrayRandomLimit(string[] array, int Limit, int LengthArrayLimit)
{
    string[] arrayLimit = new string[LengthArrayLimit];
    int cur_id1 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= Limit)
        {
            arrayLimit[cur_id1] = array[i];
            cur_id1++;
        };
    }
    return arrayLimit;
}

int ArrayCountLimit(string[] array, int Limit)
{
    int Count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= Limit) Count++;
    }
    return Count;
}

string[] GetArrayRandom(int N, int minStr, int maxStr)
{
    string[] array = new string[N];
    for (int i = 0; i < array.Length; i++)
    {
        int count = new Random().Next(minStr, maxStr+1);
        for (int j = 0; j < count; j++)
        {
            array[i] = array[i] + Convert.ToChar(new Random().Next(65, 122));
        }
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
    Console.WriteLine("]");
}
