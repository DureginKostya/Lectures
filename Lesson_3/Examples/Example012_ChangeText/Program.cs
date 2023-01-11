/*Дан текст. В тексте нужно заменить все пробелы черточками, 
маленькие буквы "к" заменить большими "К", а большие "В" заменить маленькими "в".*/
Console.Clear();
string Text = "- Я думаю, - сказал князь, улыбаясь, - что, ежели бы вас послали вместо нашего милого Винценгероде,"+
              " вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";
void PrintText(string PrintText)
{
    int count = PrintText.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(PrintText[i]);
    }
    Console.WriteLine();
    Console.WriteLine();
}
string GetText(string ChangeText, char OldVariable, char NewVariable)
{
    string Proposal = string.Empty;
    int count = ChangeText.Length;
    for (int i = 0; i < count; i++)
    {
        if (ChangeText[i] == OldVariable)
        {
            Proposal = Proposal + NewVariable;
        }
        else
        {
            Proposal = Proposal + ChangeText[i];
        }        
    }
    return Proposal;
}
PrintText(Text);
string NewText_0 = GetText(Text, ' ', '|');
PrintText(NewText_0);
string NewText_1 = GetText(NewText_0, 'к', 'К');
PrintText(NewText_1);
string NewText_2 = GetText(NewText_1, 'В', 'в');
PrintText(NewText_2);