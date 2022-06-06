// Specify a two-dimensional array.
// Write a program that will sort the elements of each row of a two-dimensional array in descending order.

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

// Method to swap two nearby elements in a row of two-dimentional array
void Swap(int[,] array, int r, int i, int j)
{
    int temp = array[r, i];
    array[r, i] = array[r, j];
    array[r, j] = temp;
}

// Method for descending sort every row of two-dimentional array
void DescendingSortArrayRows(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int element;
        int index;
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            element = arr[i,j];
            index = j;
            while (index > 0 && arr[i, index - 1] < element)
            {
                Swap(arr, i, index, index - 1);
                index -= 1;
            }
            arr[i, index] = element;
        }
    }
}

int[,] initialArray = CreateArray(rows, cols);
ShowArray(initialArray);
Console.WriteLine();
DescendingSortArrayRows(initialArray);
ShowArray(initialArray);
