//Упорядочить массив по убыванию.
Console.Clear();
int[] Massiv = {6, 8, 3, 2, 1, 4, 5, 1, 1};
void PrintMassiv(int[] Mas)
{
    for (int i = 0; i < Mas.Length; i++)
    {
        Console.Write(Mas[i]);
    }
    Console.WriteLine();
    Console.WriteLine();
}
int[] GetMassiv (int[] Array)
{
    for (int i = Array.Length - 1; i > 0; i--)
    {
        for (int j = i - 1; j >= 0; j--)
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
