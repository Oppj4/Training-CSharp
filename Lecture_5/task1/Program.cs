// Задача 1.
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных
// элементов массива.

// Например, в массиве [
//                         3, 9, -8, 
//                         1, 0, -7, 
//                         2, -1, 8, 
//                         -3, -1, 6,
//                     ]
// сумма положительных чисел равна 29,
// сумма отрицательных чисел равно -20.


int[] create_random_array(int size, int min, int max)
{   
    int[] array = new int[size];
    Random rnd = new Random(); 

    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }

    return array;
}

void print_array(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(i == 0) Console.Write($"[{arr[i]}, ");
        else if (i == arr.Length-1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}

int[] get_sum_pos_neg_elem(int[] arr)
{
    int positiv = 0;
    int negative = 0;
    for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] > 0) positiv += arr[i];
            else negative += arr[i];
        }
    return new int[]{positiv, negative};
}



int[] array = create_random_array(12, -9, 9);

print_array(array);

Console.WriteLine("\n");

int[] sum_pos_neg_arr = get_sum_pos_neg_elem(array);

Console.WriteLine($"Сумма положительных чисел: {sum_pos_neg_arr[0]}.");
Console.WriteLine($"Сумма отрицательных чисел: {sum_pos_neg_arr[1]}.");