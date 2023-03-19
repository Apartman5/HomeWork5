// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Примеры:
// [3 7 22 2 78] -> 76

int Prompt(string message)
{
    Console.Write(message); // Выводим приглашение ко вводу
    string readInput = Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); // приводим к числу
    return result;
}

double[] GenerateArray(int length, int minValue, int maxValue)
{
    double[] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(random.NextDouble() + random.Next(minValue, maxValue +1), 3);
    }
    return array;
}

void PrintArray(double[] array)
{
    for(int i =0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}|| ");
    }
    Console.WriteLine($"{array[array.Length - 1]}");
}

double DifferenceMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i =1; i < array.Length - 1; i++)
    {
        if (array[i] < min)
        min = array[i];
        else
        {
            if (array[i] > max)
            max = array[i];
        }
    }
    double diff = max - min;
    return diff;
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение диапазона случайных чисел ");
int max = Prompt("Конечное значение диапазона случайных чисел ");
double[] array = GenerateArray(length, min, max);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным значениями массива = {DifferenceMinMax(array)}");