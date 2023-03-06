static int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void arrayFilling(int[,] arrayFillVoid)
{
    Random digit = new Random();
    for(int i = 0; i<arrayFillVoid.GetLength(0); i++)
    {
        for(int j = 0; j<arrayFillVoid.GetLength(1); j++)
        {
            arrayFillVoid[i, j] = digit.Next(-10, 11);
        }
    }
}

static void arrayPrint(int[,] arrayPrintVoid)
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

static void arrayAverageOf(int[,] arrayAverageVoid)
{
    for (int i = 0; i<arrayAverageVoid.GetLength(0); i++)
        {
            double sumOfLine = 0;
            int count = 0;
            for (int j = 0; j<arrayAverageVoid.GetLength(1); j++)
            {
                if(j == arrayAverageVoid.GetLength(1)-1)
                {
                    count++;
                    sumOfLine = sumOfLine + arrayAverageVoid[i,j];
                    double averageValueofLines = Math.Round(sumOfLine/count, 3);
                    System.Console.WriteLine($"Average of {i+1} lines: {averageValueofLines}");
                }
                count++;
                sumOfLine = sumOfLine + arrayAverageVoid[i,j];
            }
        }
}

int m = Prompt("Input amount of array lines? - ");
int n = Prompt("Input amount of array columns? - ");

int[,] array = new int[m, n];
arrayFilling(array);
arrayPrint(array);
System.Console.WriteLine();
arrayAverageOf(array);
System.Console.WriteLine();