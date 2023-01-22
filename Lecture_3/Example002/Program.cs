// Задача:
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы "к" заменить большими "К",
// а большие "C" заменить маленькими "c"


string Replace(string text)
{
    string result = "";
    for(int i = 0; i < text.Length; i++)
    {

        if(text[i] == 'к') result += "К";

        else if(text[i] == 'C') result += "с";

        else if(text[i] == ' ') result += "-";

        else result += text[i];
    }
    return result;
} 

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
                + "ежели бы вас послали вместо милого Винценгероде, "
                + "вы бы взяли приступом согласие прусского короля. "
                + "Вы так красноречивы. Вы дадите мне чаю?";

Console.WriteLine(Replace(text));

            