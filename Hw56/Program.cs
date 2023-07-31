// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Заполнение двухмерного массива случайными числами

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] =  new Random().Next(0,10);
        }
    }
    return matrix;
}

// Печать двухмерного массива

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,8}", matrix[i,j]));
        }
        Console.WriteLine();
    }
}

// Сортировка строк двухмерного массива по убыванию

int MinSumRowMatrix(int[,] matrix)
{   
    int RowNumber= 0;
    bool FirstRow = true;
    int MinSumRowValue = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int SumRowValue = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumRowValue = SumRowValue + matrix[i,j];
        }
        if (FirstRow) 
        {
            FirstRow = false;
            MinSumRowValue = SumRowValue;
            RowNumber = i+1;
        }
        if (SumRowValue < MinSumRowValue)
        {
            MinSumRowValue = SumRowValue;
            RowNumber = i+1;
        }
    }
    return RowNumber;
}

/////////////////////////////////////////////////////////////////

int[,] NewArray = FillMatrix(5, 4);
PrintMatrix(NewArray);
Console.WriteLine();
Console.WriteLine($"Number of the row with the smallest sum of elements: {MinSumRowMatrix(NewArray)} row");