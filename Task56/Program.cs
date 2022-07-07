Console.WriteLine();
int [,] twoDimArray = new int[15, 10];
FillTwoDimensionalArray(twoDimArray);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();
int minSumString = SearchMinSumString(twoDimArray);
int indexMin = minSumString - 1;
Console.WriteLine();
Console.WriteLine("Строка с наименьшей суммой значений: " + minSumString + " (index " + indexMin + ")");
Console.WriteLine();


void FillTwoDimensionalArray(int [,] a)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintTwoDimArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)          
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            if(a[i, j] < 0)
            {
                Console.Write(a[i, j] + " ");
            }
            if(a[i, j] < 10 && a[i, j] >= 0)
            {
                Console.Write(" " + a[i, j] + " ");
            }
            if(a[i, j] > 10)
            {
                Console.Write(a[i, j] + " ");
            }
            
        }
    Console.WriteLine("");
    }
}
int SearchMinSumString(int [,] a)
{
    int minSumStr = 0;
    int minSum = 0;
    int sumCurrent = 0;
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            sumCurrent = sumCurrent + a[i, j];
        }
        Console.WriteLine("Сумма строки " + (i + 1) + ": " + sumCurrent);
        if(i == 0)
        {
            minSum = sumCurrent;
            Console.WriteLine("Сумма мин: " + minSum);
        }
        if(sumCurrent < minSum)
        {
            minSum = sumCurrent;
            minSumStr = i;
            Console.WriteLine("Сумма мин: " + minSum);
        }
        sumCurrent = 0;
    }
    return (minSumStr + 1);
}