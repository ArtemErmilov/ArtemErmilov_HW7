/*
Задача 2: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
*/

int Prompt(string message) // Ввод числа ( функция )
{
    Console.Write(message);
    string a_String = Console.ReadLine();
    return int.Parse(a_String);
}

int[,] GenerateMultiArray(int row, int column, int min, int max) // Заполнение случайными числами 2-х мерного массива. row - количество строк, column - количество колонок, min - минимальное генерируемое число, max - максимальное генерируемое число.
{
    var array = new int[row, column];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }

    return array;
}

void PrintMultiArray(int[,] array) // Запись многомерного массива в консоль.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");

            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + ",");

            if (j == array.GetLength(1) - 1) Console.Write(array[i, j] + "]");
        }
        Console.WriteLine("");
    }

}

(int, bool) SearchNumberMultiArra(int[,] array, int row, int column)

{
    int i = array.GetLength(0);
    int j = array.GetLength(1);
    bool noNumber = false;
    int number = 0;
    if (i  >= row && j >= column)
    {
        number = array[row-1, column-1];
        noNumber = true;
        return (number, noNumber);
    }
    else return (number, noNumber);

}

int row = Prompt("Количество строк => ");

int column = Prompt("Количество столбцов => ");

int[,] array = GenerateMultiArray(row, column, 0, 20);

PrintMultiArray(array);
System.Console.WriteLine("");


System.Console.WriteLine("Поиск числа в массиве");
int IRow = Prompt("Введите № строки => ");
int IColumn = Prompt("Введите № столбца => ");

(int newNumber, bool noNumber) = SearchNumberMultiArra(array , IRow, IColumn);

if (noNumber==true ) System.Console.WriteLine($" По адресу ( {IRow}, {IColumn} ) в массиве находится число {newNumber} ");
else System.Console.WriteLine($" Адреса ( {IRow}, {IColumn} ) нет в массиве");
