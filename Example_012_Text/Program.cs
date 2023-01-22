string text = "В Системе Охрана Труда появился Навигатор по типовым нормам СИЗ."
+"Он за 5 секунд найдет, какие СИЗ нужно выдать работнику. Просто введите в"
+" навигатор название должности и получите список. Попробуйте прямо сейчас!";

string Repl(string textvh, char oldval, char newval)
{
    string rezult = string.Empty; //пустая строка
    for (int i = 0; i < textvh.Length; i++)
    {
        if (textvh[i] == oldval) rezult = rezult+$"{newval}";
        else rezult = rezult+$"{textvh[i]}";  
    }
    return rezult;
}
string newtext = Repl(text, ' ', '-');
newtext = Repl(newtext, 'с', 'С');
newtext = Repl(newtext, 'к', 'К');
newtext = Repl(newtext, 'н', 'Н');
Console.WriteLine(newtext);