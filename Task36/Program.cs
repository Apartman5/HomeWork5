// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Примеры:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Prompt(string message)
{
    Console.Write(message); // Выводим приглашение ко вводу
    string readInput = Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); // приводим к числу
    return result;
}

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue +1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i =0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

int SumOddElements(int[] array)
{
    int sum = 0;
    for(int i =1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение диапазона случайных чисел ");
int max = Prompt("Конечное значение диапазона случайных чисел ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);
Console.WriteLine($"Сумма нечетных элементов массива - {SumOddElements(array)}");