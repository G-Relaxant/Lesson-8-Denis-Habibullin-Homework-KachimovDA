/*Console.Write("Введите длину(число столбцов) массива: ");
int gorizontalLength = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту(число строк) массива: ");
int verticalLength = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину(число страниц) массива: ");
int widelLength = Convert.ToInt32(Console.ReadLine());
*/
int gorizontalLength = 5;
int verticalLength = 4;
int widelLength = 4;

int [,,] array = new int[verticalLength, gorizontalLength, widelLength];
Fill3DArray(array);
Print3DArrayWithIndexes(array);


void Fill3DArray(int [,,] a)
{
    int number = 10;
    for(int z = 0; z < a.GetLength(2); z++)
    {
        for(int y = 0; y < a.GetLength(0); y++)
        {
            for(int x = 0; x < a.GetLength(1); x++)
            {
            a[y, x, z] = number;
            number++;
            }
        }
    }
}
void Print3DArrayWithIndexes(int[,,] a)
{
    Console.WriteLine("Страница 1");
    for (int z = 0; z < a.GetLength(2); z++)          
    {
        for(int i = 0; i < a.GetLength(0); i++)
        {
            for(int j = 0; j < a.GetLength(1); j++)
            {
                if(a[i, j, z] < 10 && a[i, j, z] >= 0)
                {
                    Console.Write("  " + a[i, j, z] + "["+ i + ", " + j + ", " + z + "]" + " ");
                }
                if(a[i, j, z] >= 10 && a[i, j, z] < 100)
                {
                    Console.Write(" "+ a[i, j, z] + "["+ i + ", " + j + ", " + z + "]" + " ");
                }
                if(a[i, j, z] >= 100)
                {
                    Console.Write(a[i, j, z] + "["+ i + ", " + j + ", " + z + "]" + " ");
                }
            }
            Console.WriteLine();
        }
        //Console.WriteLine();
        if(z < widelLength - 1)
        {
            Console.WriteLine("Страница " + (z+2));
        }
    }
}