// Print the first N lines of Pascal's triangle 
// in the form of an isosceles triangle

Console.Write("Enter number of lines to show: ");
int linesNum = int.Parse(Console.ReadLine());

// Method to find factorial of number.
// Will be used to get an element of tha Pascal triangle
// P.s. we use float type cause with int there will be
// mistakes while counting big numbers
float Factorial(int n)
{
    float result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

// Method to print Pascal triangle into the console
void ShowPascalTriangle(int linesCount)
{
    for (int i = 0; i < linesNum; i++)
    {
        for (int j = 0; j <= (linesNum - i); j++)
        {
            Console.Write("   ");
        }
        for (int k = 0; k <= i; k++)
        {
            Console.Write("     ");
            Console.Write(Factorial(i) / (Factorial(k) * Factorial(i - k)));
        }
        Console.WriteLine("\n");
    }
}

ShowPascalTriangle(linesNum);