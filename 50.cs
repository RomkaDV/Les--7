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
            arrayFillVoid[i, j] = digit.Next(-100, 101);
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

static void arraySearchValue(int[,] arraySearchVoid, int positionArraySearchVoid)
{
    int searchPosition = 0;

    if (arraySearchVoid.GetLength(0)*arraySearchVoid.GetLength(1) < positionArraySearchVoid)
    {
        System.Console.WriteLine($"You need reduce a number of position, total number = {arraySearchVoid.GetLength(0)*arraySearchVoid.GetLength(1)}");
    }
    else 
    {
        for (int i = 0; i<arraySearchVoid.GetLength(0); i++)
        {
            for (int j = 0; j<arraySearchVoid.GetLength(1); j++)
            {
                if(searchPosition == positionArraySearchVoid-1)
                {
                    System.Console.WriteLine(arraySearchVoid[i,j]);
                    searchPosition++;
                    break;
                }
                searchPosition++;
            }
        }
    }
}


int m = new Random().Next(5, 10);
int n = new Random().Next(5, 10);

int[,] array = new int[m, n];
arrayFilling(array);
arrayPrint(array);
System.Console.WriteLine();
System.Console.WriteLine();
int inputPosition = Prompt("Please enter searching position: ");
System.Console.Write("The value of inputted position: ");
arraySearchValue(array, inputPosition);