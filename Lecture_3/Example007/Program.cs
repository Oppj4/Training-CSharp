// Задача:
// Напишите программу, которая принимает
// на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void SquareNums(int n)
{
    int temp = n;
    if(temp < 0){
        temp *= -1;
    }

    for(int i = 1; i <= temp; i++)
    {   
        if(num != temp)
        {
            Console.Write($"| ");
            Console.WriteLine($"Квадрат числа -{i} -> {Math.Pow(i, 2)}");
        }
        else
        {
            Console.Write($"| ");
            Console.WriteLine($"Квадрат числа {i} -> {Math.Pow(i, 2)}");
        }
    }
}
SquareNums(num);
