// Create a three-dimensional array of non-repeating two-digit numbers.
// Write a program that will output an array line by line, adding indexes of each element.

Console.Write("Enter X-dimention (less then 5) of the array: ");
int xDim = int.Parse(Console.ReadLine());
Console.Write("Enter Y-dimention (less then 5) of the array: ");
int yDim = int.Parse(Console.ReadLine());
Console.Write("Enter Z-dimention (less then 5) of the array: ");
int zDim = int.Parse(Console.ReadLine());

// Method to create, fill and return two-dimentional array with r-rows and c-columns
int[,,] CreateArray(int x, int y, int z)
{
    int[,,] arr = new int[x, y, z];
    int[] checkNumbers = new int[x * y * z];
    int indexCheck = 0;
    Random rnd = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                while (true)
                {
                    int temp = rnd.Next(10, 100);
                    if (checkNumbers.Contains(temp) == false)
                    {
                        arr[i, j, k] = temp;
                        checkNumbers[indexCheck] = temp;
                        indexCheck ++;
                        break;
                    }

                }
            }
        }
    }
    return arr;
}

// Method to print two-dimentional array
void ShowArray(int[,,] arr)
{
    Console.WriteLine("|{0, 10}|{1, 12}|", "Value", "Coordinates");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine("|{0, 10}|{1, 12}|", arr[i, j, k], $"[{i},{j},{k}]");
            }
        }
    }
}

int[,,] initialArray = CreateArray(xDim, yDim, zDim);
ShowArray(initialArray);