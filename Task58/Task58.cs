// Specify two matrices. Write a program that will find the product of two matrices.
// !!!Attention!!!
// Product of two matrices is possible only when number of rows in first matrix
// is equal to number of columns in second matrix.

Console.Write("Enter number of rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter number of cols: ");
int cols = int.Parse(Console.ReadLine());

// Method to create, fill and return two-dimentional array with r-rows and c-columns
int[,] CreateArray(int r, int c)
{
    int[,] arr = new int[r, c];
    Random rnd = new Random();
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            arr[i, j] = rnd.Next(0, 11);
        }
    }
    return arr;
}

// Method to print two-dimentional array
void ShowArray(int[,] arr)
{
    for (int r = 0; r < arr.GetLength(0); r++)
    {
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            Console.Write(arr[r, c] + " ");
        }
        Console.WriteLine();
    }
}

// Method to find and return the product of two matrices.
int[,] FindMatricesProduct(int[,] firstMat, int[,] secondMat)
{
    int[,] result = new int[firstMat.GetLength(0), firstMat.GetLength(0)];

    for (int r = 0; r < firstMat.GetLength(0); r++)
    {
        for (int c = 0; c < secondMat.GetLength(1); c++)
        {
            for (int k = 0; k < secondMat.GetLength(0); k++)
            {
                result[r, c] += firstMat[r,k] * secondMat[k,c];
            }
        }
    }
    return result;
}

int[,] firstMatrix = CreateArray(rows, cols);
int[,] secondMatrix = CreateArray(cols, rows);
ShowArray(firstMatrix);
Console.WriteLine();
ShowArray(secondMatrix);
Console.WriteLine();
Console.WriteLine("The product of two matrices is: ");
ShowArray(FindMatricesProduct(firstMatrix, secondMatrix));