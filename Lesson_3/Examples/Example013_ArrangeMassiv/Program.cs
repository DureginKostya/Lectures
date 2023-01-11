//Упорядочить массив по возрастанию.
Console.Clear();
int[] Massiv = {6, 8, 3, 2, 1, 4, 5, 1, 1};
void PrintMassiv(int[] Mas)
{
    int count = Mas.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(Mas[i]);
    }
    Console.WriteLine();
    Console.WriteLine();
}
int[] GetMassiv (int[] Array)
{
    int count = Array.Length;
    for (int i = 0; i < count - 1; i++)
    {
        for (int j = i + 1; j < count; j++)
        {
            if (Array[j] < Array[i])
            {
                int key = Array[i];
                Array[i] = Array[j];
                Array[j] = key;
            }
        }

    }
    return Array;
}
PrintMassiv(Massiv);
int[] ArrangeMassiv = GetMassiv(Massiv);
PrintMassiv(ArrangeMassiv);