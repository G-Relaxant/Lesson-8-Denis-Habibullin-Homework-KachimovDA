Console.Write("Введите длину(число столбцов) матрицы A: ");
int gorizontalLengthA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту(число строк) матрицы A: ");
int verticalLengthA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину(число столбцов) матрицы B: ");
int gorizontalLengthB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту(число строк) матрицы B: ");
int verticalLengthB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Matrix A:");
int [,] matrixA = new int[verticalLengthA, gorizontalLengthA];
FillMatrix(matrixA);
PrintMatrix(matrixA);
Console.WriteLine();
Console.WriteLine("Matrix B:");
int [,] matrixB = new int[verticalLengthB, gorizontalLengthB];
FillMatrix(matrixB);
PrintMatrix(matrixB);
Console.WriteLine();
if(gorizontalLengthA == verticalLengthB)
{
    Console.WriteLine("Matrix product A*B:");
    int [,] productMatrix = new int[verticalLengthA, gorizontalLengthB];
    CalculateAndFillProductMatrix(matrixA, matrixB, productMatrix);
    PrintMatrix(productMatrix);
}
else
{
    Console.WriteLine("Произведение матриц с заданными параметрами невозможно. Необходимо, что бы число столбцов первой матрицы было равно числу строк второй матрицы");
}


void FillMatrix(int [,] a)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintMatrix(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)          
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            if(a[i, j] < 10 && a[i, j] >= 0)
            {
                Console.Write("  " + a[i, j] + " ");
            }
            if(a[i, j] >= 10 && a[i, j] < 100)
            {
                Console.Write(" "+ a[i, j] + " ");
            }
            if(a[i, j] >= 100)
            {
                Console.Write(a[i, j] + " ");
            }
        }
    Console.WriteLine("");
    }
}
void CalculateAndFillProductMatrix(int [,] a, int [,] b, int [,] c)
{
    int product = 0;
    for(int i = 0; i < verticalLengthA; i++)
    {
        for(int x = 0; x < gorizontalLengthB; x++)
        {
            for(int j = 0; j < gorizontalLengthA; j++)
            {
                product = product + (a[i,j] * b[j, x]);
            }
            c[i,x] = product;
            product = 0;
        }
    }
}