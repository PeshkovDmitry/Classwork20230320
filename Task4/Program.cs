// Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, 
// если из последовательности удалить наибольший элемент.

// 1 2 3 5 3 4

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        if (i < 2) {
            array[i] = new Random().Next(1, 101); // [1;100]
        } else {
            array[i] = new Random().Next(0, 101); // [0;100]    
        }
        array[array.Length-1] = 0; // [-9;9]
}


void ReleaseArray(int[] array)
{
    int max1 = 0;
    int max2 = 0;
    for (int i = 0; i < array.Length; i++) {

        if (array[i] > max2) {
            max1 = max2;
            max2 = array[i];
        } else if (array[i] > max1) {
            max1 = array[i];
        }
    }
    Console.WriteLine($"Второй максимум {max1}");
}


void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}


Console.Clear();
Console.Write($"Введите размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
int[] array = {1, 2, 3, 5, 3, 4};
PrintArray(array);
ReleaseArray(array);