//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetArray(int[] arr)                 // Ввод массива пользователем
{
    Console.Write("Введите массив из 8 элементов: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}


void PrintArray(int[] arr)                // Печать массива
{
    Console.Clear();
    Console.Write("Введенный вами массив: [");
    for (int i = 0; i < arr.Length - 1; i++) Console.Write(arr[i] + ", ");
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] array = new int[8];
array = GetArray(array);
PrintArray(array);
