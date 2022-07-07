Console.WriteLine();
int [,] twoDimArray = new int[10, 10];
FillTwoDimensionalArray(twoDimArray);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();
RefillArrangeMaxToMinArray(twoDimArray);
PrintTwoDimArray(twoDimArray);
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
void RefillArrangeMaxToMinArray(int [,] a)
{
    int x = 0;
    int bufer = 0;
    int aLength = a.GetLength(1) - 1;
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < aLength; j++)
        {
            x = j + 1;
            if(a[i, j] < a[i, x])
            {
                bufer = a[i, x];
                a[i, x] = a[i, j];
                a[i, j] = bufer;
                if(j > 0)
                {
                    j = j - 2;
                }    
            }
        }
    }
}