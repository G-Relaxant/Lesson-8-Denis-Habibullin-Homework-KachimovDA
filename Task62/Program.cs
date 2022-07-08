int [,] array = new int[4, 4];
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
    int yReducingLength = a.GetLength(0) - 1;
    int xReducingLength = a.GetLength(1) - 1;
    int yReducingLengthReverse = 0;
    int xReducingLengthReverse = 0;
    int y = 0;
    int x = 0;
    int guideArrow = 0;
    a[0, 0] = number;
    //Console.WriteLine("Test " + a[y, x] + " [" + y + ", " + x + "]");
    number++;
    while(y != endCellY || x != endCellX)
    {
        //Console.WriteLine("Test " + a[y, x] + " [" + y + ", " + x + "]");
        if(guideArrow == 0)
        {
            x++;
            a[y, x] = number;
            //Console.WriteLine("Test " + a[y, x] + " [" + y + ", " + x + "]");
            number++;
            if(x == xReducingLength)
            {
                guideArrow++;
            }
        }
        if(guideArrow == 1)
        {
            y++;
            a[y, x] = number;
            //Console.WriteLine("Test " + a[y, x] + " [" + y + ", " + x + "]");
            number++;
            if(y == yReducingLength)
            {
                guideArrow++;
            }
        }
        if(guideArrow == 2)
        {
            x--;
            a[y, x] = number;
            //Console.WriteLine("Test " + a[y, x] + " [" + y + ", " + x + "]");
            if(y == endCellY && x == endCellX)
            {
                break;
            }
            number++;
            if(x == xReducingLengthReverse)
            {
                guideArrow++;
                y--;
            }
        }
        if(guideArrow == 3)
        {
            a[y, x] = number;
            //Console.WriteLine("Test " + a[y, x] + " [" + y + ", " + x + "]");
            number++;
            y--;
            if(y == yReducingLengthReverse)
            {
                guideArrow = 0;
                y++;
                yReducingLength--;
                xReducingLength--;
                yReducingLengthReverse++;
                xReducingLengthReverse++;
            }
        }
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