/*
Задача 3: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3.
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

void PrintArr(double [] array, int sign) // Вывод массива в консоль в виде [66,1,19,73,48,13,50,25], если sign = 0 конец массива начинается с новой строки, если sign = 1 то строка продолжается
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < (array.Length - 1)) Console.Write(array[i] + " ; ");
        if ((i == (array.Length - 1)) && (sign == 0))
        {
            Console.WriteLine(array[i] + " ]");
        }
        if ((i == (array.Length - 1)) && (sign == 1))
        {
            Console.Write(array[i] + " ]");
        }
    }
}


double[] AverageColMultiArra(int[,] array)

{
    double[] newArray = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i < array.GetLength(0) - 1) newArray[j] += Convert.ToDouble(array[i, j]);
            else newArray[j] = (newArray[j] + Convert.ToDouble(array[i, j])) / (i+1);
        }
    }
    return newArray;


}

System.Console.WriteLine("Размер массива");
int row = Prompt("Количество строк => ");
int column = Prompt("Количество столбцов => ");

int[,] array = GenerateMultiArray(row, column, -10, 10);

PrintMultiArray(array);
System.Console.WriteLine("");


double[] myArray = AverageColMultiArra(array);

System.Console.Write("Среднее арифметическое каждого столбца: ");
PrintArr(myArray,0);

