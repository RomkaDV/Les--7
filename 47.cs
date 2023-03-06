static int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
static void arrayFilling(double[,] arrayFillVoid)
{
    Random digit = new Random();
    for(int i = 0; i<arrayFillVoid.GetLength(0); i++)
    {
        for(int j = 0; j<arrayFillVoid.GetLength(1); j++)
        {
            arrayFillVoid[i, j] = Math.Round(digit.Next(-100, 101) + digit.NextDouble(), 2);
        }
    }
}

static void arrayPrint(double[,] arrayPrintVoid)
{
    for(int i = 0; i<arrayPrintVoid.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j<arrayPrintVoid.GetLength(1); j++)
        {
            System.Console.Write(arrayPrintVoid[i,j] + "    ");
        }
    }
}

int m = Prompt("Input amount of array lines? - ");
int n = Prompt("Input amount of array columns? - ");

double[,] array = new double[m, n];
arrayFilling(array);
arrayPrint(array);
System.Console.WriteLine();