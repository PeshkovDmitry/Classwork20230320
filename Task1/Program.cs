// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// task 31
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9;9]
}


void ReleaseArray(int[] array)
{
    int sum_p = 0, sum_n = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            sum_p += array[i];
        else
            sum_n += array[i];
    Console.WriteLine($"Сумма отрицательных элемнетов = {sum_n}");
    Console.WriteLine($"Сумма положительные элемнетов = {sum_p}");
}


void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}


Console.Clear();
Console.Write($"n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
ReleaseArray(array);