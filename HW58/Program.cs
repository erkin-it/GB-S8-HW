// Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

// Заполнение двухмерного массива случайными числами

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] =  new Random().Next(1,5);
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
            Console.Write(string.Format("{0,4}", matrix[i,j]));
        }
        Console.WriteLine();
    }
}

// умножения матриц
    int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        int MatrixRowValue = matrixA.GetLength(0);
        int MatrixColumnValue = matrixB.GetLength(1);
        int CountValue = matrixA.GetLength(1);
        
        var matrixC = new int[MatrixRowValue, MatrixColumnValue];

        for (var i = 0; i < MatrixRowValue; i++)
        {
            for (var j = 0; j < MatrixColumnValue; j++)
            {
                matrixC[i, j] = 0;

                for (var k = 0; k < CountValue; k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }

    ////////////////////////////////////////////////////////////////////

    int[,] NewMatrixA = FillMatrix(2, 2);
    int[,] NewMatrixB = FillMatrix(2, 2);
    int[,] NewMatrixC = MatrixMultiplication(NewMatrixA, NewMatrixB);
    PrintMatrix(NewMatrixA);
    Console.WriteLine();
    PrintMatrix(NewMatrixB);
    Console.WriteLine("____________");
    PrintMatrix(NewMatrixC);
