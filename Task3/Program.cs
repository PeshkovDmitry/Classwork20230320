// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да



void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9;9]
}


void ReleaseArray(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == n) {
            Console.WriteLine("да");
            return;
        }
        Console.WriteLine("нет");
}


void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}


Console.Clear();
Console.Write($"Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
Console.Write($"Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
ReleaseArray(array, n1);
