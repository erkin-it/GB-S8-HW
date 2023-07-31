// Напишите программу, которая заполнит спирально массив 4 на 4.

// Заполнение массива спиралью.
int[,] GetSpire(int n)
{
    var result = new int[n, n];
    int N=n; 
    int M=n;
    
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
    
    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= N * M){
        result[i,j] = k;
        if (i == Ibeg && j < M - Jfin - 1)
            ++j;
        else if (j == M - Jfin - 1 && i < N - Ifin - 1)
            ++i;
        else if (i == N - Ifin - 1 && j > Jbeg)
            --j;
        else
            --i;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1)){
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++k;
    }
    return result;
}

// Печать двухмерного массива

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:d2}  ", matrix[i,j]));
        }
        Console.WriteLine();
    }
}

/////////////////////////////////////////////////////////////////////////////////////

int n = 4;
var a = GetSpire(n);
PrintMatrix(a);