// Задача 52. Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");

int[,] numbers = new int[rows, colums];
FillArray2D(numbers);
PrintArray2D(numbers);
Console.WriteLine();
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / rows;
    Console.Write(avarage + "; ");
}

int ReadInt(string message) // Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray2D(int[,] array) // Заполнение массива рандомными числами от 1 до 9
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array) //  Функция вывода массива в терминал
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}