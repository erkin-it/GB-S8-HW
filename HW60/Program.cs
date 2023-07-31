// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Заполнение массива случайными числами
void FillRandom(int[,,] array3d, Random random)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                int randNumber = random.Next(10, 100);
 
                while (Array3dContains(array3d, randNumber))
                {
                    randNumber = random.Next(10, 100);
                }
    
                array3d[i, j, k] = randNumber;
            }
        }
    }
 
}

// Проверка числа на совпадение
bool Array3dContains(int[,,] array3d, int randNumber)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
            if (array3d[i, j, k] == randNumber) return true;
            }
        }
    }
 
    return false;
}

// Печать массива

void WriteArray3d(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(1); k++)
            {
                Console.Write(array3d[i, j, k] + "("+ i +"," + j + "," + k + ")  ");
            }
            Console.WriteLine();
        }
    }
}

//////////////////////////////////////////////////////////////

int[,,] array3d = new int[2, 2, 2];
 
FillRandom(array3d, new Random());

WriteArray3d(array3d);