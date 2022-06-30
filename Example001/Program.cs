/*
Задача 1: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int Prompt(string message) // Ввод числа ( функция )
{
    Console.Write(message);
    string a_String = Console.ReadLine();
    return int.Parse(a_String);
}

double[,] GenerateMultiArray(int row, int column, double min, double max) // Заполнение случайными числами 2-х мерного массива. row - количество строк, column - количество колонок, min - минимальное генерируемое число, max - максимальное генерируемое число.
{
    var array = new double[row, column];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             array[i, j] = rnd.NextDouble() * (min - max) + max;
            
        }
    }

    return array;
}

void PrintMultiArray(double[,] array) // Запись многомерного массива в консоль.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");

            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j]:f1} | ");

            if (j == array.GetLength(1) - 1) Console.Write($"{array[i, j]:f1} ] ");
        }
        Console.WriteLine("");
    }

}
int row = Prompt("Количество строк => ");

int column = Prompt("Количество столбцов => ");

double[,] array = GenerateMultiArray(row, column, -10, 10);

PrintMultiArray(array);
