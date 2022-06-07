// Fill the 4-by-4 array spirally.

Console.Write("Enter number of rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter number of cols: ");
int cols = int.Parse(Console.ReadLine());
int counter = 1;
int rows_passed = 0, columns_passed = 0;
int current_row = 0, current_column = 0;

// Method to print two-dimentional array
void ShowArray(int[,] arr)
{
    for (int r = 0; r < arr.GetLength(0); r++)
    {
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            Console.Write(arr[r, c] + "\t");
        }
        Console.WriteLine();
    }
}

// Method to spirrally fill the array

void SpiralFill(int rows, int cols)
{
    int[,] testArr = new int[rows, cols];

    for (int i = 0; i < rows * cols; i++)
    {
        if (counter == rows * cols + 1) break;
        int direction = i % 4;
        if (direction == 0)
        {
            for (int j = columns_passed; j < cols - columns_passed; j++)
            {
                testArr[current_row, j] = counter;
                counter += 1;
            }
            current_column = cols - columns_passed - 1;
            rows_passed += 1;
        }
        else if (direction == 1)
        {
            for (int j = rows_passed; j < rows - rows_passed + 1; j++)
            {
                testArr[j, current_column] = counter;
                counter += 1;
            }
            current_row = rows - rows_passed;
            columns_passed += 1;
        }
        else if (direction == 2)
        {
            for (int j = current_column - 1; j > columns_passed - 2; j--)
            {
                testArr[current_row, j] = counter;
                counter += 1;
            }
            current_column = columns_passed - 1;
        }
        else if (direction == 3)
        {
            for (int j = current_row - 1; j > rows_passed - 1; j--)
            {
                testArr[j, current_column] = counter;
                counter += 1;
            }
            current_row = rows_passed;
        }
    }

    ShowArray(testArr);
}

SpiralFill(rows, cols);