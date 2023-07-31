// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Заполнение двухмерного массива случайными числами

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] =  new Random().Next(-10,10);
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

void SortRowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int MaxValue = matrix[i,j];
            for (int n = j+1; n < matrix.GetLength(1); n++)
            {
                if (matrix[i,n] > MaxValue)
                {
                    MaxValue = matrix[i,n];
                    matrix[i,n]= matrix[i,j];
                }
            }
            matrix[i,j]=MaxValue;
        }        
    }
}

/////////////////////////////////////////////////////////////////

int[,] NewArray = FillMatrix(5, 4);
PrintMatrix(NewArray);
SortRowMatrix(NewArray);
Console.WriteLine();
PrintMatrix(NewArray);