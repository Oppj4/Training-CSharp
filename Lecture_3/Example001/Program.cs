// Задача:
// Вывод таблицы умножения

for(int i = 2; i <= 9; i++)
{   
    for(int j = 1; j <= 9; j++)
    {
        Console.WriteLine($"{i} X {j} = {i * j}");
    }
    Console.WriteLine($"     ==========[{i}]==========");
}