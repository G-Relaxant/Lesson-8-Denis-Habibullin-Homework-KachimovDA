Console.Write("Введите длину горизонтальной одномерной матрицы: ");
int gorizontalLength = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину вертикальной одномерной матрицы: ");
int verticalLength = Convert.ToInt32(Console.ReadLine());
int [] oneDimArray = new int[gorizontalLength];
FillOneDimensionalArray(oneDimArray);
Console.WriteLine();
PrintOneDimArray(oneDimArray);
Console.WriteLine();
int [,] twoDimArray = new int[verticalLength, 1];
FillTwoDimensionalArray(twoDimArray);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();
int [] matrix = new int[verticalLength, gorizontalLength];



void FillOneDimensionalArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 10);
    }
}
void PrintOneDimArray(int[] b)
{
    Console.Write("[");
    for(int i = 0; i < b.Length; i++)
    {
        Console.Write(b[i]);
        if(i < b.Length - 1)
            Console.Write(", ");
        else
            Console.WriteLine("]");
    }
}
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