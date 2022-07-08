// Мой вариант, работает только для квадратов

int [,] array = new int[9, 9];
FillArraySpiral(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();


void FillArraySpiral(int [,] a)
{
    int number = 1;
    int endCellY = a.GetLength(0) / 2;
    int endCellX = a.GetLength(1) / 2 - 1;
    //Console.WriteLine("Test " + endCellY + ", " + endCellX);
    //Console.WriteLine();
    int yReducingLength = a.GetLength(0) - 1;
    int xReducingLength = a.GetLength(1) - 1;
    int yReducingLengthReverse = 0;
    int xReducingLengthReverse = 0;
    int y = 0;
    int x = 0;
    int yCheck = y;
    int xCheck = x;
    int guideArrow = 0;
    int guideArrowRelay = 0;
    a[0, 0] = number;
    //Console.WriteLine("Test " + a[y, x] + " [" + y + ", " + x + "]");
    number++;
    while(yCheck != endCellY || xCheck != endCellX)
    {
        guideArrow = guideArrowRelay;
        yCheck = y;
        //Console.WriteLine("Test Check " + yCheck + ", " + xCheck);
        if(guideArrow == 0)
        {
            x++;
            xCheck = x;
            a[y, x] = number;
            //Console.WriteLine("Test " + a[y, x] + " [" + y + ", " + x + "]");
            number++;
            if(x == xReducingLength)
            {
                guideArrowRelay++;
            }
        }
        if(guideArrow == 1)
        {
            y++;
            yCheck = y;
            a[y, x] = number;
            //Console.WriteLine("Test " + a[y, x] + " [" + y + ", " + x + "]");
            number++;
            if(y == yReducingLength)
            {
                guideArrowRelay++;
            }
        }
        if(guideArrow == 2)
        {
            x--;
            xCheck = x;
            a[y, x] = number;
            //Console.WriteLine("Test " + a[y, x] + " [" + y + ", " + x + "]");
            //if(y == endCellY && x == endCellX)
            //{
            //    break;
            //}
            number++;
            if(x == xReducingLengthReverse)
            {
                guideArrowRelay++;
                y--;
            }
        }
        if(guideArrow == 3)
        {
            a[y, x] = number;
            //Console.WriteLine("Test " + a[y, x] + " [" + y + ", " + x + "]");
            number++;
            y--;
            yCheck = y;
            if(y == yReducingLengthReverse)
            {
                guideArrowRelay = 0;
                y++;
                yCheck = y;
                yReducingLength--;
                xReducingLength--;
                yReducingLengthReverse++;
                xReducingLengthReverse++;
            }
        }
    }
    if(a.GetLength(0) % 2 == 1)
    {
        a[endCellY, endCellX + 1] = number;
    }
}
void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)          
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            if(a[i, j] < 10 && a[i, j] >= 0)
            {
                Console.Write(" " + a[i, j] + " ");
            }
            if(a[i, j] >= 10 && a[i, j] < 100)
            {
                Console.Write(""+ a[i, j] + " ");
            }
            if(a[i, j] >= 100)
            {
                Console.Write(a[i, j] + " ");
            }
        }
    Console.WriteLine("");
    }
}




// Вариант Михаила Меркушева
/*
Console.Write("Введите размерность массива, который будем заполнять: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= n * n)
{
array[i,j] = temp;
if (i <= j + 1 && i + j < n - 1)
++j;
else if (i < j && i + j >= n - 1)
++i;
else if (i >= j && i + j > n - 1)
--j;
else
--i;
++temp;
}
for (int c = 0; c < array.GetLength(0); c++)
{
for (int d = 0; d < array.GetLength(1); d++)
{
Console.Write( $"{array[c,d]:d3} ");
}
Console.WriteLine();
}
Console.WriteLine();
*/