// Specify a rectangular two-dimensional array.
// Write a program that will find the string with the smallest sum of elements.

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

int[] FindRowWithMinimalSum(int[,] arr)
{
    int[] result = new int[2]{0, int.MaxValue};
    for (int r = 0; r < arr.GetLength(0); r++)
    {
        int sum = 0;
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            sum += arr[r, c];
        }
        if (sum < result[1])
        {
            result[0] = r;
            result[1] = sum;
        }
    }

    return result;
}

int[,] initialArray = CreateArray(rows, cols);
ShowArray(initialArray);
int[] answer = FindRowWithMinimalSum(initialArray);
Console.WriteLine($"Minimal sum is {answer[1]} in {answer[0]} row.");