// See https://aka.ms/new-console-template for more information

int[] arr = new int[5]{1,2,3,4,5};
Console.WriteLine(arr.Contains(3));
Console.WriteLine(arr.Contains(7));

int[] arr2 = new int[10];
for (int i = 0; i < arr2.Length; i++)
{
    Console.Write(arr2[i]);
}
Random rnd = new Random();

for (int i = 0; i < arr2.Length; i++)
{
    while(true)
    {
        int temp = rnd.Next(1,9);
        if (arr2.Contains(temp))
        {
            Console.WriteLine("пропущено " + temp);
        }
        else
        {
            arr2[i] = temp;
            break;
        }
    }
}
for (int i = 0; i < arr2.Length; i++)
{
    Console.Write(arr2[i] + " ");
}