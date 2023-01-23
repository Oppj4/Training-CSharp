// Задача:
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние 
// между ними в 2D пространстве.
// с = a**2 + b**2

Console.WriteLine("Введите координаты A(X, Y): ");
Console.Write("X: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int aY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты B(X, Y): ");
Console.Write("X: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int bY = Convert.ToInt32(Console.ReadLine());

double findDistance(int x1, int y1, int x2, int y2){
    int a = (x2 - x1) * (x2 - x1);
    int b = (y2 - y1) * (y2 - y1);
    double d = Math.Sqrt(a + b);
    return d;
}
double result = findDistance(aX, aY, bX, bY);
Console.WriteLine("Расстояние между точками: ~{0:#.###}", result);
