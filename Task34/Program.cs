// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Примеры:
// [345, 897, 568, 234] -> 2

int Prompt(string message)
{
    Console.Write(message); // Выводим приглашение ко вводу
    string readInput = Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); // приводим к числу
    return result;
}

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
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

int QuantityEvenNumber(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        sum++;
    }
    return sum;
}

int length = Prompt("Длина массива: ");// любое число
int[] array = GenerateArray(length);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве - {QuantityEvenNumber(array)}");