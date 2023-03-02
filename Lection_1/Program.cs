internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = CreateRandomArray();
        int[] rengeArray = GetRangeSum(array, 3);
        ShowArray(array);
        ShowArray(rengeArray);
    }
 /*
 Дан одномерный массив array n элементов, посчитать суммы трех последовательный элементов,
 т.е. sum = array[0] + array[1] + array[2], sum = array[1] + array[2] + array[3]
 sum = array[2] + array[3] + array[4], ... sum = array[n-2] + array[n-1] + array[n]
 */
     static int[] GetRangeSum(int[] array, int m)
    {
        int n = array.Length;
        int[] getRange = new int[n - m + 1];
        int index = 0;
        for (int i = 0; i <= n - m; i++)
        {
            for (int j = i; j < i + m; j++)
            {
                getRange[index] += array[j];
            }
            index++;
        }
        return getRange;
    }

    static int[] CreateRandomArray()
    {
        System.Console.WriteLine("Enter the rows of the array: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the minimum value of the array ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the maximum value of the array ");
        int maxValue = Convert.ToInt32(Console.ReadLine());
       
        int[] array = new int[rows];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            array[i] = new Random().Next(minValue, maxValue + 1);
         
        }
        return array;
    }

    static void ShowArray(int[] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            System.Console.Write(array[i] + "\t");
        }
        System.Console.WriteLine();
    }

}