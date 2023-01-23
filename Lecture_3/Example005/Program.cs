// Задача:
// Напишите программу, которая по заданному номеру
// четверти, показывает диапозон возможных координат
// точек в этой четверти(x и y)

Console.Write("Введите номер четверти: ");
int numQuart = Convert.ToInt32(Console.ReadLine());

string rangeCors(int Quart)
{
    if(Quart == 1) return "[x > 0 и y > 0]";
    if(Quart == 2) return "[x < 0 и y > 0]";
    if(Quart == 3) return "[x < 0 и y < 0]";
    if(Quart == 4) return "[x < 0 и y < 0]";
    return "Введены неверные данные";
    
}

Console.WriteLine(rangeCors(numQuart));