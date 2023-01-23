// Задача:
// Напишите программу, которая принимает на вход
// координаты точки (Х и У), причём Х != 0 и У != 0
// и выдаёт номер четвёртой четверти плоскости, в которой
// находится эта точка.

Console.Write("Введите координату X: ");
int numX = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y: ");
int numY = Convert.ToInt32(Console.ReadLine());

string GetQuarter(int x, int y){
    
    if (x > 0 && y > 0) return "Первая четверть";
    if (x < 0 && y > 0) return "Вторая четверть";
    if (x < 0 && y < 0) return "Третья четверть";
    if (x > 0 && y < 0) return "Третья четверть";
    return "Введены некорректные координаты";

}

Console.WriteLine(GetQuarter(numX, numY));