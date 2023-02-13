// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] FillMatrix(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(1, 10);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


void MultiplyMatrix(int[,] matrixA, int[,] matrixB, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}


int[,] matrixA = FillMatrix(2, 3);
System.Console.WriteLine($"Матрица А: ");
PrintMatrix(matrixA);
System.Console.WriteLine();
int[,] matrixB = FillMatrix(3, 3);
System.Console.WriteLine($"Матрица B: ");
PrintMatrix(matrixB);
if (matrixA.GetLength(1) != matrixB.GetLength(0))
{
    System.Console.WriteLine($"Произведение матриц не имеет смысла");
}
else
{
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    MultiplyMatrix(matrixA, matrixB, resultMatrix);
    Console.WriteLine($"Произведение первой и второй матриц:");
    PrintMatrix(resultMatrix);
}
