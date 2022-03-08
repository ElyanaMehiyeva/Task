// Elyanə Məhiyeva
#region 8Mart-Task1
string ad = "Azerbaycan";
char herf = 'a';
static int search (string text, char letter)
{
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == letter)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(search(ad,herf));
#endregion 8Mart-Task1

#region 8Mart-Task2
static decimal Sum (params decimal[] numbers)
{
    decimal result = 0m;
    foreach (decimal number in numbers)
    {
        result+=number;
    }     
    return result;
}
Console.WriteLine(Sum(2,3,5.4m,8.6m));

static int Sum2 (params int[] numbers)
{
    int result = 0; 
    foreach (int number in numbers)
    {
        result += number;
    }
    return result;
}
Console.WriteLine(Sum2(2,5,6,8));

#endregion 8Mart-Task2

#region 8Mart-Task3

static bool SearchElement(int search, int[] array)
{
    while (true)
    {
        int avg = array.Length / 2;
        if (array.Length>1)
        {
            if(array[avg] == search)
            {
                return true;
            } else
            {
                if (array[avg] > search)
                {
                    array = array[0..avg];
                } else if(array[avg]<search)
                {
                    array = array[avg..array.Length];
                } else
                {
                    return true;
                }
            }
        } else
        {
            if (array[avg] == search)
            {
                return true;
            } else
            {
                return false;
            }
            
        }
    }
}
int[] array = { 1, 2, 3, 4, 5 };
Console.WriteLine(SearchElement(23,array));
#endregion 8Mart-Task3

#region 8Mart-Task4

static int CircleArea(int radius)
{
    int pi = 3;
    return pi * radius * radius;
}
static int SquareArea(int a, int b)
{
    return a*b;
}
static int InsideCircleArea(int a, int b, int c, int radius)
{
    int p = (a + b + c) / 2;
    return p * radius;
}
Console.WriteLine(CircleArea(5));
Console.WriteLine(SquareArea(6,7));
Console.WriteLine(InsideCircleArea(3,4,5,5));
#endregion 8Mart-Task4